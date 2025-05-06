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
    public partial class SporcuBransIslem : Form
    {
        SporKulubuDB db;
        SporcuService sporcuService;
        BransService bransService;
        SporcuBransService sporcuBransService;
        public SporcuBransIslem()
        {
            InitializeComponent();
        }

        private void SporcuBransIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            sporcuService = new SporcuService(db);
            bransService = new BransService(db);
            sporcuBransService = new SporcuBransService(db);
        }

        public void Yenile()
        {
            dataGridView1.DataSource = sporcuService.Listele();
            dataGridView2.DataSource = bransService.Listele();
            dataGridView3.DataSource = sporcuBransService.Listele();
            Temizle();
        }

        public void Temizle()
        {
            textBox_SPORCU_ID.Text = "";
            textBox_BRANS2_ID.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_BRANS2_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_SPORCU_ID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_ekleBS_Click(object sender, EventArgs e)
        {
            SporcuBrans sporcuBrans = new SporcuBrans();
            sporcuBrans.BransId = Convert.ToInt32(textBox_BRANS2_ID.Text);
            sporcuBrans.SporcuId = Convert.ToInt32(textBox_SPORCU_ID.Text);
            sporcuBransService.Ekle(sporcuBrans);
        }

        private void button_listeleBS_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
