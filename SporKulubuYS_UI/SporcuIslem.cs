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

namespace SporKulubuYS_UI
{
    public partial class SporcuIslem : Form
    {
        SporKulubuDB db;
        SporcuService sporcuService;
        public SporcuIslem()
        {
            InitializeComponent();
        }

        private void SporcuIslem_Load(object sender, EventArgs e)
        {
            db = new SporKulubuDB();
            sporcuService = new SporcuService(db);
            Yenile();
        }

        public void Yenile()
        {
            var sporcular = sporcuService.Listele();
            dataGridView1.DataSource = sporcular;
            Temizle();
        }

        public void Temizle()
        {
            textBox_sporcuID.Text = "";
            textBox_sporcuAD.Text = "";
            textBox_sporcuSOYAD.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePickerSporcu.Value = DateTime.Now;
            textBox_sporcuEPOSTA.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked cell is a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox_sporcuID.Text = row.Cells[0].Value.ToString();
                textBox_sporcuAD.Text = row.Cells[1].Value.ToString();
                textBox_sporcuSOYAD.Text = row.Cells[2].Value.ToString();
                dateTimePickerSporcu.Value = Convert.ToDateTime(row.Cells[3].Value);
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    comboBox1.SelectedIndex = 1;
                }

                textBox_sporcuEPOSTA.Text = row.Cells[5].Value.ToString();
            }
        }



        private void button_ekleSporcu_Click(object sender, EventArgs e)
        {

            Sporcu sporcu = new Sporcu();
            sporcu.SporcuAd = textBox_sporcuAD.Text; ;
            sporcu.SporcuSoyad = textBox_sporcuSOYAD.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                sporcu.Cinsiyet = true;
            }
            else
            {
                sporcu.Cinsiyet = false;
            }
            sporcu.SporcuDogumTarihi = dateTimePickerSporcu.Value;
            sporcu.Eposta = textBox_sporcuEPOSTA.Text;

            sporcuService.Ekle(sporcu);
            Yenile();

        }

        private void button_silSporcu_Click(object sender, EventArgs e)
        {
            int SporcuId = Convert.ToInt32(textBox_sporcuID.Text);
            sporcuService.Sil(SporcuId);
            Yenile();
        }

        private void button_guncelleSporcu_Click(object sender, EventArgs e)
        {
            Sporcu sporcu = new Sporcu();
            int SporcuId = Convert.ToInt32(textBox_sporcuID.Text);
            sporcu.SporcuId = SporcuId;
            sporcu.SporcuAd = textBox_sporcuAD.Text; ;
            sporcu.SporcuSoyad = textBox_sporcuSOYAD.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                sporcu.Cinsiyet = true;
            }
            else
            {
                sporcu.Cinsiyet = false;
            }
            sporcu.SporcuDogumTarihi = dateTimePickerSporcu.Value;
            sporcu.Eposta = textBox_sporcuEPOSTA.Text;

           sporcuService.Güncelle(sporcu);
            Yenile();

        }

        private void button_listeleSporcu_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
