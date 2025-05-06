namespace SporKulubuYS_UI
{
    partial class SalonIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_salonYER = new TextBox();
            textBox_salonAD = new TextBox();
            textBox_salonID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox_salonKAPASITE = new TextBox();
            dataGridView1 = new DataGridView();
            button_listeleSalon = new Button();
            button_guncelleSalon = new Button();
            button_silSalon = new Button();
            button_ekleSalon = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 30;
            label1.Text = "ID:";
            // 
            // textBox_salonYER
            // 
            textBox_salonYER.Font = new Font("Segoe UI", 12F);
            textBox_salonYER.Location = new Point(189, 257);
            textBox_salonYER.Multiline = true;
            textBox_salonYER.Name = "textBox_salonYER";
            textBox_salonYER.Size = new Size(240, 51);
            textBox_salonYER.TabIndex = 29;
            // 
            // textBox_salonAD
            // 
            textBox_salonAD.Font = new Font("Segoe UI", 12F);
            textBox_salonAD.Location = new Point(189, 183);
            textBox_salonAD.Name = "textBox_salonAD";
            textBox_salonAD.Size = new Size(240, 34);
            textBox_salonAD.TabIndex = 28;
            // 
            // textBox_salonID
            // 
            textBox_salonID.Font = new Font("Segoe UI", 12F);
            textBox_salonID.Location = new Point(195, 54);
            textBox_salonID.Name = "textBox_salonID";
            textBox_salonID.Size = new Size(240, 34);
            textBox_salonID.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(45, 263);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 26;
            label3.Text = "YER:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 189);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 25;
            label2.Text = "AD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(45, 366);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 31;
            label4.Text = "KAPASİTE:";
            // 
            // textBox_salonKAPASITE
            // 
            textBox_salonKAPASITE.Font = new Font("Segoe UI", 12F);
            textBox_salonKAPASITE.Location = new Point(189, 360);
            textBox_salonKAPASITE.Name = "textBox_salonKAPASITE";
            textBox_salonKAPASITE.Size = new Size(147, 34);
            textBox_salonKAPASITE.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(561, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(548, 314);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button_listeleSalon
            // 
            button_listeleSalon.BackColor = Color.DarkKhaki;
            button_listeleSalon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_listeleSalon.ForeColor = SystemColors.Control;
            button_listeleSalon.Location = new Point(841, 511);
            button_listeleSalon.Name = "button_listeleSalon";
            button_listeleSalon.Size = new Size(127, 53);
            button_listeleSalon.TabIndex = 37;
            button_listeleSalon.Text = "LİSTELE";
            button_listeleSalon.UseVisualStyleBackColor = false;
            button_listeleSalon.Click += button_listeleSalon_Click;
            // 
            // button_guncelleSalon
            // 
            button_guncelleSalon.BackColor = Color.DarkKhaki;
            button_guncelleSalon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_guncelleSalon.ForeColor = SystemColors.Control;
            button_guncelleSalon.Location = new Point(621, 511);
            button_guncelleSalon.Name = "button_guncelleSalon";
            button_guncelleSalon.Size = new Size(127, 53);
            button_guncelleSalon.TabIndex = 36;
            button_guncelleSalon.Text = "GÜNCELLE";
            button_guncelleSalon.UseVisualStyleBackColor = false;
            button_guncelleSalon.Click += button_guncelleSalon_Click;
            // 
            // button_silSalon
            // 
            button_silSalon.BackColor = Color.DarkKhaki;
            button_silSalon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_silSalon.ForeColor = SystemColors.Control;
            button_silSalon.Location = new Point(403, 511);
            button_silSalon.Name = "button_silSalon";
            button_silSalon.Size = new Size(127, 53);
            button_silSalon.TabIndex = 35;
            button_silSalon.Text = "SİL";
            button_silSalon.UseVisualStyleBackColor = false;
            button_silSalon.Click += button_silSalon_Click;
            // 
            // button_ekleSalon
            // 
            button_ekleSalon.BackColor = Color.DarkKhaki;
            button_ekleSalon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_ekleSalon.ForeColor = SystemColors.Control;
            button_ekleSalon.Location = new Point(189, 511);
            button_ekleSalon.Name = "button_ekleSalon";
            button_ekleSalon.Size = new Size(127, 53);
            button_ekleSalon.TabIndex = 34;
            button_ekleSalon.Text = "EKLE";
            button_ekleSalon.UseVisualStyleBackColor = false;
            button_ekleSalon.Click += button_ekleSalon_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(51, 119);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 39;
            label5.Text = "BRANŞ ID:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(195, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 34);
            textBox1.TabIndex = 38;
            // 
            // SalonIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 608);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button_listeleSalon);
            Controls.Add(button_guncelleSalon);
            Controls.Add(button_silSalon);
            Controls.Add(button_ekleSalon);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_salonKAPASITE);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox_salonYER);
            Controls.Add(textBox_salonAD);
            Controls.Add(textBox_salonID);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "SalonIslem";
            Text = "SalonIslem";
            Load += SalonIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_salonYER;
        private TextBox textBox_salonAD;
        private TextBox textBox_salonID;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox_salonKAPASITE;
        private DataGridView dataGridView1;
        private Button button_listeleSalon;
        private Button button_guncelleSalon;
        private Button button_silSalon;
        private Button button_ekleSalon;
        private Label label5;
        private TextBox textBox1;
    }
}