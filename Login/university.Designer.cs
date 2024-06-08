namespace Login
{
    partial class university
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
            universityDGV = new DataGridView();
            panel3 = new Panel();
            deletBtn = new Button();
            editBtn = new Button();
            saveBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            subPerTb = new TextBox();
            cgpaTb = new TextBox();
            uniNameTb = new TextBox();
            studentNameTb = new TextBox();
            label12 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            sscGradeTb = new TextBox();
            label13 = new Label();
            hscGradeTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)universityDGV).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // universityDGV
            // 
            universityDGV.BackgroundColor = Color.White;
            universityDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            universityDGV.GridColor = Color.White;
            universityDGV.Location = new Point(24, 237);
            universityDGV.Name = "universityDGV";
            universityDGV.Size = new Size(684, 317);
            universityDGV.TabIndex = 32;
            universityDGV.CellContentClick += universityDGV_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(hscGradeTb);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(sscGradeTb);
            panel3.Controls.Add(deletBtn);
            panel3.Controls.Add(editBtn);
            panel3.Controls.Add(saveBtn);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(subPerTb);
            panel3.Controls.Add(cgpaTb);
            panel3.Controls.Add(uniNameTb);
            panel3.Controls.Add(studentNameTb);
            panel3.Location = new Point(34, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 179);
            panel3.TabIndex = 0;
            // 
            // deletBtn
            // 
            deletBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletBtn.ForeColor = Color.FromArgb(116, 86, 174);
            deletBtn.Location = new Point(534, 131);
            deletBtn.Name = "deletBtn";
            deletBtn.Size = new Size(123, 36);
            deletBtn.TabIndex = 26;
            deletBtn.Text = "Delet";
            deletBtn.UseVisualStyleBackColor = true;
            deletBtn.Click += deletBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.FromArgb(116, 86, 174);
            editBtn.Location = new Point(534, 89);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(123, 36);
            editBtn.TabIndex = 26;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.FromArgb(116, 86, 174);
            saveBtn.Location = new Point(405, 131);
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
            label11.Location = new Point(17, 68);
            label11.Name = "label11";
            label11.Size = new Size(122, 17);
            label11.TabIndex = 25;
            label11.Text = "Subject preference";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(116, 86, 174);
            label10.Location = new Point(460, 10);
            label10.Name = "label10";
            label10.Size = new Size(37, 17);
            label10.TabIndex = 25;
            label10.Text = "cgpa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(116, 86, 174);
            label8.Location = new Point(238, 10);
            label8.Name = "label8";
            label8.Size = new Size(108, 17);
            label8.TabIndex = 25;
            label8.Text = "University name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(116, 86, 174);
            label9.Location = new Point(17, 10);
            label9.Name = "label9";
            label9.Size = new Size(96, 17);
            label9.TabIndex = 24;
            label9.Text = "Student Name";
            // 
            // subPerTb
            // 
            subPerTb.BackColor = Color.FromArgb(230, 231, 233);
            subPerTb.BorderStyle = BorderStyle.None;
            subPerTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subPerTb.Location = new Point(17, 88);
            subPerTb.Multiline = true;
            subPerTb.Name = "subPerTb";
            subPerTb.Size = new Size(207, 79);
            subPerTb.TabIndex = 23;
            // 
            // cgpaTb
            // 
            cgpaTb.BackColor = Color.FromArgb(230, 231, 233);
            cgpaTb.BorderStyle = BorderStyle.None;
            cgpaTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cgpaTb.Location = new Point(460, 30);
            cgpaTb.Multiline = true;
            cgpaTb.Name = "cgpaTb";
            cgpaTb.Size = new Size(207, 32);
            cgpaTb.TabIndex = 23;
            // 
            // uniNameTb
            // 
            uniNameTb.BackColor = Color.FromArgb(230, 231, 233);
            uniNameTb.BorderStyle = BorderStyle.None;
            uniNameTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uniNameTb.Location = new Point(238, 30);
            uniNameTb.Multiline = true;
            uniNameTb.Name = "uniNameTb";
            uniNameTb.Size = new Size(207, 32);
            uniNameTb.TabIndex = 23;
            // 
            // studentNameTb
            // 
            studentNameTb.BackColor = Color.FromArgb(230, 231, 233);
            studentNameTb.BorderStyle = BorderStyle.None;
            studentNameTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentNameTb.Location = new Point(17, 30);
            studentNameTb.Multiline = true;
            studentNameTb.Name = "studentNameTb";
            studentNameTb.Size = new Size(207, 32);
            studentNameTb.TabIndex = 22;
            studentNameTb.TextChanged += studentNameTb_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightGoldenrodYellow;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(189, 203);
            label12.Name = "label12";
            label12.Size = new Size(370, 31);
            label12.TabIndex = 30;
            label12.Text = "Student and University Inforamtion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(116, 86, 174);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 82);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 39;
            label2.Text = "Home";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.FromArgb(220, 192, 128);
            panel2.Location = new Point(28, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 39);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGoldenrodYellow;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(32, 5);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 38;
            label1.Text = "University";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(universityDGV);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.ForeColor = Color.FromArgb(220, 192, 128);
            panel1.Location = new Point(237, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 563);
            panel1.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(116, 86, 174);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 371);
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
            label4.Location = new Point(56, 301);
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
            label3.Location = new Point(56, 231);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 37;
            label3.Text = "Employee";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(116, 86, 174);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 13);
            label7.Name = "label7";
            label7.Size = new Size(131, 27);
            label7.TabIndex = 40;
            label7.Text = "EmpName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(230, 75);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 28;
            label5.Text = "SSC Grade";
            // 
            // sscGradeTb
            // 
            sscGradeTb.BackColor = Color.FromArgb(230, 231, 233);
            sscGradeTb.BorderStyle = BorderStyle.None;
            sscGradeTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sscGradeTb.Location = new Point(230, 95);
            sscGradeTb.Multiline = true;
            sscGradeTb.Name = "sscGradeTb";
            sscGradeTb.Size = new Size(116, 32);
            sscGradeTb.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(116, 86, 174);
            label13.Location = new Point(352, 76);
            label13.Name = "label13";
            label13.Size = new Size(73, 17);
            label13.TabIndex = 30;
            label13.Text = "HSC Grade";
            // 
            // hscGradeTb
            // 
            hscGradeTb.BackColor = Color.FromArgb(230, 231, 233);
            hscGradeTb.BorderStyle = BorderStyle.None;
            hscGradeTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hscGradeTb.Location = new Point(352, 96);
            hscGradeTb.Multiline = true;
            hscGradeTb.Name = "hscGradeTb";
            hscGradeTb.Size = new Size(116, 32);
            hscGradeTb.TabIndex = 29;
            // 
            // university
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(116, 86, 174);
            ClientSize = new Size(957, 573);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Name = "university";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "university";
            ((System.ComponentModel.ISupportInitialize)universityDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView universityDGV;
        private Panel panel3;
        private Button deletBtn;
        private Button editBtn;
        private Button saveBtn;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox subPerTb;
        private TextBox cgpaTb;
        private TextBox uniNameTb;
        private TextBox studentNameTb;
        private Label label12;
        private Label label2;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label1;
        private Label label13;
        private TextBox hscGradeTb;
        private Label label5;
        private TextBox sscGradeTb;
    }
}