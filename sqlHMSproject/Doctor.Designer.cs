namespace sqlHMSproject
{
    partial class Doctor
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 82);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Doctor";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(396, 267);
            dataGridView1.TabIndex = 28;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(356, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(207, 372);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(60, 372);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 25;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 312);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 31);
            textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 31);
            textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 31);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 31);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 318);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 19;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 261);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 18;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 214);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 17;
            label4.Text = "Speciality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 152);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 16;
            label3.Text = "DoctorName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 99);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 15;
            label2.Text = "DoctorID";
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 471);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Doctor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}