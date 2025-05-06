using SporKulubuYS_Service.Core;
using SporKulubuYS_Service.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SporKulubuYS_UI
{
    public partial class AntrenorIslem : Form
    {
        SporKulubuDB db;
        AntrenorService antrenorService;

        public AntrenorIslem()
        {
            InitializeComponent();
        }

        private void AntrenorIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            antrenorService = new AntrenorService(db);
            Yenile();
        }

        public void Yenile()
        {
            var antrenorler = antrenorService.Listele();
            dataGridView1.DataSource = antrenorler;
            Temizle();
        }

        public void Temizle()
        {
            textBox_antrenorID.Text = "";
            textBox_antrenorAD.Text = "";
            textBox_antrenorSOYAD.Text = "";
            textBox_antrenorUZMANLIK.Text = "";
            dateTimePickerAntrenor.Value = DateTime.Now;
            textBox_antrenorULKE.Text = "";
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked cell is a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_antrenorID.Text = row.Cells[0].Value.ToString();
                textBox_antrenorAD.Text = row.Cells[1].Value.ToString();
                textBox_antrenorSOYAD.Text = row.Cells[2].Value.ToString();
                textBox_antrenorUZMANLIK.Text = row.Cells[3].Value.ToString();
                dateTimePickerAntrenor.Value = Convert.ToDateTime(row.Cells[4].Value);
                textBox_antrenorULKE.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_ekleAntrenor_Click(object sender, EventArgs e)
        {
            Antrenor antrenor = new Antrenor();
            antrenor.AntrenorAd = textBox_antrenorAD.Text;
            antrenor.AntrenorSoyad = textBox_antrenorSOYAD.Text;
            antrenor.Uzmanlık = textBox_antrenorUZMANLIK.Text;
            antrenor.AntrenorDogumTarihi = dateTimePickerAntrenor.Value;
            antrenor.Ulke = textBox_antrenorULKE.Text;

            antrenorService.Ekle(antrenor);
            Yenile();
        }

        private void button_silAntrenor_Click(object sender, EventArgs e)
        {
            int AntrenorId = Convert.ToInt32(textBox_antrenorID.Text);
            antrenorService.Sil(AntrenorId);
            Yenile();
        }

        private void button_guncelleAntrenor_Click(object sender, EventArgs e)
        {
            Antrenor antrenor = new Antrenor();
            antrenor.AntrenorId = Convert.ToInt32(textBox_antrenorID.Text);
            antrenor.AntrenorAd = textBox_antrenorAD.Text;
            antrenor.AntrenorSoyad = textBox_antrenorSOYAD.Text;
            antrenor.Uzmanlık = textBox_antrenorUZMANLIK.Text;
            antrenor.AntrenorDogumTarihi = dateTimePickerAntrenor.Value;
            antrenor.Ulke = textBox_antrenorULKE.Text;

            antrenorService.Güncelle(antrenor);
            Yenile();
        }

        private void button_listeleAntrenor_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }

}


