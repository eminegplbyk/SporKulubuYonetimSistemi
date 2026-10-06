using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    public interface IBransService
    {
        void Ekle(Brans brans);
        void Sil(int bransId);
        void Guncelle(Brans brans);
        Brans? Getir(int bransId);
        List<Brans> Listele();
    }

    public class BransService : IBransService
    {
        protected SporKulubuDB db;

        public BransService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Brans brans)
        {
            Dogrula(brans);

            db.Branslar.Add(brans);
            db.SaveChanges();
        }

        /// <summary>
        /// Veritabanında branş silinince bağlı salon, etkinlik ve atamalar da silinir (cascade).
        /// Yanlışlıkla veri kaybı olmasın diye bağlı kayıt varsa silmeye izin verilmez.
        /// </summary>
        public void Sil(int bransId)
        {
            Dogrulama.Secili(bransId, "listeden bir branş");

            var brans = db.Branslar
                            .Include(b => b.SporcuBranslar)
                            .Include(b => b.BransAntrenorler)
                            .Include(b => b.Salonlar)
                            .Include(b => b.Etkinlikler)
                            .FirstOrDefault(b => b.BransId == bransId)
                        ?? throw new KuralHatasi("Branş bulunamadı.");

            List<string> bagliKayitlar = new();
            if (brans.SporcuBranslar.Count > 0) bagliKayitlar.Add($"{brans.SporcuBranslar.Count} sporcu");
            if (brans.BransAntrenorler.Count > 0) bagliKayitlar.Add($"{brans.BransAntrenorler.Count} antrenör");
            if (brans.Salonlar.Count > 0) bagliKayitlar.Add($"{brans.Salonlar.Count} salon");
            if (brans.Etkinlikler.Count > 0) bagliKayitlar.Add($"{brans.Etkinlikler.Count} etkinlik");

            if (bagliKayitlar.Count > 0)
                throw new KuralHatasi(
                    $"'{brans.BransAd}' branşına bağlı {string.Join(", ", bagliKayitlar)} var. Önce bu kayıtları silin veya başka branşa taşıyın.");

            db.Branslar.Remove(brans);
            db.SaveChanges();
        }

        public void Guncelle(Brans brans)
        {
            Dogrulama.Secili(brans.BransId, "listeden bir branş");
            Dogrula(brans);

            var eskiKayit = db.Branslar.Find(brans.BransId)
                            ?? throw new KuralHatasi("Branş bulunamadı.");

            // Sadece ad güncellenir (ilişkili listeler ayrı ekranlardan yönetilir)
            eskiKayit.BransAd = brans.BransAd;
            db.SaveChanges();
        }

        public Brans? Getir(int bransId)
        {
            return db.Branslar.Find(bransId);
        }

        /// <summary>Branşları, sayıları göstermek için ilişkili kayıtlarıyla birlikte getirir.</summary>
        public List<Brans> Listele()
        {
            return db.Branslar
                .Include(b => b.SporcuBranslar)
                .Include(b => b.BransAntrenorler)
                .Include(b => b.Salonlar)
                .Include(b => b.Etkinlikler)
                .OrderBy(b => b.BransAd)
                .ToList();
        }

        private void Dogrula(Brans brans)
        {
            brans.BransAd = Dogrulama.Zorunlu(brans.BransAd, "Branş adı", 30);

            bool ayniIsimVar = db.Branslar.Any(b => b.BransAd == brans.BransAd && b.BransId != brans.BransId);
            if (ayniIsimVar)
                throw new KuralHatasi($"'{brans.BransAd}' isimli bir branş zaten var.");
        }
    }
}
