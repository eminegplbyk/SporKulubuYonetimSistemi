namespace SporKulubuYS_UI
{
    partial class BransAntrenorIslem
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
            cmbAntrenor = new ComboBox();
            label2 = new Label();
            cmbBrans = new ComboBox();
            lblBilgi = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            lblKayitSayisi = new Label();
            dgvAtamalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAtamalar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Branş – Antrenör Atamaları";
            lblBaslik.Location = new Point(20, 15);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Text = "Antrenör:";
            label1.Location = new Point(20, 63);
            label1.Name = "label1";
            label1.TabIndex = 1;
            // 
            // cmbAntrenor
            // 
            cmbAntrenor.Font = new Font("Segoe UI", 10F);
            cmbAntrenor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAntrenor.FormattingEnabled = true;
            cmbAntrenor.Location = new Point(150, 60);
            cmbAntrenor.Name = "cmbAntrenor";
            cmbAntrenor.Size = new Size(240, 25);
            cmbAntrenor.TabIndex = 2;
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
            lblBilgi.Text = "Bir antrenör birden fazla branşta görev alabilir. Aynı atama iki kez yapılamaz.";
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
            btnEkle.Text = "BRANŞA ATA";
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
            btnSil.Text = "ATAMAYI SİL";
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
            // dgvAtamalar
            // 
            dgvAtamalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAtamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtamalar.Location = new Point(420, 60);
            dgvAtamalar.Name = "dgvAtamalar";
            dgvAtamalar.Size = new Size(640, 472);
            dgvAtamalar.TabIndex = 10;
            dgvAtamalar.CellClick += dgvAtamalar_CellClick;
            // 
            // BransAntrenorIslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1080, 560);
            Controls.Add(dgvAtamalar);
            Controls.Add(lblKayitSayisi);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lblBilgi);
            Controls.Add(cmbBrans);
            Controls.Add(label2);
            Controls.Add(cmbAntrenor);
            Controls.Add(label1);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(900, 480);
            Name = "BransAntrenorIslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Branş – Antrenör Atamaları";
            Load += BransAntrenorIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label label1;
        private ComboBox cmbAntrenor;
        private Label label2;
        private ComboBox cmbBrans;
        private Label lblBilgi;
        private Button btnEkle;
        private Button btnSil;
        private Button btnTemizle;
        private Label lblKayitSayisi;
        private DataGridView dgvAtamalar;
    }
}
