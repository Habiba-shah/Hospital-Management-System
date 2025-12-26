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
            lblCount1 = new Label();
            panel3 = new Panel();
            lblCount2 = new Label();
            panel4 = new Panel();
            lblCount3 = new Label();
            panel5 = new Panel();
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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 0;
            label1.Text = "Life Care Hospital Dashboard";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCount1);
            panel2.Location = new Point(50, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 161);
            panel2.TabIndex = 1;
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Location = new Point(49, 68);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(22, 25);
            lblCount1.TabIndex = 1;
            lblCount1.Text = "0";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblCount2);
            panel3.Location = new Point(306, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 155);
            panel3.TabIndex = 0;
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Location = new Point(39, 68);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(22, 25);
            lblCount2.TabIndex = 1;
            lblCount2.Text = "0";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCount3);
            panel4.Location = new Point(565, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 151);
            panel4.TabIndex = 2;
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Location = new Point(38, 64);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(22, 25);
            lblCount3.TabIndex = 1;
            lblCount3.Text = "0";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblCount4);
            panel5.Location = new Point(50, 269);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 147);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // lblCount4
            // 
            lblCount4.AutoSize = true;
            lblCount4.Location = new Point(49, 74);
            lblCount4.Name = "lblCount4";
            lblCount4.Size = new Size(22, 25);
            lblCount4.TabIndex = 2;
            lblCount4.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
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
        private Panel panel3;
        private Label lblCount2;
        private Panel panel4;
        private Label lblCount3;
        private Panel panel5;
        private Label lblCount4;
    }
}