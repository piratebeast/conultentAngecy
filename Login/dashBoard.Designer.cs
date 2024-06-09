namespace Login
{
    partial class dashBoard
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
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label13 = new Label();
            restartbtn2 = new Button();
            label9 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(116, 86, 174);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 160);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 49;
            label2.Text = "University";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(116, 86, 174);
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 303);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 54;
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
            label3.Location = new Point(63, 84);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 56;
            label3.Text = "Home";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.FromArgb(220, 192, 128);
            panel2.Location = new Point(22, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 39);
            panel2.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGoldenrodYellow;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(20, 2);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 52;
            label6.Text = "DashBoard";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(116, 86, 174);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(56, 233);
            label7.Name = "label7";
            label7.Size = new Size(118, 31);
            label7.TabIndex = 55;
            label7.Text = "Employee";
            label7.Click += label7_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(116, 86, 174);
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(22, 15);
            label13.Name = "label13";
            label13.Size = new Size(131, 27);
            label13.TabIndex = 57;
            label13.Text = "EmpName";
            // 
            // restartbtn2
            // 
            restartbtn2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restartbtn2.ForeColor = Color.FromArgb(116, 86, 174);
            restartbtn2.Location = new Point(753, 303);
            restartbtn2.Name = "restartbtn2";
            restartbtn2.Size = new Size(123, 36);
            restartbtn2.TabIndex = 58;
            restartbtn2.Text = "Restart";
            restartbtn2.UseVisualStyleBackColor = true;
            restartbtn2.Click += restartbtn2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(398, 15);
            label9.Name = "label9";
            label9.Size = new Size(154, 28);
            label9.TabIndex = 60;
            label9.Text = "Top 10 student";
            // 
            // dashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            ClientSize = new Size(957, 573);
            Controls.Add(label9);
            Controls.Add(restartbtn2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label13);
            Name = "dashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashBoard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label13;
        private Button restartbtn2;
        private Label label9;
    }
}