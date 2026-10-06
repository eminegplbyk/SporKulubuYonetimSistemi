using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    public partial class SporcuIslem : Form
    {
        private SporKulubuDB db = null!;
        private ISporcuService sporcuService = null!;
        private int seciliSporcuId;

        public SporcuIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void SporcuIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            sporcuService = new SporcuService(db);

            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            dtpDogumTarihi.MaxDate = DateTime.Today;
            UiYardimci.TabloAyarla(dgvSporcular);

            Temizle();
            Listele();
        }

        private void Listele()
        {
            UiYardimci.Calistir(() =>
            {
                var liste = sporcuService.Listele(txtAra.Text)
                    .Select(s => new
                    {
                        Id = s.SporcuId,
                        Ad = s.SporcuAd,
                        Soyad = s.SporcuSoyad,
                        DogumTarihi = s.SporcuDogumTarihi.ToString("dd.MM.yyyy"),
                        Yas = Yas(s.SporcuDogumTarihi),
                        Cinsiyet = s.Cinsiyet ? "Erkek" : "Kadın",
                        Eposta = s.Eposta,
                        Branslar = string.Join(", ", s.SporcuBranslar.Select(sb => sb.Brans.BransAd))
                    });

                UiYardimci.Bagla(dgvSporcular, liste);
                dgvSporcular.Columns["DogumTarihi"]!.HeaderText = "Doğum Tarihi";
                dgvSporcular.Columns["Yas"]!.HeaderText = "Yaş";
                dgvSporcular.Columns["Eposta"]!.HeaderText = "E-posta";
                dgvSporcular.Columns["Branslar"]!.HeaderText = "Branşlar";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvSporcular.Rows.Count}";
            });
        }

        private Sporcu FormdanOku()
        {
            if (cmbCinsiyet.SelectedIndex < 0)
                throw new KuralHatasi("Lütfen cinsiyet seçiniz.");

            return new Sporcu
            {
                SporcuId = seciliSporcuId,
                SporcuAd = txtAd.Text,
                SporcuSoyad = txtSoyad.Text,
                SporcuDogumTarihi = dtpDogumTarihi.Value.Date,
                Cinsiyet = cmbCinsiyet.SelectedIndex == 0, // 0 = Erkek
                Eposta = txtEposta.Text
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                Sporcu sporcu = FormdanOku();
                sporcu.SporcuId = 0;
                sporcuService.Ekle(sporcu);
            }, "Sporcu eklendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                if (seciliSporcuId == 0)
                    throw new KuralHatasi("Lütfen listeden bir sporcu seçiniz.");
                sporcuService.Guncelle(FormdanOku());
            }, "Sporcu güncellendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliSporcuId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir sporcu seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla($"{txtAd.Text} {txtSoyad.Text} silinsin mi?\n\nSporcunun branş kayıtları da silinecek."))
                return;

            bool basarili = UiYardimci.Calistir(() => sporcuService.Sil(seciliSporcuId), "Sporcu silindi.");
            if (basarili) { Temizle(); Listele(); }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvSporcular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = UiYardimci.SeciliId(dgvSporcular, e.RowIndex);
            if (id == 0) return;

            Sporcu? sporcu = sporcuService.Getir(id);
            if (sporcu == null) return;

            seciliSporcuId = sporcu.SporcuId;
            txtAd.Text = sporcu.SporcuAd;
            txtSoyad.Text = sporcu.SporcuSoyad;
            dtpDogumTarihi.Value = sporcu.SporcuDogumTarihi;
            cmbCinsiyet.SelectedIndex = sporcu.Cinsiyet ? 0 : 1;
            txtEposta.Text = sporcu.Eposta;
        }

        private void Temizle()
        {
            seciliSporcuId = 0;
            txtAd.Clear();
            txtSoyad.Clear();
            txtEposta.Clear();
            cmbCinsiyet.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Today.AddYears(-18);
            dgvSporcular.ClearSelection();
            txtAd.Focus();
        }

        private static int Yas(DateTime dogumTarihi)
        {
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;
            if (dogumTarihi.Date > bugun.AddYears(-yas)) yas--;
            return yas;
        }
    }
}
