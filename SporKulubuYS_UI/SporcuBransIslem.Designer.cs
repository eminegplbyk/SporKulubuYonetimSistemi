namespace SporKulubuYS_UI
{
    partial class SporcuBransIslem
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
            cmbSporcu = new ComboBox();
            label2 = new Label();
            cmbBrans = new ComboBox();
            lblBilgi = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblKayitSayisi = new Label();
            dgvKayitlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Sporcu – Branş Kayıtları";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Sporcu:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // cmbSporcu
            // 
            cmbSporcu.Font = new Font("Segoe UI", 10F);
            cmbSporcu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSporcu.FormattingEnabled = true;
            cmbSporcu.Location = new Point(150, 60);
            cmbSporcu.Name = "cmbSporcu";
            cmbSporcu.Size = new Size(240, 25);
            cmbSporcu.TabIndex = 2;
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
            // lblBilgi
            // 
            lblBilgi.ForeColor = SystemColors.GrayText;
            lblBilgi.Text = "Bir sporcu birden fazla branşa kaydedilebilir. Aynı kayıt iki kez eklenemez.";
            lblBilgi.Location = new Point(20, 146);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(370, 40);
            lblBilgi.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DarkKhaki;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Text = "BRANŞA KAYDET";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Location = new Point(20, 194);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(180, 40);
            btnEkle.TabIndex = 6;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DarkKhaki;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Text = "KAYDI SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Location = new Point(210, 194);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 40);
            btnSil.TabIndex = 7;
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
            btnTemizle.Location = new Point(20, 242);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(180, 40);
            btnTemizle.TabIndex = 8;
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
            lblKayitSayisi.TabIndex = 9;
            // 
            // dgvKayitlar
            // 
            dgvKayitlar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKayitlar.Location = new Point(420, 60);
            dgvKayitlar.Name = "dgvKayitlar";
            dgvKayitlar.Size = new Size(640, 472);
            dgvKayitlar.TabIndex = 10;
            dgvKayitlar.CellClick += dgvKayitlar_CellClick;
            // 
            // SporcuBransIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvKayitlar);
            Controls.Add(lblKayitSayisi);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lblBilgi);
            Controls.Add(cmbBrans);
            Controls.Add(label2);
            Controls.Add(cmbSporcu);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "SporcuBransIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sporcu – Branş Kayıtları";
            Load += SporcuBransIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKayitlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private ComboBox cmbSporcu;
        private Label label2;
        private ComboBox cmbBrans;
        private Label lblBilgi;
        private Button btnEkle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblKayitSayisi;
        private DataGridView dgvKayitlar;
    }
}
