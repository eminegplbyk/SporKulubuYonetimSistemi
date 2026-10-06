using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    /// <summary>Ana menü: modüllere geçiş, özet kartları ve yaklaşan etkinlikler.</summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UiYardimci.TabloAyarla(dgvYaklasan);
            OzetiYenile();
        }

        /// <summary>Kartlardaki sayıları ve yaklaşan etkinlik listesini veritabanından yeniden okur.</summary>
        private void OzetiYenile()
        {
            UiYardimci.Calistir(() =>
            {
                using var db = new SporKulubuDB();

                lblKartSporcu.Text = $"Sporcu\n{db.Sporcular.Count()}";
                lblKartAntrenor.Text = $"Antrenör\n{db.Antrenorler.Count()}";
                lblKartBrans.Text = $"Branş\n{db.Branslar.Count()}";

                var yaklasanlar = new EtkinlikService(db).Listele(sadeceYaklasanlar: true);
                lblKartEtkinlik.Text = $"Yaklaşan Etkinlik\n{yaklasanlar.Count}";

                var liste = yaklasanlar
                    .Take(10)
                    .Select(et => new
                    {
                        Id = et.EtkinlikId,
                        Tarih = et.EtkinlikTarih.ToString("dd.MM.yyyy HH:mm"),
                        Etkinlik = et.EtkinlikAd,
                        Brans = et.Brans.BransAd,
                        Yer = et.EtkinlikYer
                    });

                UiYardimci.Bagla(dgvYaklasan, liste);
                dgvYaklasan.Columns["Brans"]!.HeaderText = "Branş";
            });
        }

        /// <summary>Alt formu açar; kapandığında ana ekrandaki özetleri yeniler.</summary>
        private void Ac(Form form)
        {
            using (form)
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }

            OzetiYenile();
        }

        private void btnSporcular_Click(object sender, EventArgs e) => Ac(new SporcuIslem());

        private void btnAntrenorler_Click(object sender, EventArgs e) => Ac(new AntrenorIslem());

        private void btnBranslar_Click(object sender, EventArgs e) => Ac(new BransIslem());

        private void btnSalonlar_Click(object sender, EventArgs e) => Ac(new SalonIslem());

        private void btnEtkinlikler_Click(object sender, EventArgs e) => Ac(new EtkinlikIslem());

        private void btnSporcuBrans_Click(object sender, EventArgs e) => Ac(new SporcuBransIslem());

        private void btnBransAntrenor_Click(object sender, EventArgs e) => Ac(new BransAntrenorIslem());
    }
}
