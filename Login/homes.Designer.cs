namespace Login
{
    partial class homes
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(116, 86, 174);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 12);
            label7.Name = "label7";
            label7.Size = new Size(131, 27);
            label7.TabIndex = 40;
            label7.Text = "EmpName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(116, 86, 174);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 375);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 34;
            label6.Text = "DashBoard";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(116, 86, 174);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 301);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 36;
            label4.Text = "Embassy";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(116, 86, 174);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 231);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 37;
            label3.Text = "Employee";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(116, 86, 174);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 162);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 38;
            label1.Text = "University";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(57, 82);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 39;
            label2.Text = "Home";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.ForeColor = Color.FromArgb(220, 192, 128);
            panel2.Location = new Point(20, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 39);
            panel2.TabIndex = 32;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.ForeColor = Color.FromArgb(220, 192, 128);
            panel1.Location = new Point(231, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 563);
            panel1.TabIndex = 33;
            // 
            // homes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            ClientSize = new Size(957, 573);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            Name = "homes";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
    }
}