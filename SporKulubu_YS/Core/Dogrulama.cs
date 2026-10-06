using System.Net.Mail;

namespace SporKulubuYS_Service.Core
{
    /// <summary>
    /// Servislerde ortak kullanılan doğrulama kuralları.
    /// </summary>
    internal static class Dogrulama
    {
        /// <summary>Boş olamaz, en fazla maxUzunluk karakter. Baştaki/sondaki boşlukları temizleyip döner.</summary>
        public static string Zorunlu(string? deger, string alanAdi, int maxUzunluk)
        {
            string temiz = (deger ?? string.Empty).Trim();

            if (temiz.Length == 0)
                throw new KuralHatasi($"{alanAdi} boş bırakılamaz.");

            if (temiz.Length > maxUzunluk)
                throw new KuralHatasi($"{alanAdi} en fazla {maxUzunluk} karakter olabilir.");

            return temiz;
        }

        public static string Isim(string? deger, string alanAdi)
        {
            string temiz = Zorunlu(deger, alanAdi, 50);

            if (!temiz.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
                throw new KuralHatasi($"{alanAdi} sadece harf içermelidir.");

            return temiz;
        }

        public static string Eposta(string? deger)
        {
            string temiz = Zorunlu(deger, "E-posta", 50);

            try
            {
                MailAddress adres = new MailAddress(temiz);
                if (adres.Address != temiz || !adres.Host.Contains('.'))
                    throw new FormatException();
            }
            catch (FormatException)
            {
                throw new KuralHatasi("Geçerli bir e-posta adresi giriniz (ör. ad@ornek.com).");
            }

            return temiz;
        }

        public static void DogumTarihi(DateTime tarih, int minYas, int maxYas)
        {
            int yas = Yas(tarih);

            if (tarih.Date > DateTime.Today)
                throw new KuralHatasi("Doğum tarihi bugünden ileri olamaz.");

            if (yas < minYas || yas > maxYas)
                throw new KuralHatasi($"Yaş {minYas} ile {maxYas} arasında olmalıdır (girilen: {yas}).");
        }

        public static int Yas(DateTime dogumTarihi)
        {
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            if (dogumTarihi.Date > bugun.AddYears(-yas))
                yas--;
            return yas;
        }

        public static void Secili(int id, string neyi)
        {
            if (id <= 0)
                throw new KuralHatasi($"Lütfen {neyi} seçiniz.");
        }
    }
}
