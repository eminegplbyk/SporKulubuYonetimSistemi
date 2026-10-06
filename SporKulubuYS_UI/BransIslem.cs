using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    public partial class BransIslem : Form
    {
        private SporKulubuDB db = null!;
        private IBransService bransService = null!;
        private int seciliBransId;

        public BransIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void BransIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            bransService = new BransService(db);

            UiYardimci.TabloAyarla(dgvBranslar);
            Temizle();
            Listele();
        }

        private void Listele()
        {
            UiYardimci.Calistir(() =>
            {
                var liste = bransService.Listele()
                    .Select(b => new
                    {
                        Id = b.BransId,
                        Brans = b.BransAd,
                        Sporcu = b.SporcuBranslar.Count,
                        Antrenor = b.BransAntrenorler.Count,
                        Salon = b.Salonlar.Count,
                        Etkinlik = b.Etkinlikler.Count
                    });

                UiYardimci.Bagla(dgvBranslar, liste);
                dgvBranslar.Columns["Brans"]!.HeaderText = "Branş";
                dgvBranslar.Columns["Sporcu"]!.HeaderText = "Sporcu Sayısı";
                dgvBranslar.Columns["Antrenor"]!.HeaderText = "Antrenör Sayısı";
                dgvBranslar.Columns["Salon"]!.HeaderText = "Salon Sayısı";
                dgvBranslar.Columns["Etkinlik"]!.HeaderText = "Etkinlik Sayısı";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvBranslar.Rows.Count}";
            });
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(
                () => bransService.Ekle(new Brans { BransAd = txtBransAd.Text }),
                "Branş eklendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(
                () => bransService.Guncelle(new Brans { BransId = seciliBransId, BransAd = txtBransAd.Text }),
                "Branş güncellendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliBransId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir branş seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla($"'{txtBransAd.Text}' branşı silinsin mi?"))
                return;

            bool basarili = UiYardimci.Calistir(() => bransService.Sil(seciliBransId), "Branş silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvBranslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = UiYardimci.SeciliId(dgvBranslar, e.RowIndex);
            if (id == 0) return;

            Brans? brans = bransService.Getir(id);
            if (brans == null) return;

            seciliBransId = brans.BransId;
            txtBransAd.Text = brans.BransAd;
        }

        private void Temizle()
        {
            seciliBransId = 0;
            txtBransAd.Clear();
            dgvBranslar.ClearSelection();
            txtBransAd.Focus();
        }
    }
}
