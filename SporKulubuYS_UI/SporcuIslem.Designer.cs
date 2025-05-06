namespace SporKulubuYS_UI
{
    partial class SporcuIslem
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
            textBox_sporcuEPOSTA = new TextBox();
            textBox_sporcuSOYAD = new TextBox();
            textBox_sporcuAD = new TextBox();
            textBox_sporcuID = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dateTimePickerSporcu = new DateTimePicker();
            label4 = new Label();
            button_listeleSporcu = new Button();
            button_guncelleSporcu = new Button();
            button_silSporcu = new Button();
            button_ekleSporcu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_sporcuEPOSTA
            // 
            textBox_sporcuEPOSTA.Font = new Font("Segoe UI", 12F);
            textBox_sporcuEPOSTA.Location = new Point(300, 374);
            textBox_sporcuEPOSTA.Name = "textBox_sporcuEPOSTA";
            textBox_sporcuEPOSTA.Size = new Size(190, 34);
            textBox_sporcuEPOSTA.TabIndex = 24;
            // 
            // textBox_sporcuSOYAD
            // 
            textBox_sporcuSOYAD.Font = new Font("Segoe UI", 12F);
            textBox_sporcuSOYAD.Location = new Point(300, 172);
            textBox_sporcuSOYAD.Name = "textBox_sporcuSOYAD";
            textBox_sporcuSOYAD.Size = new Size(190, 34);
            textBox_sporcuSOYAD.TabIndex = 21;
            // 
            // textBox_sporcuAD
            // 
            textBox_sporcuAD.Font = new Font("Segoe UI", 12F);
            textBox_sporcuAD.Location = new Point(300, 112);
            textBox_sporcuAD.Name = "textBox_sporcuAD";
            textBox_sporcuAD.Size = new Size(190, 34);
            textBox_sporcuAD.TabIndex = 20;
            // 
            // textBox_sporcuID
            // 
            textBox_sporcuID.Font = new Font("Segoe UI", 12F);
            textBox_sporcuID.Location = new Point(300, 49);
            textBox_sporcuID.Name = "textBox_sporcuID";
            textBox_sporcuID.Size = new Size(190, 34);
            textBox_sporcuID.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(51, 374);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 17;
            label5.Text = "EPOSTA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 178);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 15;
            label3.Text = "SOYAD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 14;
            label2.Text = "AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 13;
            label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(616, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 325);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new Point(300, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 28);
            comboBox1.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(51, 306);
            label6.Name = "label6";
            label6.Size = new Size(103, 28);
            label6.TabIndex = 27;
            label6.Text = "CİNSİYET:";
            // 
            // dateTimePickerSporcu
            // 
            dateTimePickerSporcu.Font = new Font("Segoe UI", 10.5F);
            dateTimePickerSporcu.Location = new Point(300, 236);
            dateTimePickerSporcu.Name = "dateTimePickerSporcu";
            dateTimePickerSporcu.Size = new Size(240, 31);
            dateTimePickerSporcu.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(51, 237);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 28;
            label4.Text = "DOĞUM TARİHİ:";
            // 
            // button_listeleSporcu
            // 
            button_listeleSporcu.BackColor = Color.DarkKhaki;
            button_listeleSporcu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_listeleSporcu.ForeColor = SystemColors.Control;
            button_listeleSporcu.Location = new Point(906, 560);
            button_listeleSporcu.Name = "button_listeleSporcu";
            button_listeleSporcu.Size = new Size(127, 53);
            button_listeleSporcu.TabIndex = 34;
            button_listeleSporcu.Text = "LİSTELE";
            button_listeleSporcu.UseVisualStyleBackColor = false;
            button_listeleSporcu.Click += button_listeleSporcu_Click;
            // 
            // button_guncelleSporcu
            // 
            button_guncelleSporcu.BackColor = Color.DarkKhaki;
            button_guncelleSporcu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_guncelleSporcu.ForeColor = SystemColors.Control;
            button_guncelleSporcu.Location = new Point(686, 560);
            button_guncelleSporcu.Name = "button_guncelleSporcu";
            button_guncelleSporcu.Size = new Size(127, 53);
            button_guncelleSporcu.TabIndex = 33;
            button_guncelleSporcu.Text = "GÜNCELLE";
            button_guncelleSporcu.UseVisualStyleBackColor = false;
            button_guncelleSporcu.Click += button_guncelleSporcu_Click;
            // 
            // button_silSporcu
            // 
            button_silSporcu.BackColor = Color.DarkKhaki;
            button_silSporcu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_silSporcu.ForeColor = SystemColors.Control;
            button_silSporcu.Location = new Point(468, 560);
            button_silSporcu.Name = "button_silSporcu";
            button_silSporcu.Size = new Size(127, 53);
            button_silSporcu.TabIndex = 32;
            button_silSporcu.Text = "SİL";
            button_silSporcu.UseVisualStyleBackColor = false;
            button_silSporcu.Click += button_silSporcu_Click;
            // 
            // button_ekleSporcu
            // 
            button_ekleSporcu.BackColor = Color.DarkKhaki;
            button_ekleSporcu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_ekleSporcu.ForeColor = SystemColors.Control;
            button_ekleSporcu.Location = new Point(254, 560);
            button_ekleSporcu.Name = "button_ekleSporcu";
            button_ekleSporcu.Size = new Size(127, 53);
            button_ekleSporcu.TabIndex = 31;
            button_ekleSporcu.Text = "EKLE";
            button_ekleSporcu.UseVisualStyleBackColor = false;
            button_ekleSporcu.Click += button_ekleSporcu_Click;
            // 
            // SporcuIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 715);
            Controls.Add(button_listeleSporcu);
            Controls.Add(button_guncelleSporcu);
            Controls.Add(button_silSporcu);
            Controls.Add(button_ekleSporcu);
            Controls.Add(dateTimePickerSporcu);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_sporcuEPOSTA);
            Controls.Add(textBox_sporcuSOYAD);
            Controls.Add(textBox_sporcuAD);
            Controls.Add(textBox_sporcuID);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SporcuIslem";
            Text = "SporcuIslem";
            Load += SporcuIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_sporcuEPOSTA;
        private TextBox textBox_sporcuSOYAD;
        private TextBox textBox_sporcuAD;
        private TextBox textBox_sporcuID;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker dateTimePickerSporcu;
        private Label label4;
        private Button button_listeleSporcu;
        private Button button_guncelleSporcu;
        private Button button_silSporcu;
        private Button button_ekleSporcu;
    }
}