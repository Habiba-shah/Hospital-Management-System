namespace sqlHMSproject
{
    partial class Bill
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(396, 267);
            dataGridView1.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(322, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(173, 387);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(26, 387);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 26;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 276);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 31);
            textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 31);
            textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 31);
            textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 333);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 276);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 19;
            label5.Text = "Statuss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 229);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 18;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 167);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 17;
            label3.Text = "PatientName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 114);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 16;
            label2.Text = "BID";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(833, 64);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "Bill";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 460);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
    }
}