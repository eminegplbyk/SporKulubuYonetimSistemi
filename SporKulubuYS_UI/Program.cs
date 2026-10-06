using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Beklenmeyen hatalarda program kapanmasın, kullanıcıya mesaj gösterilsin
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (_, e) => UiYardimci.HataGoster(e.Exception);

            if (!VeritabaniHazirla())
                return;

            Application.Run(new Form1());
        }

        /// <summary>
        /// Veritabanı yoksa oluşturur, eksik migration'ları uygular (EF Core Code-First).
        /// Böylece proje başka bir bilgisayarda ilk açılışta kendi veritabanını kurar.
        /// </summary>
        private static bool VeritabaniHazirla()
        {
            try
            {
                using SporKulubuDB db = new SporKulubuDB();
                VeritabaniKurulum.Hazirla(db);

                string? sorun = VeritabaniKurulum.AntrenorTablosunuKontrolEt(db);
                if (sorun != null)
                {
                    // Teşhis penceresi: Ctrl+C ile içeriği kopyalanabilir
                    MessageBox.Show(sorun, "Veritabanı Kontrolü (v2)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Veritabanına bağlanılamadı.\n\n" +
                    "SQL Server Express'in kurulu ve çalışır durumda olduğundan emin olun.\n" +
                    "Bağlantı ayarı: SporKulubu_YS > Model > SporKulubuDB.cs\n\n" +
                    "Hata: " + ex.Message,
                    "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
