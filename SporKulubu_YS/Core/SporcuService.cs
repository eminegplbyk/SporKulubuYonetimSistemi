using Microsoft.EntityFrameworkCore;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_Service.Core
{
    public interface ISporcuService
    {
        void Ekle(Sporcu sporcu);
        void Sil(int sporcuId);
        void Guncelle(Sporcu sporcu);
        Sporcu? Getir(int sporcuId);
        List<Sporcu> Listele(string? arama = null);
    }

    public class SporcuService : ISporcuService
    {
        protected SporKulubuDB db;

        public SporcuService(SporKulubuDB database)
        {
            db = database;
        }

        public void Ekle(Sporcu sporcu)
        {
            Dogrula(sporcu);

            db.Sporcular.Add(sporcu);
            db.SaveChanges();
        }

        /// <summary>Sporcu silinince branş kayıtları da (SporcuBranslar) veritabanı tarafından silinir.</summary>
        public void Sil(int sporcuId)
        {
            Dogrulama.Secili(sporcuId, "listeden bir sporcu");

            var sporcu = db.Sporcular.Find(sporcuId)
                         ?? throw new KuralHatasi("Sporcu bulunamadı.");

            db.Sporcular.Remove(sporcu);
            db.SaveChanges();
        }

        public void Guncelle(Sporcu sporcu)
        {
            Dogrulama.Secili(sporcu.SporcuId, "listeden bir sporcu");
            Dogrula(sporcu);

            var eskiKayit = db.Sporcular.Find(sporcu.SporcuId)
                            ?? throw new KuralHatasi("Sporcu bulunamadı.");

            eskiKayit.SporcuAd = sporcu.SporcuAd;
            eskiKayit.SporcuSoyad = sporcu.SporcuSoyad;
            eskiKayit.SporcuDogumTarihi = sporcu.SporcuDogumTarihi;
            eskiKayit.Cinsiyet = sporcu.Cinsiyet;
            eskiKayit.Eposta = sporcu.Eposta;

            db.SaveChanges();
        }

        public Sporcu? Getir(int sporcuId)
        {
            return db.Sporcular.Find(sporcuId);
        }

        /// <summary>Sporcuları branşlarıyla birlikte getirir; arama ad, soyad ve e-postada yapılır.</summary>
        public List<Sporcu> Listele(string? arama = null)
        {
            IQueryable<Sporcu> sorgu = db.Sporcular
                .Include(s => s.SporcuBranslar)
                .ThenInclude(sb => sb.Brans);

            if (!string.IsNullOrWhiteSpace(arama))
            {
                string kelime = arama.Trim();
                sorgu = sorgu.Where(s => s.SporcuAd.Contains(kelime)
                                      || s.SporcuSoyad.Contains(kelime)
                                      || s.Eposta.Contains(kelime));
            }

            return sorgu.OrderBy(s => s.SporcuAd).ThenBy(s => s.SporcuSoyad).ToList();
        }

        private void Dogrula(Sporcu sporcu)
        {
            sporcu.SporcuAd = Dogrulama.Isim(sporcu.SporcuAd, "Ad");
            sporcu.SporcuSoyad = Dogrulama.Isim(sporcu.SporcuSoyad, "Soyad");
            sporcu.Eposta = Dogrulama.Eposta(sporcu.Eposta);
            Dogrulama.DogumTarihi(sporcu.SporcuDogumTarihi, 5, 80);

            bool epostaKullaniliyor = db.Sporcular.Any(s => s.Eposta == sporcu.Eposta && s.SporcuId != sporcu.SporcuId);
            if (epostaKullaniliyor)
                throw new KuralHatasi("Bu e-posta adresiyle kayıtlı başka bir sporcu var.");
        }
    }
}
