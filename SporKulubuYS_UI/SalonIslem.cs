using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    public partial class SalonIslem : Form
    {
        private SporKulubuDB db = null!;
        private ISalonService salonService = null!;
        private IBransService bransService = null!;
        private int seciliSalonId;

        public SalonIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void SalonIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            salonService = new SalonService(db);
            bransService = new BransService(db);

            nudKapasite.Maximum = SalonService.MaxKapasite;
            UiYardimci.TabloAyarla(dgvSalonlar);

            UiYardimci.Calistir(() =>
                UiYardimci.ComboDoldur(cmbBrans,
                    bransService.Listele().Select(b => new SecimOgesi(b.BransId, b.BransAd))));

            Temizle();
            Listele();
        }

        private void Listele()
        {
            UiYardimci.Calistir(() =>
            {
                var liste = salonService.Listele()
                    .Select(s => new
                    {
                        Id = s.SalonId,
                        Salon = s.SalonAd,
                        Brans = s.Brans.BransAd,
                        Kapasite = s.Kapasite,
                        Yer = s.SalonYer
                    });

                UiYardimci.Bagla(dgvSalonlar, liste);
                dgvSalonlar.Columns["Brans"]!.HeaderText = "Branş";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvSalonlar.Rows.Count}";
            });
        }

        private Salon FormdanOku()
        {
            return new Salon
            {
                SalonId = seciliSalonId,
                SalonAd = txtSalonAd.Text,
                BransId = UiYardimci.ComboId(cmbBrans),
                Kapasite = (int)nudKapasite.Value,
                SalonYer = txtYer.Text
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                Salon salon = FormdanOku();
                salon.SalonId = 0;
                salonService.Ekle(salon);
            }, "Salon eklendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                if (seciliSalonId == 0)
                    throw new KuralHatasi("Lütfen listeden bir salon seçiniz.");
                salonService.Guncelle(FormdanOku());
            }, "Salon güncellendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliSalonId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir salon seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla($"'{txtSalonAd.Text}' salonu silinsin mi?"))
                return;

            bool basarili = UiYardimci.Calistir(() => salonService.Sil(seciliSalonId), "Salon silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvSalonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = UiYardimci.SeciliId(dgvSalonlar, e.RowIndex);
            if (id == 0) return;

            Salon? salon = salonService.Getir(id);
            if (salon == null) return;

            seciliSalonId = salon.SalonId;
            txtSalonAd.Text = salon.SalonAd;
            cmbBrans.SelectedValue = salon.BransId;
            nudKapasite.Value = Math.Clamp(salon.Kapasite, (int)nudKapasite.Minimum, (int)nudKapasite.Maximum);
            txtYer.Text = salon.SalonYer;
        }

        private void Temizle()
        {
            seciliSalonId = 0;
            txtSalonAd.Clear();
            txtYer.Clear();
            cmbBrans.SelectedIndex = -1;
            nudKapasite.Value = 50;
            dgvSalonlar.ClearSelection();
            txtSalonAd.Focus();
        }
    }
}
