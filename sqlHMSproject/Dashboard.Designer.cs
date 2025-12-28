namespace sqlHMSproject
{
    partial class Dashboard
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
            panel2 = new Panel();
            lblTitle1 = new Label();
            lblCount1 = new Label();
            panel3 = new Panel();
            lblTitle2 = new Label();
            lblCount2 = new Label();
            panel4 = new Panel();
            lblTitle3 = new Label();
            lblCount3 = new Label();
            panel5 = new Panel();
            lblTitle4 = new Label();
            lblCount4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(280, 20);
            label1.Name = "label1";
            label1.Size = new Size(354, 48);
            label1.TabIndex = 0;
            label1.Text = "Hospital Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 204, 113);
            panel2.Controls.Add(lblTitle1);
            panel2.Controls.Add(lblCount1);
            panel2.Location = new Point(40, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 120);
            panel2.TabIndex = 1;
            // 
            // lblTitle1
            // 
            lblTitle1.AutoSize = true;
            lblTitle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle1.ForeColor = Color.White;
            lblTitle1.Location = new Point(15, 15);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new Size(84, 28);
            lblTitle1.TabIndex = 2;
            lblTitle1.Text = "Patients";
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCount1.ForeColor = Color.White;
            lblCount1.Location = new Point(15, 50);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(46, 54);
            lblCount1.TabIndex = 1;
            lblCount1.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(52, 152, 219);
            panel3.Controls.Add(lblTitle2);
            panel3.Controls.Add(lblCount2);
            panel3.Location = new Point(240, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 120);
            panel3.TabIndex = 0;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle2.ForeColor = Color.White;
            lblTitle2.Location = new Point(15, 15);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(82, 28);
            lblTitle2.TabIndex = 2;
            lblTitle2.Text = "Doctors";
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCount2.ForeColor = Color.White;
            lblCount2.Location = new Point(15, 50);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(46, 54);
            lblCount2.TabIndex = 1;
            lblCount2.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(230, 126, 34);
            panel4.Controls.Add(lblTitle3);
            panel4.Controls.Add(lblCount3);
            panel4.Location = new Point(440, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 120);
            panel4.TabIndex = 2;
            // 
            // lblTitle3
            // 
            lblTitle3.AutoSize = true;
            lblTitle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle3.ForeColor = Color.White;
            lblTitle3.Location = new Point(15, 15);
            lblTitle3.Name = "lblTitle3";
            lblTitle3.Size = new Size(75, 28);
            lblTitle3.TabIndex = 2;
            lblTitle3.Text = "Nurses";
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCount3.ForeColor = Color.White;
            lblCount3.Location = new Point(15, 50);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(46, 54);
            lblCount3.TabIndex = 1;
            lblCount3.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(155, 89, 182);
            panel5.Controls.Add(lblTitle4);
            panel5.Controls.Add(lblCount4);
            panel5.Location = new Point(640, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 120);
            panel5.TabIndex = 3;
            // 
            // lblTitle4
            // 
            lblTitle4.AutoSize = true;
            lblTitle4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle4.ForeColor = Color.White;
            lblTitle4.Location = new Point(15, 15);
            lblTitle4.Name = "lblTitle4";
            lblTitle4.Size = new Size(142, 28);
            lblTitle4.TabIndex = 3;
            lblTitle4.Text = "Appointments";
            // 
            // lblCount4
            // 
            lblCount4.AutoSize = true;
            lblCount4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCount4.ForeColor = Color.White;
            lblCount4.Location = new Point(15, 50);
            lblCount4.Name = "lblCount4";
            lblCount4.Size = new Size(46, 54);
            lblCount4.TabIndex = 2;
            lblCount4.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(880, 500);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblCount1;
        private Label lblTitle1;
        private Panel panel3;
        private Label lblCount2;
        private Label lblTitle2;
        private Panel panel4;
        private Label lblCount3;
        private Label lblTitle3;
        private Panel panel5;
        private Label lblCount4;
        private Label lblTitle4;
    }
}