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
    public partial class EtkinlikIslem : Form
    {
        SporKulubuDB db;
        EtkinlikService etkinlikService;
        public EtkinlikIslem()
        {
            InitializeComponent();
        }

        private void EtkinlikIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            etkinlikService = new EtkinlikService(db);
        }

        public void Yenile()
        {
            var etkinlikler = etkinlikService.Listele();
            dataGridView1.DataSource = etkinlikler;
            Temizle();
        }

        public void Temizle()
        {
            textBox_etkinlikID.Text = "";
            textBox_etkinlikAD.Text = "";
            textBox_etkinlikYER.Text = "";
            textBox1.Text = "";
            dateTimePickerEtkinlik.Value = DateTime.Now;
            textBox_etkinlikACIKLAMA.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked cell is a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_etkinlikID.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox_etkinlikAD.Text = row.Cells[2].Value.ToString();
                textBox_etkinlikYER.Text = row.Cells[3].Value.ToString();
                dateTimePickerEtkinlik.Value = Convert.ToDateTime(row.Cells[4].Value);
                textBox_etkinlikACIKLAMA.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_ekleEtkinlik_Click(object sender, EventArgs e)
        {
            Etkinlik etkinlik = new Etkinlik();
            etkinlik.EtkinlikAd = textBox_etkinlikAD.Text;
            etkinlik.BransId = Convert.ToInt32(textBox1.Text);
            etkinlik.EtkinlikYer = textBox_etkinlikYER.Text;
            etkinlik.EtkinlikTarih = dateTimePickerEtkinlik.Value;
            etkinlik.EtkinlikAciklama = textBox_etkinlikACIKLAMA.Text;

            etkinlikService.Ekle(etkinlik);
            Yenile();
        }

        private void button_silEtkinlik_Click(object sender, EventArgs e)
        {
            int EtkinlikId = Convert.ToInt32(textBox_etkinlikID.Text);
            etkinlikService.Sil(EtkinlikId);
            Yenile();
        }

        private void button_guncelleEtkinlik_Click(object sender, EventArgs e)
        {

            Etkinlik etkinlik = new Etkinlik();
            etkinlik.EtkinlikId = Convert.ToInt32(textBox_etkinlikID.Text);
            etkinlik.EtkinlikAd = textBox_etkinlikAD.Text;
            etkinlik.BransId = Convert.ToInt32(textBox1.Text);
            etkinlik.EtkinlikYer = textBox_etkinlikYER.Text;
            etkinlik.EtkinlikTarih = dateTimePickerEtkinlik.Value;
            etkinlik.EtkinlikAciklama = textBox_etkinlikACIKLAMA.Text;

            etkinlikService.Güncelle(etkinlik);
            Yenile();
        }

        private void button_listeleEtkinlik_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
