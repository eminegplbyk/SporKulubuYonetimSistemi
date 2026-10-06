using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;

namespace SporKulubuYS_UI
{
    public partial class AntrenorIslem : Form
    {
        private SporKulubuDB db = null!;
        private IAntrenorService antrenorService = null!;
        private int seciliAntrenorId;

        public AntrenorIslem()
        {
            InitializeComponent();
            FormClosed += (_, _) => db?.Dispose();
        }

        private void AntrenorIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            antrenorService = new AntrenorService(db);

            dtpDogumTarihi.MaxDate = DateTime.Today;
            UiYardimci.TabloAyarla(dgvAntrenorler);

            Temizle();
            Listele();
        }

        private void Listele()
        {
            UiYardimci.Calistir(() =>
            {
                var liste = antrenorService.Listele(txtAra.Text)
                    .Select(a => new
                    {
                        Id = a.AntrenorId,
                        Ad = a.AntrenorAd,
                        Soyad = a.AntrenorSoyad,
                        Uzmanlik = a.Uzmanlık,
                        DogumTarihi = a.AntrenorDogumTarihi.ToString("dd.MM.yyyy"),
                        Ulke = a.Ulke,
                        Branslar = string.Join(", ", a.BransAntrenorler.Select(ba => ba.Brans.BransAd))
                    });

                UiYardimci.Bagla(dgvAntrenorler, liste);
                dgvAntrenorler.Columns["Uzmanlik"]!.HeaderText = "Uzmanlık";
                dgvAntrenorler.Columns["DogumTarihi"]!.HeaderText = "Doğum Tarihi";
                dgvAntrenorler.Columns["Ulke"]!.HeaderText = "Ülke";
                dgvAntrenorler.Columns["Branslar"]!.HeaderText = "Branşlar";
                lblKayitSayisi.Text = $"Kayıt sayısı: {dgvAntrenorler.Rows.Count}";
            });
        }

        private Antrenor FormdanOku()
        {
            return new Antrenor
            {
                AntrenorId = seciliAntrenorId,
                AntrenorAd = txtAd.Text,
                AntrenorSoyad = txtSoyad.Text,
                Uzmanlık = txtUzmanlik.Text,
                AntrenorDogumTarihi = dtpDogumTarihi.Value.Date,
                Ulke = txtUlke.Text
            };
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                Antrenor antrenor = FormdanOku();
                antrenor.AntrenorId = 0;
                antrenorService.Ekle(antrenor);
            }, "Antrenör eklendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool basarili = UiYardimci.Calistir(() =>
            {
                if (seciliAntrenorId == 0)
                    throw new KuralHatasi("Lütfen listeden bir antrenör seçiniz.");
                antrenorService.Guncelle(FormdanOku());
            }, "Antrenör güncellendi.");

            if (basarili) { Temizle(); Listele(); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliAntrenorId == 0)
            {
                UiYardimci.Uyari("Lütfen listeden bir antrenör seçiniz.");
                return;
            }

            if (!UiYardimci.Onayla($"{txtAd.Text} {txtSoyad.Text} silinsin mi?\n\nAntrenörün branş atamaları da silinecek."))
                return;

            bool basarili = UiYardimci.Calistir(() => antrenorService.Sil(seciliAntrenorId), "Antrenör silindi.");
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

        private void dgvAntrenorler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = UiYardimci.SeciliId(dgvAntrenorler, e.RowIndex);
            if (id == 0) return;

            Antrenor? antrenor = antrenorService.Getir(id);
            if (antrenor == null) return;

            seciliAntrenorId = antrenor.AntrenorId;
            txtAd.Text = antrenor.AntrenorAd;
            txtSoyad.Text = antrenor.AntrenorSoyad;
            txtUzmanlik.Text = antrenor.Uzmanlık;
            dtpDogumTarihi.Value = antrenor.AntrenorDogumTarihi;
            txtUlke.Text = antrenor.Ulke;
        }

        private void Temizle()
        {
            seciliAntrenorId = 0;
            txtAd.Clear();
            txtSoyad.Clear();
            txtUzmanlik.Clear();
            txtUlke.Clear();
            dtpDogumTarihi.Value = DateTime.Today.AddYears(-30);
            dgvAntrenorler.ClearSelection();
            txtAd.Focus();
        }
    }
}
