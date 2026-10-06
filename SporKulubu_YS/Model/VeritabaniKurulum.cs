using Microsoft.EntityFrameworkCore;

namespace SporKulubuYS_Service.Model
{
    /// <summary>
    /// Uygulama açılışında veritabanını hazırlar:
    /// eksik migration'ları uygular ve eski sürümden kalan kolon adı sorunlarını onarır.
    /// </summary>
    public static class VeritabaniKurulum
    {
        public static void Hazirla(SporKulubuDB db)
        {
            db.Database.Migrate();
            UzmanlikKolonunuOnar(db);
        }

        /// <summary>
        /// Antrenorler tablosu EF'nin beklediği gibi sorgulanabiliyor mu diye dener.
        /// Sorun yoksa null, varsa teşhis bilgisini (sunucu, veritabanı, kolon adları) döner.
        /// </summary>
        public static string? AntrenorTablosunuKontrolEt(SporKulubuDB db)
        {
            try
            {
                _ = db.Antrenorler.Select(a => a.Uzmanlık).FirstOrDefault();
                return null;
            }
            catch (Exception ex)
            {
                var bilgi = new System.Text.StringBuilder();
                bilgi.AppendLine("Hata: " + ex.Message);
                bilgi.AppendLine("Koddaki kolon adı: " + KodNoktalari(nameof(Antrenor.Uzmanlık)));

                var baglanti = db.Database.GetDbConnection();
                bool acildi = baglanti.State != System.Data.ConnectionState.Open;
                if (acildi) baglanti.Open();
                try
                {
                    using var komut = baglanti.CreateCommand();
                    komut.CommandText =
                        "SELECT @@SERVERNAME, DB_NAME(), CONVERT(nvarchar(128), DATABASEPROPERTYEX(DB_NAME(), 'Collation'));";
                    using (var okuyucu = komut.ExecuteReader())
                    {
                        if (okuyucu.Read())
                            bilgi.AppendLine($"Sunucu: {okuyucu[0]} | Veritabanı: {okuyucu[1]} | Collation: {okuyucu[2]}");
                    }

                    komut.CommandText =
                        "SELECT s.name + '.' + t.name, c.name FROM sys.columns c " +
                        "JOIN sys.tables t ON t.object_id = c.object_id " +
                        "JOIN sys.schemas s ON s.schema_id = t.schema_id " +
                        "WHERE t.name LIKE 'Antrenor%' ORDER BY t.name, c.column_id;";
                    using (var okuyucu = komut.ExecuteReader())
                    {
                        while (okuyucu.Read())
                            bilgi.AppendLine($"{okuyucu.GetString(0)} -> {KodNoktalari(okuyucu.GetString(1))}");
                    }
                }
                finally
                {
                    if (acildi) baglanti.Close();
                }

                return bilgi.ToString();
            }
        }

        /// <summary>Metni harf harf Unicode kodlarıyla yazar (gizli/yanlış karakterleri görmek için).</summary>
        private static string KodNoktalari(string metin)
        {
            return metin + "  [" + string.Join(" ", metin.Select(c => ((int)c).ToString("X4"))) + "]";
        }

        /// <summary>
        /// Eski veritabanlarında Antrenorler tablosundaki "Uzmanlık" kolonu, Türkçe "ı" harfi
        /// yanlış karakter kodlamasıyla kaydedildiği için farklı bir isimle oluşmuş olabiliyor
        /// (ör. "UzmanlÄ±k" veya "Uzmanlik"). Bu durumda kolon doğru isme çevrilir, hiç yoksa eklenir.
        /// Kolon zaten doğruysa hiçbir şey yapılmaz.
        /// </summary>
        private static void UzmanlikKolonunuOnar(SporKulubuDB db)
        {
            // "ı" harfi NCHAR(305) ile yazıldı: kaynak dosyanın kodlamasından bağımsız çalışsın diye.
            const string sql = @"
DECLARE @dogruAd sysname = N'Uzmanl' + NCHAR(305) + N'k';
DECLARE @tablo int = OBJECT_ID(N'dbo.Antrenorler');

IF @tablo IS NOT NULL
   AND NOT EXISTS (SELECT 1 FROM sys.columns
                   WHERE object_id = @tablo AND name COLLATE Latin1_General_BIN2 = @dogruAd)
BEGIN
    DECLARE @eskiAd sysname =
        (SELECT TOP 1 name FROM sys.columns
         WHERE object_id = @tablo AND name LIKE N'Uzman%');

    IF @eskiAd IS NOT NULL
    BEGIN
        DECLARE @yol nvarchar(300) = N'dbo.Antrenorler.' + QUOTENAME(@eskiAd);
        EXEC sp_rename @yol, @dogruAd, N'COLUMN';
    END
    ELSE
    BEGIN
        DECLARE @ekle nvarchar(400) =
            N'ALTER TABLE dbo.Antrenorler ADD ' + QUOTENAME(@dogruAd) +
            N' nvarchar(30) NOT NULL CONSTRAINT DF_Antrenorler_Uzmanlik DEFAULT N''''';
        EXEC (@ekle);
    END
END";

            db.Database.ExecuteSqlRaw(sql);
        }
    }
}
