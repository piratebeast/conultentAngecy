namespace Login
{
    partial class employee
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
            employeesDGV = new DataGridView();
            panel3 = new Panel();
            phoneSearchTb = new TextBox();
            label5 = new Label();
            deletbtn = new Button();
            editbtn = new Button();
            savebtn = new Button();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            empAddressTb = new TextBox();
            empPhoneTb = new TextBox();
            empPasswordTb = new TextBox();
            empNameTb = new TextBox();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesDGV).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(116, 86, 174);
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 12);
            label7.Name = "label7";
            label7.Size = new Size(131, 27);
            label7.TabIndex = 31;
            label7.Text = "EmpName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(116, 86, 174);
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(51, 375);
            label6.Name = "label6";
            label6.Size = new Size(131, 31);
            label6.TabIndex = 25;
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
            label4.Location = new Point(54, 300);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 27;
            label4.Text = "Embassy";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGoldenrodYellow;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(116, 86, 174);
            label3.Location = new Point(54, 230);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 28;
            label3.Text = "Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(116, 86, 174);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 161);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 29;
            label1.Text = "University";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(116, 86, 174);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 81);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 30;
            label2.Text = "Home";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGoldenrodYellow;
            panel2.ForeColor = Color.FromArgb(220, 192, 128);
            panel2.Location = new Point(26, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 39);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(employeesDGV);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.ForeColor = Color.FromArgb(220, 192, 128);
            panel1.Location = new Point(235, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 563);
            panel1.TabIndex = 24;
            // 
            // employeesDGV
            // 
            employeesDGV.BackgroundColor = Color.White;
            employeesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesDGV.GridColor = Color.FromArgb(116, 86, 174);
            employeesDGV.Location = new Point(31, 237);
            employeesDGV.Name = "employeesDGV";
            employeesDGV.Size = new Size(684, 317);
            employeesDGV.TabIndex = 32;
            employeesDGV.CellContentClick += employeesDGV_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(phoneSearchTb);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(deletbtn);
            panel3.Controls.Add(editbtn);
            panel3.Controls.Add(savebtn);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(empAddressTb);
            panel3.Controls.Add(empPhoneTb);
            panel3.Controls.Add(empPasswordTb);
            panel3.Controls.Add(empNameTb);
            panel3.Location = new Point(31, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 179);
            panel3.TabIndex = 0;
            // 
            // phoneSearchTb
            // 
            phoneSearchTb.BackColor = Color.FromArgb(230, 231, 233);
            phoneSearchTb.BorderStyle = BorderStyle.None;
            phoneSearchTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneSearchTb.Location = new Point(235, 94);
            phoneSearchTb.Multiline = true;
            phoneSearchTb.Name = "phoneSearchTb";
            phoneSearchTb.Size = new Size(207, 32);
            phoneSearchTb.TabIndex = 28;
            phoneSearchTb.TextChanged += phoneSearchTb_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(235, 74);
            label5.Name = "label5";
            label5.Size = new Size(145, 17);
            label5.TabIndex = 27;
            label5.Text = "Search Phone Number";
            // 
            // deletbtn
            // 
            deletbtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletbtn.ForeColor = Color.FromArgb(116, 86, 174);
            deletbtn.Location = new Point(541, 136);
            deletbtn.Name = "deletbtn";
            deletbtn.Size = new Size(123, 36);
            deletbtn.TabIndex = 26;
            deletbtn.Text = "Delet";
            deletbtn.UseVisualStyleBackColor = true;
            deletbtn.Click += deletbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbtn.ForeColor = Color.FromArgb(116, 86, 174);
            editbtn.Location = new Point(541, 94);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(123, 36);
            editbtn.TabIndex = 26;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.ForeColor = Color.FromArgb(116, 86, 174);
            savebtn.Location = new Point(429, 136);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(106, 36);
            savebtn.TabIndex = 26;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(116, 86, 174);
            label11.Location = new Point(14, 68);
            label11.Name = "label11";
            label11.Size = new Size(57, 17);
            label11.TabIndex = 25;
            label11.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(116, 86, 174);
            label10.Location = new Point(457, 10);
            label10.Name = "label10";
            label10.Size = new Size(101, 17);
            label10.TabIndex = 25;
            label10.Text = "Phone Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(116, 86, 174);
            label8.Location = new Point(235, 10);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 25;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(116, 86, 174);
            label9.Location = new Point(14, 10);
            label9.Name = "label9";
            label9.Size = new Size(44, 17);
            label9.TabIndex = 24;
            label9.Text = "Name";
            // 
            // empAddressTb
            // 
            empAddressTb.BackColor = Color.FromArgb(230, 231, 233);
            empAddressTb.BorderStyle = BorderStyle.None;
            empAddressTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empAddressTb.Location = new Point(14, 88);
            empAddressTb.Multiline = true;
            empAddressTb.Name = "empAddressTb";
            empAddressTb.Size = new Size(207, 79);
            empAddressTb.TabIndex = 23;
            // 
            // empPhoneTb
            // 
            empPhoneTb.BackColor = Color.FromArgb(230, 231, 233);
            empPhoneTb.BorderStyle = BorderStyle.None;
            empPhoneTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empPhoneTb.Location = new Point(457, 30);
            empPhoneTb.Multiline = true;
            empPhoneTb.Name = "empPhoneTb";
            empPhoneTb.Size = new Size(207, 32);
            empPhoneTb.TabIndex = 23;
            // 
            // empPasswordTb
            // 
            empPasswordTb.BackColor = Color.FromArgb(230, 231, 233);
            empPasswordTb.BorderStyle = BorderStyle.None;
            empPasswordTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empPasswordTb.Location = new Point(235, 30);
            empPasswordTb.Multiline = true;
            empPasswordTb.Name = "empPasswordTb";
            empPasswordTb.PasswordChar = '•';
            empPasswordTb.Size = new Size(207, 32);
            empPasswordTb.TabIndex = 23;
            // 
            // empNameTb
            // 
            empNameTb.BackColor = Color.FromArgb(230, 231, 233);
            empNameTb.BorderStyle = BorderStyle.None;
            empNameTb.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empNameTb.Location = new Point(14, 30);
            empNameTb.Multiline = true;
            empNameTb.Name = "empNameTb";
            empNameTb.Size = new Size(207, 32);
            empNameTb.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightGoldenrodYellow;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(233, 203);
            label12.Name = "label12";
            label12.Size = new Size(249, 31);
            label12.TabIndex = 30;
            label12.Text = "Employees Inforamtion";
            // 
            // employee
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
            Name = "employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private Label label8;
        private Label label9;
        private TextBox empPasswordTb;
        private TextBox empNameTb;
        private Label label11;
        private Label label10;
        private TextBox empAddressTb;
        private TextBox empPhoneTb;
        private Button deletbtn;
        private Button editbtn;
        private Button savebtn;
        private Label label12;
        private DataGridView employeesDGV;
        private TextBox phoneSearchTb;
        private Label label5;
    }
}