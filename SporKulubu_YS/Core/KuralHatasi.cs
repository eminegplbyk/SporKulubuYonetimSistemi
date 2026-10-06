namespace SporKulubuYS_Service.Core
{
    /// <summary>
    /// İş kuralı veya doğrulama ihlalinde fırlatılır (ör. boş alan, aynı kaydın iki kez eklenmesi).
    /// Arayüz bu hatayı yakalayıp mesajı kullanıcıya uyarı olarak gösterir.
    /// </summary>
    public class KuralHatasi : Exception
    {
        public KuralHatasi(string mesaj) : base(mesaj)
        {
        }
    }
}
