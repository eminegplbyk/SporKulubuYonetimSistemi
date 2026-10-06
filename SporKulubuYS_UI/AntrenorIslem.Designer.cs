namespace SporKulubuYS_UI
{
    partial class AntrenorIslem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBaslik = new Label();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtUzmanlik = new TextBox();
            label4 = new Label();
            dtpDogumTarihi = new DateTimePicker();
            label5 = new Label();
            txtUlke = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblAra = new Label();
            txtAra = new TextBox();
            lblKayitSayisi = new Label();
            dgvAntrenorler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAntrenorler).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Antrenör İşlemleri";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Ad:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 10F);
            txtAd.MaxLength = 50;
            txtAd.Location = new Point(150, 60);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(240, 25);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Text = "Soyad:";
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 10F);
            txtSoyad.MaxLength = 50;
            txtSoyad.Location = new Point(150, 102);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(240, 25);
            txtSoyad.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Text = "Uzmanlık:";
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.TabIndex = 5;
            // 
            // txtUzmanlik
            // 
            txtUzmanlik.Font = new Font("Segoe UI", 10F);
            txtUzmanlik.MaxLength = 30;
            txtUzmanlik.Location = new Point(150, 144);
            txtUzmanlik.Name = "txtUzmanlik";
            txtUzmanlik.Size = new Size(240, 25);
            txtUzmanlik.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Text = "Doğum Tarihi:";
            label4.Location = new Point(20, 189);
            label4.Name = "label4";
            label4.TabIndex = 7;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10F);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(150, 186);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(240, 25);
            dtpDogumTarihi.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Text = "Ülke:";
            label5.Location = new Point(20, 231);
            label5.Name = "label5";
            label5.TabIndex = 9;
            // 
            // txtUlke
            // 
            txtUlke.Font = new Font("Segoe UI", 10F);
            txtUlke.MaxLength = 20;
            txtUlke.Location = new Point(150, 228);
            txtUlke.Name = "txtUlke";
            txtUlke.Size = new Size(240, 25);
            txtUlke.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Location = new Point(20, 285);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(180, 40);
            btnEkle.TabIndex = 11;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DarkKhaki;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Location = new Point(210, 285);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(180, 40);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkKhaki;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Location = new Point(20, 333);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 40);
            btnSil.TabIndex = 13;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.DarkKhaki;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Location = new Point(210, 333);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 40);
            btnTemizle.TabIndex = 14;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAra.Text = "Ara:";
            lblAra.Location = new Point(420, 63);
            lblAra.Name = "lblAra";
            lblAra.TabIndex = 15;
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 10F);
            txtAra.PlaceholderText = "Aramak için yazın...";
            txtAra.Location = new Point(465, 60);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(260, 25);
            txtAra.TabIndex = 16;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // lblKayitSayisi
            // 
            lblKayitSayisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKayitSayisi.AutoSize = true;
            lblKayitSayisi.ForeColor = SystemColors.GrayText;
            lblKayitSayisi.Text = "";
            lblKayitSayisi.Location = new Point(420, 538);
            lblKayitSayisi.Name = "lblKayitSayisi";
            lblKayitSayisi.TabIndex = 17;
            // 
            // dgvAntrenorler
            // 
            dgvAntrenorler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAntrenorler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAntrenorler.Location = new Point(420, 100);
            dgvAntrenorler.Name = "dgvAntrenorler";
            dgvAntrenorler.Size = new Size(640, 432);
            dgvAntrenorler.TabIndex = 18;
            dgvAntrenorler.CellClick += dgvAntrenorler_CellClick;
            // 
            // AntrenorIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvAntrenorler);
            Controls.Add(lblKayitSayisi);
            Controls.Add(txtAra);
            Controls.Add(lblAra);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtUlke);
            Controls.Add(label5);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(label4);
            Controls.Add(txtUzmanlik);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "AntrenorIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antrenör İşlemleri";
            Load += AntrenorIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAntrenorler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtUzmanlik;
        private Label label4;
        private DateTimePicker dtpDogumTarihi;
        private Label label5;
        private TextBox txtUlke;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblAra;
        private TextBox txtAra;
        private Label lblKayitSayisi;
        private DataGridView dgvAntrenorler;
    }
}
