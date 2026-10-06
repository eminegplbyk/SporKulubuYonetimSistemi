using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    public partial class EtkinlikIslem : Form
    {
        private SporKulubuDB db = null!;
        private IEtkinlikService etkinlikService = null!;
        private IBransService bransService = null!;
        private int seciliEtkinlikId;

        public EtkinlikIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void EtkinlikIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            etkinlikService = new EtkinlikService(db);
            bransService = new BransService(db);

            UiYardimci.TabloAyarla(dgvEtkinlikler);

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
                DateTime simdi = DateTime.Now;
                var liste = etkinlikService.Listele(chkYaklasan.Checked)
                    .Select(et => new
                    {
                        Id = et.EtkinlikId,
                        Etkinlik = et.EtkinlikAd,
                        Brans = et.Brans.BransAd,
                        Tarih = et.EtkinlikTarih.ToString("dd.MM.yyyy HH:mm"),
                        Yer = et.EtkinlikYer,
                        Aciklama = et.EtkinlikAciklama,
                        Durum = et.EtkinlikTarih >= simdi ? "Yaklaşan" : "Geçmiş"
                    });

                UiYardimci.Bagla(dgvEtkinlikler, liste);
                dgvEtkinlikler.Columns["Brans"]!.HeaderText = "Branş";
                dgvEtkinlikler.Columns["Aciklama"]!.HeaderText = "Açıklama";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvEtkinlikler.Rows.Count}";
            });
        }

        private Etkinlik FormdanOku()
        {
            return new Etkinlik
            {
                EtkinlikId = seciliEtkinlikId,
                EtkinlikAd = txtEtkinlikAd.Text,
                BransId = UiYardimci.ComboId(cmbBrans),
                EtkinlikYer = txtYer.Text,
                EtkinlikTarih = dtpTarih.Value,
                EtkinlikAciklama = txtAciklama.Text
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                Etkinlik etkinlik = FormdanOku();
                etkinlik.EtkinlikId = 0;
                etkinlikService.Ekle(etkinlik);
            }, "Etkinlik eklendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                if (seciliEtkinlikId == 0)
                    throw new KuralHatasi("Lütfen listeden bir etkinlik seçiniz.");
                etkinlikService.Guncelle(FormdanOku());
            }, "Etkinlik güncellendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliEtkinlikId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir etkinlik seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla($"'{txtEtkinlikAd.Text}' etkinliği silinsin mi?"))
                return;

            bool basarili = UiYardimci.Calistir(() => etkinlikService.Sil(seciliEtkinlikId), "Etkinlik silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void chkYaklasan_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvEtkinlikler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = UiYardimci.SeciliId(dgvEtkinlikler, e.RowIndex);
            if (id == 0) return;

            Etkinlik? etkinlik = etkinlikService.Getir(id);
            if (etkinlik == null) return;

            seciliEtkinlikId = etkinlik.EtkinlikId;
            txtEtkinlikAd.Text = etkinlik.EtkinlikAd;
            cmbBrans.SelectedValue = etkinlik.BransId;
            txtYer.Text = etkinlik.EtkinlikYer;
            dtpTarih.Value = etkinlik.EtkinlikTarih;
            txtAciklama.Text = etkinlik.EtkinlikAciklama;
        }

        private void Temizle()
        {
            seciliEtkinlikId = 0;
            txtEtkinlikAd.Clear();
            txtYer.Clear();
            txtAciklama.Clear();
            cmbBrans.SelectedIndex = -1;
            // Varsayılan: yarın saat 10:00
            dtpTarih.Value = DateTime.Today.AddDays(1).AddHours(10);
            dgvEtkinlikler.ClearSelection();
            txtEtkinlikAd.Focus();
        }
    }
}
