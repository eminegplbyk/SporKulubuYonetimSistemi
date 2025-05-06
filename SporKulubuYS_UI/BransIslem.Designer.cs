namespace SporKulubuYS_UI
{
    partial class BransIslem
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
            textBox_bransAD = new TextBox();
            textBox_bransID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button_listeleBrans = new Button();
            button_guncelleBrans = new Button();
            button_silBrans = new Button();
            button_ekleBrans = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_bransAD
            // 
            textBox_bransAD.Font = new Font("Segoe UI", 12F);
            textBox_bransAD.Location = new Point(144, 129);
            textBox_bransAD.Name = "textBox_bransAD";
            textBox_bransAD.Size = new Size(190, 34);
            textBox_bransAD.TabIndex = 12;
            // 
            // textBox_bransID
            // 
            textBox_bransID.Font = new Font("Segoe UI", 12F);
            textBox_bransID.Location = new Point(144, 63);
            textBox_bransID.Name = "textBox_bransID";
            textBox_bransID.Size = new Size(190, 34);
            textBox_bransID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 129);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 10;
            label2.Text = "AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(35, 66);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(455, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 305);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button_listeleBrans
            // 
            button_listeleBrans.BackColor = Color.DarkKhaki;
            button_listeleBrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_listeleBrans.ForeColor = SystemColors.Control;
            button_listeleBrans.Location = new Point(872, 548);
            button_listeleBrans.Name = "button_listeleBrans";
            button_listeleBrans.Size = new Size(127, 53);
            button_listeleBrans.TabIndex = 20;
            button_listeleBrans.Text = "LİSTELE";
            button_listeleBrans.UseVisualStyleBackColor = false;
            button_listeleBrans.Click += button_listeleBrans_Click;
            // 
            // button_guncelleBrans
            // 
            button_guncelleBrans.BackColor = Color.DarkKhaki;
            button_guncelleBrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_guncelleBrans.ForeColor = SystemColors.Control;
            button_guncelleBrans.Location = new Point(643, 548);
            button_guncelleBrans.Name = "button_guncelleBrans";
            button_guncelleBrans.Size = new Size(127, 53);
            button_guncelleBrans.TabIndex = 19;
            button_guncelleBrans.Text = "GÜNCELLE";
            button_guncelleBrans.UseVisualStyleBackColor = false;
            button_guncelleBrans.Click += button_guncelleBrans_Click;
            // 
            // button_silBrans
            // 
            button_silBrans.BackColor = Color.DarkKhaki;
            button_silBrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_silBrans.ForeColor = SystemColors.Control;
            button_silBrans.Location = new Point(425, 548);
            button_silBrans.Name = "button_silBrans";
            button_silBrans.Size = new Size(127, 53);
            button_silBrans.TabIndex = 18;
            button_silBrans.Text = "SİL";
            button_silBrans.UseVisualStyleBackColor = false;
            button_silBrans.Click += button_silBrans_Click;
            // 
            // button_ekleBrans
            // 
            button_ekleBrans.BackColor = Color.DarkKhaki;
            button_ekleBrans.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_ekleBrans.ForeColor = SystemColors.Control;
            button_ekleBrans.Location = new Point(211, 548);
            button_ekleBrans.Name = "button_ekleBrans";
            button_ekleBrans.Size = new Size(127, 53);
            button_ekleBrans.TabIndex = 17;
            button_ekleBrans.Text = "EKLE";
            button_ekleBrans.UseVisualStyleBackColor = false;
            button_ekleBrans.Click += button_ekleBrans_Click;
            // 
            // BransIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 662);
            Controls.Add(button_listeleBrans);
            Controls.Add(button_guncelleBrans);
            Controls.Add(button_silBrans);
            Controls.Add(button_ekleBrans);
            Controls.Add(dataGridView1);
            Controls.Add(textBox_bransAD);
            Controls.Add(textBox_bransID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BransIslem";
            Text = "BransIslem";
            Load += BransIslem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_bransAD;
        private TextBox textBox_bransID;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button_listeleBrans;
        private Button button_guncelleBrans;
        private Button button_silBrans;
        private Button button_ekleBrans;
    }
}