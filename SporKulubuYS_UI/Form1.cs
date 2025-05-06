namespace SporKulubuYS_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Antrenor_Click(object sender, EventArgs e)
        {

            AntrenorIslem antrenorIslem = new AntrenorIslem();
            antrenorIslem.Show();

        }

        private void button_Brans_Click(object sender, EventArgs e)
        {
            BransIslem bransIslem = new BransIslem();
            bransIslem.Show();

        }

        private void button_Etkinlik_Click(object sender, EventArgs e)
        {
            EtkinlikIslem etkinlikIslem = new EtkinlikIslem();
            etkinlikIslem.Show();
        }

        private void button_Salon_Click(object sender, EventArgs e)
        {
            SalonIslem salonIslem = new SalonIslem();
            salonIslem.Show();
        }

        private void button_Sporcu_Click(object sender, EventArgs e)
        {
            SporcuIslem sporcuIslem = new SporcuIslem();
            sporcuIslem.Show();
        }

        private void button_SB_Click(object sender, EventArgs e)
        {
            SporcuBransIslem sporcuBrans = new SporcuBransIslem();
            sporcuBrans.Show();
        }

        private void button_BA_Click_1(object sender, EventArgs e)
        {
            BransAntrenorIslem bransAntrenor = new BransAntrenorIslem();
            bransAntrenor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
