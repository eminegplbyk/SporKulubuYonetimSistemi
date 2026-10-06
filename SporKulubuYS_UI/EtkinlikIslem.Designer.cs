namespace SporKulubuYS_UI
{
    partial class EtkinlikIslem
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
            txtEtkinlikAd = new TextBox();
            label2 = new Label();
            cmbBrans = new ComboBox();
            label3 = new Label();
            txtYer = new TextBox();
            label4 = new Label();
            dtpTarih = new DateTimePicker();
            label5 = new Label();
            txtAciklama = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            chkYaklasan = new CheckBox();
            lblKayitSayisi = new Label();
            dgvEtkinlikler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEtkinlikler).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Etkinlik İşlemleri";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Etkinlik Adı:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // txtEtkinlikAd
            // 
            txtEtkinlikAd.Font = new Font("Segoe UI", 10F);
            txtEtkinlikAd.MaxLength = 50;
            txtEtkinlikAd.Location = new Point(150, 60);
            txtEtkinlikAd.Name = "txtEtkinlikAd";
            txtEtkinlikAd.Size = new Size(240, 25);
            txtEtkinlikAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Text = "Branş:";
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.TabIndex = 3;
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Segoe UI", 10F);
            cmbBrans.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(150, 102);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(240, 25);
            cmbBrans.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Text = "Yer:";
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.TabIndex = 5;
            // 
            // txtYer
            // 
            txtYer.Font = new Font("Segoe UI", 10F);
            txtYer.MaxLength = 50;
            txtYer.Location = new Point(150, 144);
            txtYer.Name = "txtYer";
            txtYer.Size = new Size(240, 25);
            txtYer.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Text = "Tarih / Saat:";
            label4.Location = new Point(20, 189);
            label4.Name = "label4";
            label4.TabIndex = 7;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 10F);
            dtpTarih.Format = DateTimePickerFormat.Custom;
            dtpTarih.CustomFormat = "dd.MM.yyyy  HH:mm";
            dtpTarih.Location = new Point(150, 186);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(240, 25);
            dtpTarih.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Text = "Açıklama:";
            label5.Location = new Point(20, 231);
            label5.Name = "label5";
            label5.TabIndex = 9;
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 10F);
            txtAciklama.MaxLength = 150;
            txtAciklama.Multiline = true;
            txtAciklama.ScrollBars = ScrollBars.Vertical;
            txtAciklama.Location = new Point(150, 228);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(240, 70);
            txtAciklama.TabIndex = 10;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Location = new Point(20, 313);
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
            btnGuncelle.Location = new Point(210, 313);
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
            btnSil.Location = new Point(20, 361);
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
            btnTemizle.Location = new Point(210, 361);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 40);
            btnTemizle.TabIndex = 14;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // chkYaklasan
            // 
            chkYaklasan.AutoSize = true;
            chkYaklasan.Font = new Font("Segoe UI", 10F);
            chkYaklasan.Text = "Sadece yaklaşan etkinlikleri göster";
            chkYaklasan.Location = new Point(420, 62);
            chkYaklasan.Name = "chkYaklasan";
            chkYaklasan.TabIndex = 15;
            chkYaklasan.CheckedChanged += chkYaklasan_CheckedChanged;
            // 
            // lblKayitSayisi
            // 
            lblKayitSayisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKayitSayisi.AutoSize = true;
            lblKayitSayisi.ForeColor = SystemColors.GrayText;
            lblKayitSayisi.Text = "";
            lblKayitSayisi.Location = new Point(420, 538);
            lblKayitSayisi.Name = "lblKayitSayisi";
            lblKayitSayisi.TabIndex = 16;
            // 
            // dgvEtkinlikler
            // 
            dgvEtkinlikler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEtkinlikler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtkinlikler.Location = new Point(420, 100);
            dgvEtkinlikler.Name = "dgvEtkinlikler";
            dgvEtkinlikler.Size = new Size(640, 432);
            dgvEtkinlikler.TabIndex = 17;
            dgvEtkinlikler.CellClick += dgvEtkinlikler_CellClick;
            // 
            // EtkinlikIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvEtkinlikler);
            Controls.Add(lblKayitSayisi);
            Controls.Add(chkYaklasan);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtAciklama);
            Controls.Add(label5);
            Controls.Add(dtpTarih);
            Controls.Add(label4);
            Controls.Add(txtYer);
            Controls.Add(label3);
            Controls.Add(cmbBrans);
            Controls.Add(label2);
            Controls.Add(txtEtkinlikAd);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "EtkinlikIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etkinlik İşlemleri";
            Load += EtkinlikIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEtkinlikler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private TextBox txtEtkinlikAd;
        private Label label2;
        private ComboBox cmbBrans;
        private Label label3;
        private TextBox txtYer;
        private Label label4;
        private DateTimePicker dtpTarih;
        private Label label5;
        private TextBox txtAciklama;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private CheckBox chkYaklasan;
        private Label lblKayitSayisi;
        private DataGridView dgvEtkinlikler;
    }
}
