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
    public partial class SalonIslem : Form
    {
        SporKulubuDB db;
        SalonService salonService;

        public SalonIslem()
        {
            InitializeComponent();
        }

        private void SalonIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            salonService = new SalonService(db);
            Yenile();
        }

        public void Yenile()
        {
            var salonlar = salonService.Listele();
            dataGridView1.DataSource = salonlar;
            Temizle();
        }

        public void Temizle()
        {
            textBox_salonID.Text = "";
            textBox_salonAD.Text = "";
            textBox1.Text = "";
            textBox_salonKAPASITE.Text = "";
            textBox_salonYER.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_salonID.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox_salonAD.Text = row.Cells[2].Value.ToString();
                textBox_salonYER.Text = row.Cells[3].Value.ToString();
                textBox_salonKAPASITE.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button_ekleSalon_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.SalonAd = textBox_salonAD.Text;
            salon.BransId = Convert.ToInt32(textBox1.Text);
            salon.Kapasite = Convert.ToInt32(textBox_salonKAPASITE.Text);
            salon.SalonYer = textBox_salonYER.Text;

            salonService.Ekle(salon);
            Yenile();
        }

        private void button_silSalon_Click(object sender, EventArgs e)
        {
            int SalonId = Convert.ToInt32(textBox_salonID.Text);
            salonService.Sil(SalonId);
            Yenile();
        }

        private void button_guncelleSalon_Click(object sender, EventArgs e)
        {
            Salon salon = new Salon();
            salon.SalonId = Convert.ToInt32(textBox_salonID.Text);
            salon.BransId = Convert.ToInt32(textBox1.Text);
            salon.SalonAd = textBox_salonAD.Text;
            salon.Kapasite = Convert.ToInt32(textBox_salonKAPASITE.Text);
            salon.SalonYer = textBox_salonYER.Text;

            salonService.Güncelle(salon);
            Yenile();
        }

        private void button_listeleSalon_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }

}
