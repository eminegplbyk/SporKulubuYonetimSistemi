using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    public interface ISalonService
    {
        void Ekle(Salon salon);
        void Sil(int salonId);
        void Guncelle(Salon salon);
        Salon? Getir(int salonId);
        List<Salon> Listele();
    }

    public class SalonService : ISalonService
    {
        public const int MaxKapasite = 10000;

        protected SporKulubuDB db;

        public SalonService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Salon salon)
        {
            Dogrula(salon);

            db.Salonlar.Add(salon);
            db.SaveChanges();
        }

        public void Sil(int salonId)
        {
            Dogrulama.Secili(salonId, "listeden bir salon");

            var salon = db.Salonlar.Find(salonId)
                        ?? throw new KuralHatasi("Salon bulunamadı.");

            db.Salonlar.Remove(salon);
            db.SaveChanges();
        }

        public void Guncelle(Salon salon)
        {
            Dogrulama.Secili(salon.SalonId, "listeden bir salon");
            Dogrula(salon);

            var eskiKayit = db.Salonlar.Find(salon.SalonId)
                            ?? throw new KuralHatasi("Salon bulunamadı.");

            eskiKayit.SalonAd = salon.SalonAd;
            eskiKayit.Kapasite = salon.Kapasite;
            eskiKayit.SalonYer = salon.SalonYer;
            eskiKayit.BransId = salon.BransId;

            db.SaveChanges();
        }

        public Salon? Getir(int salonId)
        {
            return db.Salonlar.Find(salonId);
        }

        public List<Salon> Listele()
        {
            return db.Salonlar
                .Include(s => s.Brans)
                .OrderBy(s => s.SalonAd)
                .ToList();
        }

        private void Dogrula(Salon salon)
        {
            salon.SalonAd = Dogrulama.Zorunlu(salon.SalonAd, "Salon adı", 50);
            salon.SalonYer = Dogrulama.Zorunlu(salon.SalonYer, "Salon yeri", 50);
            Dogrulama.Secili(salon.BransId, "bir branş");

            if (salon.Kapasite <= 0 || salon.Kapasite > MaxKapasite)
                throw new KuralHatasi($"Kapasite 1 ile {MaxKapasite} arasında olmalıdır.");

            if (!db.Branslar.Any(b => b.BransId == salon.BransId))
                throw new KuralHatasi("Seçilen branş bulunamadı.");
        }
    }
}
