using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    public interface IEtkinlikService
    {
        void Ekle(Etkinlik etkinlik);
        void Sil(int etkinlikId);
        void Guncelle(Etkinlik etkinlik);
        Etkinlik? Getir(int etkinlikId);
        List<Etkinlik> Listele(bool sadeceYaklasanlar = false);
    }

    public class EtkinlikService : IEtkinlikService
    {
        protected SporKulubuDB db;

        public EtkinlikService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Etkinlik etkinlik)
        {
            Dogrula(etkinlik);

            if (etkinlik.EtkinlikTarih < DateTime.Now)
                throw new KuralHatasi("Yeni etkinlik geçmiş bir tarihe eklenemez.");

            db.Etkinlikler.Add(etkinlik);
            db.SaveChanges();
        }

        public void Sil(int etkinlikId)
        {
            Dogrulama.Secili(etkinlikId, "listeden bir etkinlik");

            var etkinlik = db.Etkinlikler.Find(etkinlikId)
                           ?? throw new KuralHatasi("Etkinlik bulunamadı.");

            db.Etkinlikler.Remove(etkinlik);
            db.SaveChanges();
        }

        public void Guncelle(Etkinlik etkinlik)
        {
            Dogrulama.Secili(etkinlik.EtkinlikId, "listeden bir etkinlik");
            Dogrula(etkinlik);

            var eskiKayit = db.Etkinlikler.Find(etkinlik.EtkinlikId)
                            ?? throw new KuralHatasi("Etkinlik bulunamadı.");

            eskiKayit.EtkinlikAd = etkinlik.EtkinlikAd;
            eskiKayit.EtkinlikYer = etkinlik.EtkinlikYer;
            eskiKayit.EtkinlikTarih = etkinlik.EtkinlikTarih;
            eskiKayit.EtkinlikAciklama = etkinlik.EtkinlikAciklama;
            eskiKayit.BransId = etkinlik.BransId;

            db.SaveChanges();
        }

        public Etkinlik? Getir(int etkinlikId)
        {
            return db.Etkinlikler.Find(etkinlikId);
        }

        /// <summary>Etkinlikleri tarihe göre sıralı getirir; istenirse sadece bugünden sonrakileri.</summary>
        public List<Etkinlik> Listele(bool sadeceYaklasanlar = false)
        {
            IQueryable<Etkinlik> sorgu = db.Etkinlikler.Include(e => e.Brans);

            if (sadeceYaklasanlar)
            {
                DateTime simdi = DateTime.Now;
                sorgu = sorgu.Where(e => e.EtkinlikTarih >= simdi);
            }

            return sorgu.OrderBy(e => e.EtkinlikTarih).ToList();
        }

        private void Dogrula(Etkinlik etkinlik)
        {
            etkinlik.EtkinlikAd = Dogrulama.Zorunlu(etkinlik.EtkinlikAd, "Etkinlik adı", 50);
            etkinlik.EtkinlikYer = Dogrulama.Zorunlu(etkinlik.EtkinlikYer, "Etkinlik yeri", 50);
            etkinlik.EtkinlikAciklama = Dogrulama.Zorunlu(etkinlik.EtkinlikAciklama, "Açıklama", 150);
            Dogrulama.Secili(etkinlik.BransId, "bir branş");

            if (!db.Branslar.Any(b => b.BransId == etkinlik.BransId))
                throw new KuralHatasi("Seçilen branş bulunamadı.");
        }
    }
}
