using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    /// <summary>Sporcuları branşlara kaydetme ekranı (çoka-çok ilişki).</summary>
    public partial class SporcuBransIslem : Form
    {
        private SporKulubuDB db = null!;
        private ISporcuBransService sporcuBransService = null!;
        private ISporcuService sporcuService = null!;
        private IBransService bransService = null!;
        private int seciliKayitId;

        public SporcuBransIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void SporcuBransIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            sporcuBransService = new SporcuBransService(db);
            sporcuService = new SporcuService(db);
            bransService = new BransService(db);

            UiYardimci.TabloAyarla(dgvKayitlar);

            UiYardimci.Calistir(() =>
            {
                UiYardimci.ComboDoldur(cmbSporcu, sporcuService.Listele()
                    .Select(s => new SecimOgesi(s.SporcuId, $"{s.SporcuAd} {s.SporcuSoyad}")));
                UiYardimci.ComboDoldur(cmbBrans, bransService.Listele()
                    .Select(b => new SecimOgesi(b.BransId, b.BransAd)));
            });

            Temizle();
            Listele();
        }

        private void Listele()
        {
            UiYardimci.Calistir(() =>
            {
                var liste = sporcuBransService.Listele()
                    .Select(sb => new
                    {
                        Id = sb.SporcuBransId,
                        Sporcu = $"{sb.Sporcu.SporcuAd} {sb.Sporcu.SporcuSoyad}",
                        Brans = sb.Brans.BransAd
                    });

                UiYardimci.Bagla(dgvKayitlar, liste);
                dgvKayitlar.Columns["Brans"]!.HeaderText = "Branş";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvKayitlar.Rows.Count}";
            });
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
                sporcuBransService.Ekle(new SporcuBrans
                {
                    SporcuId = UiYardimci.ComboId(cmbSporcu),
                    BransId = UiYardimci.ComboId(cmbBrans)
                }), "Sporcu branşa kaydedildi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKayitId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir kayıt seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla("Seçili sporcunun bu branştaki kaydı silinsin mi?"))
                return;

            bool basarili = UiYardimci.Calistir(() => sporcuBransService.Sil(seciliKayitId), "Kayıt silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliKayitId = UiYardimci.SeciliId(dgvKayitlar, e.RowIndex);
            if (seciliKayitId == 0) return;

            var row = dgvKayitlar.Rows[e.RowIndex];
            lblBilgi.Text = $"Seçili: {row.Cells["Sporcu"].Value} → {row.Cells["Brans"].Value}";
        }

        private void Temizle()
        {
            seciliKayitId = 0;
            cmbSporcu.SelectedIndex = -1;
            cmbBrans.SelectedIndex = -1;
            lblBilgi.Text = "Sporcu ve branş seçip \"Branşa Kaydet\"e basın. Silmek için listeden kayıt seçin.";
            dgvKayitlar.ClearSelection();
        }
    }
}
