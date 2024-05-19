namespace Login
{
    partial class frmLogin
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
            clearBtn = new Button();
            loginBtn = new Button();
            checkBxShowPas = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.White;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.ForeColor = Color.FromArgb(116, 86, 174);
            clearBtn.Location = new Point(33, 372);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(216, 35);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "Clean";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(116, 86, 174);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(33, 318);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(216, 35);
            loginBtn.TabIndex = 17;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // checkBxShowPas
            // 
            checkBxShowPas.AutoSize = true;
            checkBxShowPas.Cursor = Cursors.Hand;
            checkBxShowPas.FlatStyle = FlatStyle.Flat;
            checkBxShowPas.Location = new Point(127, 266);
            checkBxShowPas.Name = "checkBxShowPas";
            checkBxShowPas.Size = new Size(119, 21);
            checkBxShowPas.TabIndex = 15;
            checkBxShowPas.Text = "Show password";
            checkBxShowPas.UseVisualStyleBackColor = true;
            checkBxShowPas.CheckedChanged += checkBxShowPas_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(33, 229);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(33, 163);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(33, 99);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 10;
            label1.Text = "Get Strated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 209);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 143);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 20;
            label2.Text = "Username";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 554);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clearBtn);
            Controls.Add(loginBtn);
            Controls.Add(checkBxShowPas);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button clearBtn;
        private Button loginBtn;
        private CheckBox checkBxShowPas;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}