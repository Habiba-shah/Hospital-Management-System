namespace sqlHMSproject
{
    partial class MedicalRecord
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
            btnInsert = new Button();
            btnInsert = new Button();
            comboBoxDiagnosis = new ComboBox();
            comboBoxNurse = new ComboBox();
            comboBoxDoctor = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label7 = new Label();
            label1 = new Label();
            label7 = new Label();
            comboBoxPrescription = new ComboBox();
            label8 = new Label();
            comboBoxTreatment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(383, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(396, 267);
            dataGridView1.TabIndex = 43;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(354, 424);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(205, 424);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(58, 424);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 40;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // comboBoxDiagnosis
            // 
            comboBoxDiagnosis.FormattingEnabled = true;
            comboBoxDiagnosis.Location = new Point(160, 280);
            comboBoxDiagnosis.Name = "comboBoxDiagnosis";
            comboBoxDiagnosis.Size = new Size(201, 33);
            comboBoxDiagnosis.TabIndex = 39;
            // 
            // comboBoxNurse
            // 
            comboBoxNurse.FormattingEnabled = true;
            comboBoxNurse.Location = new Point(163, 243);
            comboBoxNurse.Name = "comboBoxNurse";
            comboBoxNurse.Size = new Size(201, 33);
            comboBoxNurse.TabIndex = 38;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(160, 196);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(201, 33);
            comboBoxDoctor.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 31);
            textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 31);
            textBox1.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 289);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 34;
            label6.Text = "Diagnosis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 249);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 33;
            label5.Text = "Nurse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 202);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 32;
            label4.Text = "DoctorName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 140);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 31;
            label3.Text = "PatientName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 87);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 30;
            label2.Text = "MID";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 82);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 26);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Medical Record";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 329);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 44;
            label7.Text = "Prescription";
            // 
            // comboBoxPrescription
            // 
            comboBoxPrescription.FormattingEnabled = true;
            comboBoxPrescription.Location = new Point(163, 323);
            comboBoxPrescription.Name = "comboBoxPrescription";
            comboBoxPrescription.Size = new Size(177, 33);
            comboBoxPrescription.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 358);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 46;
            label8.Text = "Treatment";
            // 
            // comboBoxTreatment
            // 
            comboBoxTreatment.FormattingEnabled = true;
            comboBoxTreatment.Location = new Point(165, 360);
            comboBoxTreatment.Name = "comboBoxTreatment";
            comboBoxTreatment.Size = new Size(150, 33);
            comboBoxTreatment.TabIndex = 47;
            // 
            // MedicalRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 504);
            Controls.Add(comboBoxTreatment);
            Controls.Add(label8);
            Controls.Add(comboBoxPrescription);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnInsert);
            Controls.Add(comboBoxDiagnosis);
            Controls.Add(comboBoxNurse);
            Controls.Add(comboBoxDoctor);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "MedicalRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicalRecord";
            Load += MedicalRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private ComboBox comboBoxDiagnosis;
        private ComboBox comboBoxNurse;
        private ComboBox comboBoxDoctor;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label7;
        private ComboBox comboBoxPrescription;
        private Label label8;
        private ComboBox comboBoxTreatment;
    }
}