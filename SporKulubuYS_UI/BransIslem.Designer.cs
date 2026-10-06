namespace SporKulubuYS_UI
{
    partial class BransIslem
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
            txtBransAd = new TextBox();
            lblBilgi = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblKayitSayisi = new Label();
            dgvBranslar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Branş İşlemleri";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Branş Adı:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // txtBransAd
            // 
            txtBransAd.Font = new Font("Segoe UI", 10F);
            txtBransAd.MaxLength = 30;
            txtBransAd.Location = new Point(150, 60);
            txtBransAd.Name = "txtBransAd";
            txtBransAd.Size = new Size(240, 25);
            txtBransAd.TabIndex = 2;
            // 
            // lblBilgi
            // 
            lblBilgi.ForeColor = SystemColors.GrayText;
            lblBilgi.Text = "Bağlı sporcu, antrenör, salon veya etkinliği olan branş silinemez.";
            lblBilgi.Location = new Point(20, 104);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(370, 40);
            lblBilgi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Location = new Point(20, 152);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(180, 40);
            btnEkle.TabIndex = 4;
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
            btnGuncelle.Location = new Point(210, 152);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(180, 40);
            btnGuncelle.TabIndex = 5;
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
            btnSil.Location = new Point(20, 200);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 40);
            btnSil.TabIndex = 6;
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
            btnTemizle.Location = new Point(210, 200);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 40);
            btnTemizle.TabIndex = 7;
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
            lblKayitSayisi.TabIndex = 8;
            // 
            // dgvBranslar
            // 
            dgvBranslar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBranslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBranslar.Location = new Point(420, 60);
            dgvBranslar.Name = "dgvBranslar";
            dgvBranslar.Size = new Size(640, 472);
            dgvBranslar.TabIndex = 9;
            dgvBranslar.CellClick += dgvBranslar_CellClick;
            // 
            // BransIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvBranslar);
            Controls.Add(lblKayitSayisi);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lblBilgi);
            Controls.Add(txtBransAd);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "BransIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branş İşlemleri";
            Load += BransIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBranslar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private TextBox txtBransAd;
        private Label lblBilgi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblKayitSayisi;
        private DataGridView dgvBranslar;
    }
}
