using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    /// <summary>Antrenörlerin hangi branşlarda görev yaptığını yönetir (çoka-çok ilişki).</summary>
    public interface IBransAntrenorService
    {
        void Ekle(BransAntrenor bransAntrenor);
        void Sil(int bransAntrenorId);
        List<BransAntrenor> Listele();
    }

    public class BransAntrenorService : IBransAntrenorService
    {
        protected SporKulubuDB db;

        public BransAntrenorService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(BransAntrenor bransAntrenor)
        {
            Dogrulama.Secili(bransAntrenor.AntrenorId, "bir antrenör");
            Dogrulama.Secili(bransAntrenor.BransId, "bir branş");

            if (!db.Antrenorler.Any(a => a.AntrenorId == bransAntrenor.AntrenorId))
                throw new KuralHatasi("Seçilen antrenör bulunamadı.");

            if (!db.Branslar.Any(b => b.BransId == bransAntrenor.BransId))
                throw new KuralHatasi("Seçilen branş bulunamadı.");

            bool zatenAtanmis = db.BransAntrenorler.Any(ba =>
                ba.AntrenorId == bransAntrenor.AntrenorId && ba.BransId == bransAntrenor.BransId);
            if (zatenAtanmis)
                throw new KuralHatasi("Bu antrenör bu branşa zaten atanmış.");

            db.BransAntrenorler.Add(bransAntrenor);
            db.SaveChanges();
        }

        public void Sil(int bransAntrenorId)
        {
            Dogrulama.Secili(bransAntrenorId, "listeden bir kayıt");

            var kayit = db.BransAntrenorler.Find(bransAntrenorId)
                        ?? throw new KuralHatasi("Kayıt bulunamadı.");

            db.BransAntrenorler.Remove(kayit);
            db.SaveChanges();
        }

        public List<BransAntrenor> Listele()
        {
            return db.BransAntrenorler
                .Include(ba => ba.Antrenor)
                .Include(ba => ba.Brans)
                .OrderBy(ba => ba.Brans.BransAd)
                .ThenBy(ba => ba.Antrenor.AntrenorAd)
                .ToList();
        }
    }
}
