namespace SporKulubuYS_UI
{
    partial class Form1
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
            lblAltBaslik = new Label();
            btnSporcular = new Button();
            btnAntrenorler = new Button();
            btnBranslar = new Button();
            btnSalonlar = new Button();
            btnEtkinlikler = new Button();
            btnSporcuBrans = new Button();
            btnBransAntrenor = new Button();
            lblKartSporcu = new Label();
            lblKartAntrenor = new Label();
            lblKartBrans = new Label();
            lblKartEtkinlik = new Label();
            lblYaklasan = new Label();
            dgvYaklasan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvYaklasan).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkOliveGreen;
            lblBaslik.Text = "Spor Kulübü Yönetim Sistemi";
            lblBaslik.Location = new Point(30, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.TabIndex = 0;
            // 
            // lblAltBaslik
            // 
            lblAltBaslik.AutoSize = true;
            lblAltBaslik.ForeColor = SystemColors.GrayText;
            lblAltBaslik.Text = "Sporcu, antrenör, branş, salon ve etkinlik yönetimi";
            lblAltBaslik.Location = new Point(33, 62);
            lblAltBaslik.Name = "lblAltBaslik";
            lblAltBaslik.TabIndex = 1;
            // 
            // btnSporcular
            // 
            btnSporcular.BackColor = Color.MediumAquamarine;
            btnSporcular.FlatStyle = FlatStyle.Flat;
            btnSporcular.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSporcular.ForeColor = Color.White;
            btnSporcular.Text = "SPORCULAR";
            btnSporcular.UseVisualStyleBackColor = false;
            btnSporcular.Location = new Point(30, 105);
            btnSporcular.Name = "btnSporcular";
            btnSporcular.Size = new Size(240, 52);
            btnSporcular.TabIndex = 2;
            btnSporcular.Click += btnSporcular_Click;
            // 
            // btnAntrenorler
            // 
            btnAntrenorler.BackColor = Color.MediumAquamarine;
            btnAntrenorler.FlatStyle = FlatStyle.Flat;
            btnAntrenorler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAntrenorler.ForeColor = Color.White;
            btnAntrenorler.Text = "ANTRENÖRLER";
            btnAntrenorler.UseVisualStyleBackColor = false;
            btnAntrenorler.Location = new Point(30, 167);
            btnAntrenorler.Name = "btnAntrenorler";
            btnAntrenorler.Size = new Size(240, 52);
            btnAntrenorler.TabIndex = 3;
            btnAntrenorler.Click += btnAntrenorler_Click;
            // 
            // btnBranslar
            // 
            btnBranslar.BackColor = Color.MediumAquamarine;
            btnBranslar.FlatStyle = FlatStyle.Flat;
            btnBranslar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBranslar.ForeColor = Color.White;
            btnBranslar.Text = "BRANŞLAR";
            btnBranslar.UseVisualStyleBackColor = false;
            btnBranslar.Location = new Point(30, 229);
            btnBranslar.Name = "btnBranslar";
            btnBranslar.Size = new Size(240, 52);
            btnBranslar.TabIndex = 4;
            btnBranslar.Click += btnBranslar_Click;
            // 
            // btnSalonlar
            // 
            btnSalonlar.BackColor = Color.MediumAquamarine;
            btnSalonlar.FlatStyle = FlatStyle.Flat;
            btnSalonlar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalonlar.ForeColor = Color.White;
            btnSalonlar.Text = "SALONLAR";
            btnSalonlar.UseVisualStyleBackColor = false;
            btnSalonlar.Location = new Point(30, 291);
            btnSalonlar.Name = "btnSalonlar";
            btnSalonlar.Size = new Size(240, 52);
            btnSalonlar.TabIndex = 5;
            btnSalonlar.Click += btnSalonlar_Click;
            // 
            // btnEtkinlikler
            // 
            btnEtkinlikler.BackColor = Color.MediumAquamarine;
            btnEtkinlikler.FlatStyle = FlatStyle.Flat;
            btnEtkinlikler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEtkinlikler.ForeColor = Color.White;
            btnEtkinlikler.Text = "ETKİNLİKLER";
            btnEtkinlikler.UseVisualStyleBackColor = false;
            btnEtkinlikler.Location = new Point(30, 353);
            btnEtkinlikler.Name = "btnEtkinlikler";
            btnEtkinlikler.Size = new Size(240, 52);
            btnEtkinlikler.TabIndex = 6;
            btnEtkinlikler.Click += btnEtkinlikler_Click;
            // 
            // btnSporcuBrans
            // 
            btnSporcuBrans.BackColor = Color.MediumAquamarine;
            btnSporcuBrans.FlatStyle = FlatStyle.Flat;
            btnSporcuBrans.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSporcuBrans.ForeColor = Color.White;
            btnSporcuBrans.Text = "SPORCU – BRANŞ";
            btnSporcuBrans.UseVisualStyleBackColor = false;
            btnSporcuBrans.Location = new Point(30, 415);
            btnSporcuBrans.Name = "btnSporcuBrans";
            btnSporcuBrans.Size = new Size(240, 52);
            btnSporcuBrans.TabIndex = 7;
            btnSporcuBrans.Click += btnSporcuBrans_Click;
            // 
            // btnBransAntrenor
            // 
            btnBransAntrenor.BackColor = Color.MediumAquamarine;
            btnBransAntrenor.FlatStyle = FlatStyle.Flat;
            btnBransAntrenor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBransAntrenor.ForeColor = Color.White;
            btnBransAntrenor.Text = "BRANŞ – ANTRENÖR";
            btnBransAntrenor.UseVisualStyleBackColor = false;
            btnBransAntrenor.Location = new Point(30, 477);
            btnBransAntrenor.Name = "btnBransAntrenor";
            btnBransAntrenor.Size = new Size(240, 52);
            btnBransAntrenor.TabIndex = 8;
            btnBransAntrenor.Click += btnBransAntrenor_Click;
            // 
            // lblKartSporcu
            // 
            lblKartSporcu.BackColor = Color.White;
            lblKartSporcu.BorderStyle = BorderStyle.FixedSingle;
            lblKartSporcu.Font = new Font("Segoe UI", 11F);
            lblKartSporcu.Text = "Sporcu\n-";
            lblKartSporcu.TextAlign = ContentAlignment.MiddleCenter;
            lblKartSporcu.Location = new Point(300, 105);
            lblKartSporcu.Name = "lblKartSporcu";
            lblKartSporcu.Size = new Size(155, 72);
            lblKartSporcu.TabIndex = 9;
            // 
            // lblKartAntrenor
            // 
            lblKartAntrenor.BackColor = Color.White;
            lblKartAntrenor.BorderStyle = BorderStyle.FixedSingle;
            lblKartAntrenor.Font = new Font("Segoe UI", 11F);
            lblKartAntrenor.Text = "Antrenör\n-";
            lblKartAntrenor.TextAlign = ContentAlignment.MiddleCenter;
            lblKartAntrenor.Location = new Point(470, 105);
            lblKartAntrenor.Name = "lblKartAntrenor";
            lblKartAntrenor.Size = new Size(155, 72);
            lblKartAntrenor.TabIndex = 10;
            // 
            // lblKartBrans
            // 
            lblKartBrans.BackColor = Color.White;
            lblKartBrans.BorderStyle = BorderStyle.FixedSingle;
            lblKartBrans.Font = new Font("Segoe UI", 11F);
            lblKartBrans.Text = "Branş\n-";
            lblKartBrans.TextAlign = ContentAlignment.MiddleCenter;
            lblKartBrans.Location = new Point(640, 105);
            lblKartBrans.Name = "lblKartBrans";
            lblKartBrans.Size = new Size(155, 72);
            lblKartBrans.TabIndex = 11;
            // 
            // lblKartEtkinlik
            // 
            lblKartEtkinlik.BackColor = Color.White;
            lblKartEtkinlik.BorderStyle = BorderStyle.FixedSingle;
            lblKartEtkinlik.Font = new Font("Segoe UI", 11F);
            lblKartEtkinlik.Text = "Yaklaşan Etkinlik\n-";
            lblKartEtkinlik.TextAlign = ContentAlignment.MiddleCenter;
            lblKartEtkinlik.Location = new Point(810, 105);
            lblKartEtkinlik.Name = "lblKartEtkinlik";
            lblKartEtkinlik.Size = new Size(155, 72);
            lblKartEtkinlik.TabIndex = 12;
            // 
            // lblYaklasan
            // 
            lblYaklasan.AutoSize = true;
            lblYaklasan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYaklasan.Text = "Yaklaşan Etkinlikler";
            lblYaklasan.Location = new Point(300, 200);
            lblYaklasan.Name = "lblYaklasan";
            lblYaklasan.TabIndex = 13;
            // 
            // dgvYaklasan
            // 
            dgvYaklasan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvYaklasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYaklasan.Location = new Point(300, 228);
            dgvYaklasan.Name = "dgvYaklasan";
            dgvYaklasan.Size = new Size(670, 347);
            dgvYaklasan.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1000, 600);
            Controls.Add(dgvYaklasan);
            Controls.Add(lblYaklasan);
            Controls.Add(lblKartEtkinlik);
            Controls.Add(lblKartBrans);
            Controls.Add(lblKartAntrenor);
            Controls.Add(lblKartSporcu);
            Controls.Add(btnBransAntrenor);
            Controls.Add(btnSporcuBrans);
            Controls.Add(btnEtkinlikler);
            Controls.Add(btnSalonlar);
            Controls.Add(btnBranslar);
            Controls.Add(btnAntrenorler);
            Controls.Add(btnSporcular);
            Controls.Add(lblAltBaslik);
            Controls.Add(lblBaslik);
            MinimumSize = new Size(1000, 620);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spor Kulübü Yönetim Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvYaklasan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAltBaslik;
        private Button btnSporcular;
        private Button btnAntrenorler;
        private Button btnBranslar;
        private Button btnSalonlar;
        private Button btnEtkinlikler;
        private Button btnSporcuBrans;
        private Button btnBransAntrenor;
        private Label lblKartSporcu;
        private Label lblKartAntrenor;
        private Label lblKartBrans;
        private Label lblKartEtkinlik;
        private Label lblYaklasan;
        private DataGridView dgvYaklasan;
    }
}
