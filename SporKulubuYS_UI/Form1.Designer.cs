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
            button_Antrenor = new Button();
            button_Brans = new Button();
            button_Etkinlik = new Button();
            button_Salon = new Button();
            button_Sporcu = new Button();
            button_BA = new Button();
            button_SB = new Button();
            SuspendLayout();
            // 
            // button_Antrenor
            // 
            button_Antrenor.BackColor = Color.MediumAquamarine;
            button_Antrenor.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Antrenor.ForeColor = SystemColors.ActiveCaptionText;
            button_Antrenor.Location = new Point(236, 92);
            button_Antrenor.Name = "button_Antrenor";
            button_Antrenor.Size = new Size(170, 60);
            button_Antrenor.TabIndex = 0;
            button_Antrenor.Text = "ANTRENÖRLER";
            button_Antrenor.UseVisualStyleBackColor = false;
            button_Antrenor.Click += button_Antrenor_Click;
            // 
            // button_Brans
            // 
            button_Brans.BackColor = Color.MediumAquamarine;
            button_Brans.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Brans.ForeColor = SystemColors.ActiveCaptionText;
            button_Brans.Location = new Point(236, 205);
            button_Brans.Name = "button_Brans";
            button_Brans.Size = new Size(170, 60);
            button_Brans.TabIndex = 1;
            button_Brans.Text = "BRANŞLAR";
            button_Brans.UseVisualStyleBackColor = false;
            button_Brans.Click += button_Brans_Click;
            // 
            // button_Etkinlik
            // 
            button_Etkinlik.BackColor = Color.MediumAquamarine;
            button_Etkinlik.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Etkinlik.ForeColor = SystemColors.ActiveCaptionText;
            button_Etkinlik.Location = new Point(236, 322);
            button_Etkinlik.Name = "button_Etkinlik";
            button_Etkinlik.Size = new Size(170, 60);
            button_Etkinlik.TabIndex = 2;
            button_Etkinlik.Text = "ETKİNLİKLER";
            button_Etkinlik.UseVisualStyleBackColor = false;
            button_Etkinlik.Click += button_Etkinlik_Click;
            // 
            // button_Salon
            // 
            button_Salon.BackColor = Color.MediumAquamarine;
            button_Salon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Salon.ForeColor = SystemColors.ActiveCaptionText;
            button_Salon.Location = new Point(635, 92);
            button_Salon.Name = "button_Salon";
            button_Salon.Size = new Size(170, 60);
            button_Salon.TabIndex = 3;
            button_Salon.Text = "SALONLAR";
            button_Salon.UseVisualStyleBackColor = false;
            button_Salon.Click += button_Salon_Click;
            // 
            // button_Sporcu
            // 
            button_Sporcu.BackColor = Color.MediumAquamarine;
            button_Sporcu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_Sporcu.ForeColor = SystemColors.ActiveCaptionText;
            button_Sporcu.Location = new Point(635, 205);
            button_Sporcu.Name = "button_Sporcu";
            button_Sporcu.Size = new Size(170, 60);
            button_Sporcu.TabIndex = 4;
            button_Sporcu.Text = "SPORCULAR";
            button_Sporcu.UseVisualStyleBackColor = false;
            button_Sporcu.Click += button_Sporcu_Click;
            // 
            // button_BA
            // 
            button_BA.BackColor = Color.MediumAquamarine;
            button_BA.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_BA.Location = new Point(635, 322);
            button_BA.Name = "button_BA";
            button_BA.Size = new Size(170, 60);
            button_BA.TabIndex = 5;
            button_BA.Text = "BRANŞ ANTRENÖR";
            button_BA.UseVisualStyleBackColor = false;
            button_BA.Click += button_BA_Click_1;
            // 
            // button_SB
            // 
            button_SB.BackColor = Color.MediumAquamarine;
            button_SB.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_SB.Location = new Point(448, 453);
            button_SB.Name = "button_SB";
            button_SB.Size = new Size(170, 60);
            button_SB.TabIndex = 6;
            button_SB.Text = "SPORCU BRANŞ";
            button_SB.UseVisualStyleBackColor = false;
            button_SB.Click += button_SB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 655);
            Controls.Add(button_SB);
            Controls.Add(button_BA);
            Controls.Add(button_Sporcu);
            Controls.Add(button_Salon);
            Controls.Add(button_Etkinlik);
            Controls.Add(button_Brans);
            Controls.Add(button_Antrenor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_Antrenor;
        private Button button_Brans;
        private Button button_Etkinlik;
        private Button button_Salon;
        private Button button_Sporcu;
        private Button button_BA;
        private Button button_SB;
    }
}
