namespace Log_In
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chbShowPassword = new CheckBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnX = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(565, 110);
            label1.Name = "label1";
            label1.Size = new Size(232, 24);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 687);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(212, 566);
            label5.Name = "label5";
            label5.Size = new Size(218, 18);
            label5.TabIndex = 2;
            label5.Text = "Develop by: Nunez John Paulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(141, 367);
            label4.Name = "label4";
            label4.Size = new Size(207, 88);
            label4.TabIndex = 1;
            label4.Text = "Welcome to the \r\nCLARK COLLAGE\r\nStudent Management\r\nSystem";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Clark_College_of_Science_and_Technology;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(90, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 272);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(529, 194);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(529, 290);
            label3.Name = "label3";
            label3.Size = new Size(78, 18);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(529, 239);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 26);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(527, 331);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 26);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = SystemColors.Highlight;
            chbShowPassword.Location = new Point(529, 387);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(140, 22);
            chbShowPassword.TabIndex = 6;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(528, 441);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 46);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.Highlight;
            btnRegister.Location = new Point(529, 504);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(301, 46);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER ACCOUNT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.ForeColor = SystemColors.Highlight;
            btnX.Location = new Point(827, 12);
            btnX.Name = "btnX";
            btnX.Size = new Size(25, 26);
            btnX.TabIndex = 9;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 605);
            Controls.Add(btnX);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox chbShowPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnX;
    }
}
