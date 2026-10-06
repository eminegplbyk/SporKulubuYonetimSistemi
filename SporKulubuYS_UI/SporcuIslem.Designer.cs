namespace SporKulubuYS_UI
{
    partial class SporcuIslem
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
            dtpDogumTarihi = new DateTimePicker();
            label4 = new Label();
            cmbCinsiyet = new ComboBox();
            label5 = new Label();
            txtEposta = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblAra = new Label();
            txtAra = new TextBox();
            lblKayitSayisi = new Label();
            dgvSporcular = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSporcular).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Sporcu İşlemleri";
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
            label3.Text = "Doğum Tarihi:";
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.TabIndex = 5;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 10F);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            dtpDogumTarihi.Location = new Point(150, 144);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(240, 25);
            dtpDogumTarihi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Text = "Cinsiyet:";
            label4.Location = new Point(20, 189);
            label4.Name = "label4";
            label4.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.Font = new Font("Segoe UI", 10F);
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(150, 186);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(240, 25);
            cmbCinsiyet.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Text = "E-posta:";
            label5.Location = new Point(20, 231);
            label5.Name = "label5";
            label5.TabIndex = 9;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Segoe UI", 10F);
            txtEposta.MaxLength = 50;
            txtEposta.Location = new Point(150, 228);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(240, 25);
            txtEposta.TabIndex = 10;
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
            // dgvSporcular
            // 
            dgvSporcular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSporcular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSporcular.Location = new Point(420, 100);
            dgvSporcular.Name = "dgvSporcular";
            dgvSporcular.Size = new Size(640, 432);
            dgvSporcular.TabIndex = 18;
            dgvSporcular.CellClick += dgvSporcular_CellClick;
            // 
            // SporcuIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvSporcular);
            Controls.Add(lblKayitSayisi);
            Controls.Add(txtAra);
            Controls.Add(lblAra);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtEposta);
            Controls.Add(label5);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label4);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "SporcuIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sporcu İşlemleri";
            Load += SporcuIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSporcular).EndInit();
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
        private DateTimePicker dtpDogumTarihi;
        private Label label4;
        private ComboBox cmbCinsiyet;
        private Label label5;
        private TextBox txtEposta;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblAra;
        private TextBox txtAra;
        private Label lblKayitSayisi;
        private DataGridView dgvSporcular;
    }
}
