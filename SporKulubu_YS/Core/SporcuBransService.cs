using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    /// <summary>Sporcuların hangi branşlarda olduğunu yönetir (çoka-çok ilişki).</summary>
    public interface ISporcuBransService
    {
        void Ekle(SporcuBrans sporcuBrans);
        void Sil(int sporcuBransId);
        List<SporcuBrans> Listele();
    }

    public class SporcuBransService : ISporcuBransService
    {
        protected SporKulubuDB db;

        public SporcuBransService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(SporcuBrans sporcuBrans)
        {
            Dogrulama.Secili(sporcuBrans.SporcuId, "bir sporcu");
            Dogrulama.Secili(sporcuBrans.BransId, "bir branş");

            if (!db.Sporcular.Any(s => s.SporcuId == sporcuBrans.SporcuId))
                throw new KuralHatasi("Seçilen sporcu bulunamadı.");

            if (!db.Branslar.Any(b => b.BransId == sporcuBrans.BransId))
                throw new KuralHatasi("Seçilen branş bulunamadı.");

            bool zatenKayitli = db.SporcuBranslar.Any(sb =>
                sb.SporcuId == sporcuBrans.SporcuId && sb.BransId == sporcuBrans.BransId);
            if (zatenKayitli)
                throw new KuralHatasi("Bu sporcu bu branşa zaten kayıtlı.");

            db.SporcuBranslar.Add(sporcuBrans);
            db.SaveChanges();
        }

        public void Sil(int sporcuBransId)
        {
            Dogrulama.Secili(sporcuBransId, "listeden bir kayıt");

            var kayit = db.SporcuBranslar.Find(sporcuBransId)
                        ?? throw new KuralHatasi("Kayıt bulunamadı.");

            db.SporcuBranslar.Remove(kayit);
            db.SaveChanges();
        }

        public List<SporcuBrans> Listele()
        {
            return db.SporcuBranslar
                .Include(sb => sb.Sporcu)
                .Include(sb => sb.Brans)
                .OrderBy(sb => sb.Brans.BransAd)
                .ThenBy(sb => sb.Sporcu.SporcuAd)
                .ToList();
        }
    }
}
