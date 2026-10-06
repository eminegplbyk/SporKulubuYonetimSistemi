using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    public interface IAntrenorService
    {
        void Ekle(Antrenor antrenor);
        void Sil(int antrenorId);
        void Guncelle(Antrenor antrenor);
        Antrenor? Getir(int antrenorId);
        List<Antrenor> Listele(string? arama = null);
    }

    public class AntrenorService : IAntrenorService
    {
        protected SporKulubuDB db;

        public AntrenorService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Antrenor antrenor)
        {
            Dogrula(antrenor);

            db.Antrenorler.Add(antrenor);
            db.SaveChanges();
        }

        /// <summary>Antrenör silinince branş atamaları da (BransAntrenorler) veritabanı tarafından silinir.</summary>
        public void Sil(int antrenorId)
        {
            Dogrulama.Secili(antrenorId, "listeden bir antrenör");

            var antrenor = db.Antrenorler.Find(antrenorId)
                           ?? throw new KuralHatasi("Antrenör bulunamadı.");

            db.Antrenorler.Remove(antrenor);
            db.SaveChanges();
        }

        public void Guncelle(Antrenor antrenor)
        {
            Dogrulama.Secili(antrenor.AntrenorId, "listeden bir antrenör");
            Dogrula(antrenor);

            var eskiKayit = db.Antrenorler.Find(antrenor.AntrenorId)
                            ?? throw new KuralHatasi("Antrenör bulunamadı.");

            eskiKayit.AntrenorAd = antrenor.AntrenorAd;
            eskiKayit.AntrenorSoyad = antrenor.AntrenorSoyad;
            eskiKayit.Uzmanlık = antrenor.Uzmanlık;
            eskiKayit.AntrenorDogumTarihi = antrenor.AntrenorDogumTarihi;
            eskiKayit.Ulke = antrenor.Ulke;

            db.SaveChanges();
        }

        public Antrenor? Getir(int antrenorId)
        {
            return db.Antrenorler.Find(antrenorId);
        }

        public List<Antrenor> Listele(string? arama = null)
        {
            IQueryable<Antrenor> sorgu = db.Antrenorler
                .Include(a => a.BransAntrenorler)
                .ThenInclude(ba => ba.Brans);

            if (!string.IsNullOrWhiteSpace(arama))
            {
                string kelime = arama.Trim();
                sorgu = sorgu.Where(a => a.AntrenorAd.Contains(kelime)
                                      || a.AntrenorSoyad.Contains(kelime)
                                      || a.Uzmanlık.Contains(kelime));
            }

            return sorgu.OrderBy(a => a.AntrenorAd).ThenBy(a => a.AntrenorSoyad).ToList();
        }

        private static void Dogrula(Antrenor antrenor)
        {
            antrenor.AntrenorAd = Dogrulama.Isim(antrenor.AntrenorAd, "Ad");
            antrenor.AntrenorSoyad = Dogrulama.Isim(antrenor.AntrenorSoyad, "Soyad");
            antrenor.Uzmanlık = Dogrulama.Zorunlu(antrenor.Uzmanlık, "Uzmanlık", 30);
            antrenor.Ulke = Dogrulama.Zorunlu(antrenor.Ulke, "Ülke", 20);
            Dogrulama.DogumTarihi(antrenor.AntrenorDogumTarihi, 18, 80);
        }
    }
}
