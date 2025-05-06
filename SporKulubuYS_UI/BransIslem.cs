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
    public partial class BransIslem : Form
    {
        SporKulubuDB db;
        BransService bransService;

        public BransIslem()
        {
            InitializeComponent();
        }

        private void BransIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            bransService = new BransService(db);
            Yenile();
        }

        public void Yenile()
        {
            var branslar = bransService.Listele();
            dataGridView1.DataSource = branslar;
            Temizle();
        }

        public void Temizle()
        {
            textBox_bransID.Text = "";
            textBox_bransAD.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_bransID.Text = row.Cells[0].Value.ToString();
                textBox_bransAD.Text = row.Cells[1].Value.ToString();
            }
        }

        private void button_ekleBrans_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransAd = textBox_bransAD.Text;

            bransService.Ekle(brans);
            Yenile();
        }

        private void button_silBrans_Click(object sender, EventArgs e)
        {
            int BransId = Convert.ToInt32(textBox_bransID.Text);
            bransService.Sil(BransId);
            Yenile();
        }

        private void button_guncelleBrans_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransId = Convert.ToInt32(textBox_bransID.Text);
            brans.BransAd = textBox_bransAD.Text;

            bransService.Güncelle(brans);
            Yenile();
        }

        private void button_listeleBrans_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }

}
