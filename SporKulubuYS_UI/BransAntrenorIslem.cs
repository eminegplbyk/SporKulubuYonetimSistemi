using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    /// <summary>Antrenörleri branşlara atama ekranı (çoka-çok ilişki).</summary>
    public partial class BransAntrenorIslem : Form
    {
        private SporKulubuDB db = null!;
        private IBransAntrenorService bransAntrenorService = null!;
        private IAntrenorService antrenorService = null!;
        private IBransService bransService = null!;
        private int seciliAtamaId;

        public BransAntrenorIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void BransAntrenorIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            bransAntrenorService = new BransAntrenorService(db);
            antrenorService = new AntrenorService(db);
            bransService = new BransService(db);

            UiYardimci.TabloAyarla(dgvAtamalar);

            UiYardimci.Calistir(() =>
            {
                UiYardimci.ComboDoldur(cmbAntrenor, antrenorService.Listele()
                    .Select(a => new SecimOgesi(a.AntrenorId, $"{a.AntrenorAd} {a.AntrenorSoyad} ({a.Uzmanlık})")));
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
                var liste = bransAntrenorService.Listele()
                    .Select(ba => new
                    {
                        Id = ba.BransAntrenorId,
                        Brans = ba.Brans.BransAd,
                        Antrenor = $"{ba.Antrenor.AntrenorAd} {ba.Antrenor.AntrenorSoyad}",
                        Uzmanlik = ba.Antrenor.Uzmanlık
                    });

                UiYardimci.Bagla(dgvAtamalar, liste);
                dgvAtamalar.Columns["Brans"]!.HeaderText = "Branş";
                dgvAtamalar.Columns["Antrenor"]!.HeaderText = "Antrenör";
                dgvAtamalar.Columns["Uzmanlik"]!.HeaderText = "Uzmanlık";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvAtamalar.Rows.Count}";
            });
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
                bransAntrenorService.Ekle(new BransAntrenor
                {
                    AntrenorId = UiYardimci.ComboId(cmbAntrenor),
                    BransId = UiYardimci.ComboId(cmbBrans)
                }), "Antrenör branşa atandı.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliAtamaId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir atama seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla("Seçili atama silinsin mi?"))
                return;

            bool basarili = UiYardimci.Calistir(() => bransAntrenorService.Sil(seciliAtamaId), "Atama silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvAtamalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliAtamaId = UiYardimci.SeciliId(dgvAtamalar, e.RowIndex);
            if (seciliAtamaId == 0) return;

            var row = dgvAtamalar.Rows[e.RowIndex];
            lblBilgi.Text = $"Seçili: {row.Cells["Antrenor"].Value} → {row.Cells["Brans"].Value}";
        }

        private void Temizle()
        {
            seciliAtamaId = 0;
            cmbAntrenor.SelectedIndex = -1;
            cmbBrans.SelectedIndex = -1;
            lblBilgi.Text = "Antrenör ve branş seçip \"Branşa Ata\"ya basın. Silmek için listeden atama seçin.";
            dgvAtamalar.ClearSelection();
        }
    }
}
