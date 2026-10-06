namespace SporKulubuYS_UI
{
    partial class SalonIslem
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
            txtSalonAd = new TextBox();
            label2 = new Label();
            cmbBrans = new ComboBox();
            label3 = new Label();
            nudKapasite = new NumericUpDown();
            label4 = new Label();
            txtYer = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblKayitSayisi = new Label();
            dgvSalonlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudKapasite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalonlar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Salon İşlemleri";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Salon Adı:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // txtSalonAd
            // 
            txtSalonAd.Font = new Font("Segoe UI", 10F);
            txtSalonAd.MaxLength = 50;
            txtSalonAd.Location = new Point(150, 60);
            txtSalonAd.Name = "txtSalonAd";
            txtSalonAd.Size = new Size(240, 25);
            txtSalonAd.TabIndex = 2;
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
            label3.Text = "Kapasite:";
            label3.Location = new Point(20, 147);
            label3.Name = "label3";
            label3.TabIndex = 5;
            // 
            // nudKapasite
            // 
            nudKapasite.Font = new Font("Segoe UI", 10F);
            nudKapasite.Maximum = 10000;
            nudKapasite.Minimum = 1;
            nudKapasite.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudKapasite.Location = new Point(150, 144);
            nudKapasite.Name = "nudKapasite";
            nudKapasite.Size = new Size(120, 25);
            nudKapasite.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Text = "Yer:";
            label4.Location = new Point(20, 189);
            label4.Name = "label4";
            label4.TabIndex = 7;
            // 
            // txtYer
            // 
            txtYer.Font = new Font("Segoe UI", 10F);
            txtYer.MaxLength = 50;
            txtYer.Location = new Point(150, 186);
            txtYer.Name = "txtYer";
            txtYer.Size = new Size(240, 25);
            txtYer.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Location = new Point(20, 243);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(180, 40);
            btnEkle.TabIndex = 9;
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
            btnGuncelle.Location = new Point(210, 243);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(180, 40);
            btnGuncelle.TabIndex = 10;
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
            btnSil.Location = new Point(20, 291);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 40);
            btnSil.TabIndex = 11;
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
            btnTemizle.Location = new Point(210, 291);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 40);
            btnTemizle.TabIndex = 12;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lblKayitSayisi
            // 
            lblKayitSayisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblKayitSayisi.AutoSize = true;
            lblKayitSayisi.ForeColor = SystemColors.GrayText;
            lblKayitSayisi.Text = "";
            lblKayitSayisi.Location = new Point(420, 538);
            lblKayitSayisi.Name = "lblKayitSayisi";
            lblKayitSayisi.TabIndex = 13;
            // 
            // dgvSalonlar
            // 
            dgvSalonlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSalonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalonlar.Location = new Point(420, 60);
            dgvSalonlar.Name = "dgvSalonlar";
            dgvSalonlar.Size = new Size(640, 472);
            dgvSalonlar.TabIndex = 14;
            dgvSalonlar.CellClick += dgvSalonlar_CellClick;
            // 
            // SalonIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvSalonlar);
            Controls.Add(lblKayitSayisi);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtYer);
            Controls.Add(label4);
            Controls.Add(nudKapasite);
            Controls.Add(label3);
            Controls.Add(cmbBrans);
            Controls.Add(label2);
            Controls.Add(txtSalonAd);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "SalonIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salon İşlemleri";
            Load += SalonIslem_Load;
            ((System.ComponentModel.ISupportInitialize)nudKapasite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private TextBox txtSalonAd;
        private Label label2;
        private ComboBox cmbBrans;
        private Label label3;
        private NumericUpDown nudKapasite;
        private Label label4;
        private TextBox txtYer;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblKayitSayisi;
        private DataGridView dgvSalonlar;
    }
}
