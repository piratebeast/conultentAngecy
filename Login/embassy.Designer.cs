namespace Login
{
    partial class embassy
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
            panel1 = new Panel();
            embassyDGV = new DataGridView();
            panel3 = new Panel();
            deliveredCb = new ComboBox();
            label5 = new Label();
            workPrgCb = new ComboBox();
            label1 = new Label();
            deletBtn = new Button();
            EditBtn = new Button();
            saveBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            policeRepTb = new TextBox();
            conInfoTb = new TextBox();
            passportNumTb = new TextBox();
            studentNameTb = new TextBox();
            label12 = new Label();
            label6 = new Label();
            label7 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)embassyDGV).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(116, 86, 174);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 158);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 38;
            label2.Text = "University";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGoldenrodYellow;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(116, 86, 174);
            label4.Location = new Point(55, 301);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 45;
            label4.Text = "Embassy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(116, 86, 174);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 82);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 47;
            label3.Text = "Home";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.ForeColor = Color.FromArgb(220, 192, 128);
            panel2.Location = new Point(27, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 39);
            panel2.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(embassyDGV);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.ForeColor = Color.FromArgb(220, 192, 128);
            panel1.Location = new Point(236, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 563);
            panel1.TabIndex = 42;
            // 
            // embassyDGV
            // 
            embassyDGV.BackgroundColor = Color.White;
            embassyDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            embassyDGV.GridColor = Color.White;
            embassyDGV.Location = new Point(24, 231);
            embassyDGV.Name = "embassyDGV";
            embassyDGV.Size = new Size(684, 317);
            embassyDGV.TabIndex = 35;
            embassyDGV.CellContentClick += embassyDGV_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(deliveredCb);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(workPrgCb);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(deletBtn);
            panel3.Controls.Add(EditBtn);
            panel3.Controls.Add(saveBtn);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(policeRepTb);
            panel3.Controls.Add(conInfoTb);
            panel3.Controls.Add(passportNumTb);
            panel3.Controls.Add(studentNameTb);
            panel3.Location = new Point(24, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 179);
            panel3.TabIndex = 33;
            // 
            // deliveredCb
            // 
            deliveredCb.Font = new Font("MS UI Gothic", 15.75F);
            deliveredCb.FormattingEnabled = true;
            deliveredCb.Items.AddRange(new object[] { "Yes", "No" });
            deliveredCb.Location = new Point(229, 142);
            deliveredCb.Name = "deliveredCb";
            deliveredCb.Size = new Size(178, 29);
            deliveredCb.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(229, 122);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 29;
            label5.Text = "Delivered";
            // 
            // workPrgCb
            // 
            workPrgCb.Font = new Font("MS UI Gothic", 15.75F);
            workPrgCb.FormattingEnabled = true;
            workPrgCb.Items.AddRange(new object[] { "Pending", "Accepted", "Rejected" });
            workPrgCb.Location = new Point(229, 93);
            workPrgCb.Name = "workPrgCb";
            workPrgCb.Size = new Size(178, 29);
            workPrgCb.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(229, 73);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 27;
            label1.Text = "Work progress";
            // 
            // deletBtn
            // 
            deletBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletBtn.ForeColor = Color.FromArgb(116, 86, 174);
            deletBtn.Location = new Point(540, 81);
            deletBtn.Name = "deletBtn";
            deletBtn.Size = new Size(123, 36);
            deletBtn.TabIndex = 26;
            deletBtn.Text = "Delet";
            deletBtn.UseVisualStyleBackColor = true;
            deletBtn.Click += deletBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.FromArgb(116, 86, 174);
            EditBtn.Location = new Point(540, 123);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(123, 36);
            EditBtn.TabIndex = 26;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.FromArgb(116, 86, 174);
            saveBtn.Location = new Point(411, 81);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(123, 36);
            saveBtn.TabIndex = 26;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(116, 86, 174);
            label11.Location = new Point(8, 68);
            label11.Name = "label11";
            label11.Size = new Size(90, 17);
            label11.TabIndex = 25;
            label11.Text = "Police Report";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(116, 86, 174);
            label10.Location = new Point(451, 10);
            label10.Name = "label10";
            label10.Size = new Size(84, 17);
            label10.TabIndex = 25;
            label10.Text = "Contact info";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(116, 86, 174);
            label8.Location = new Point(229, 10);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 25;
            label8.Text = "Passport Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(116, 86, 174);
            label9.Location = new Point(8, 10);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 24;
            label9.Text = "Name";
            // 
            // policeRepTb
            // 
            policeRepTb.BackColor = Color.FromArgb(230, 231, 233);
            policeRepTb.BorderStyle = BorderStyle.None;
            policeRepTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            policeRepTb.Location = new Point(8, 88);
            policeRepTb.Multiline = true;
            policeRepTb.Name = "policeRepTb";
            policeRepTb.Size = new Size(207, 34);
            policeRepTb.TabIndex = 23;
            // 
            // conInfoTb
            // 
            conInfoTb.BackColor = Color.FromArgb(230, 231, 233);
            conInfoTb.BorderStyle = BorderStyle.None;
            conInfoTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conInfoTb.Location = new Point(451, 30);
            conInfoTb.Multiline = true;
            conInfoTb.Name = "conInfoTb";
            conInfoTb.Size = new Size(207, 32);
            conInfoTb.TabIndex = 23;
            // 
            // passportNumTb
            // 
            passportNumTb.BackColor = Color.FromArgb(230, 231, 233);
            passportNumTb.BorderStyle = BorderStyle.None;
            passportNumTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passportNumTb.Location = new Point(229, 30);
            passportNumTb.Multiline = true;
            passportNumTb.Name = "passportNumTb";
            passportNumTb.Size = new Size(207, 32);
            passportNumTb.TabIndex = 23;
            // 
            // studentNameTb
            // 
            studentNameTb.BackColor = Color.FromArgb(230, 231, 233);
            studentNameTb.BorderStyle = BorderStyle.None;
            studentNameTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentNameTb.Location = new Point(8, 30);
            studentNameTb.Multiline = true;
            studentNameTb.Name = "studentNameTb";
            studentNameTb.Size = new Size(207, 32);
            studentNameTb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightGoldenrodYellow;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(226, 197);
            label12.Name = "label12";
            label12.Size = new Size(249, 31);
            label12.TabIndex = 34;
            label12.Text = "Employees Inforamtion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(116, 86, 174);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 374);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 43;
            label6.Text = "DashBoard";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(116, 86, 174);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(55, 231);
            label7.Name = "label7";
            label7.Size = new Size(118, 31);
            label7.TabIndex = 46;
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
            label13.Location = new Point(21, 13);
            label13.Name = "label13";
            label13.Size = new Size(131, 27);
            label13.TabIndex = 48;
            label13.Text = "EmpName";
            // 
            // embassy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            ClientSize = new Size(957, 573);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label13);
            Name = "embassy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "embassy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)embassyDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label13;
        private DataGridView embassyDGV;
        private Panel panel3;
        private Button deletBtn;
        private Button EditBtn;
        private Button saveBtn;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox policeRepTb;
        private TextBox conInfoTb;
        private TextBox passportNumTb;
        private TextBox studentNameTb;
        private Label label12;
        private ComboBox workPrgCb;
        private Label label1;
        private ComboBox deliveredCb;
        private Label label5;
    }
}