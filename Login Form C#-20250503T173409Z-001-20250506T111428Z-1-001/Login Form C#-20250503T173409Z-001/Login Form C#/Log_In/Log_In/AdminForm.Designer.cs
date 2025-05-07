namespace Log_In
{
    partial class AdminForm
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
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtFname = new TextBox();
            label3 = new Label();
            txtStudentNo = new TextBox();
            label4 = new Label();
            txtMname = new TextBox();
            label5 = new Label();
            txtLname = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dntBday = new DateTimePicker();
            label8 = new Label();
            cmbCourse = new ComboBox();
            cmbSection = new ComboBox();
            label9 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            label10 = new Label();
            chbShowPassword = new CheckBox();
            button2 = new Button();
            txtSearch = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            btnLogout = new Button();
            btnx = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(257, 50);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(26, 25);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(29, 52);
            txtID.Name = "txtID";
            txtID.Size = new Size(182, 23);
            txtID.TabIndex = 2;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(26, 168);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(182, 23);
            txtFname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(23, 141);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "*Firstname";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(29, 108);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(182, 23);
            txtStudentNo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(26, 81);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 5;
            label4.Text = "*Student No";
            // 
            // txtMname
            // 
            txtMname.Location = new Point(29, 226);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(182, 23);
            txtMname.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(26, 199);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 7;
            label5.Text = "*Middlename";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(29, 283);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(182, 23);
            txtLname.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(26, 261);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 9;
            label6.Text = "*Lastname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(26, 316);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 11;
            label7.Text = "*Birthday";
            // 
            // dntBday
            // 
            dntBday.Format = DateTimePickerFormat.Short;
            dntBday.Location = new Point(29, 339);
            dntBday.Name = "dntBday";
            dntBday.Size = new Size(182, 23);
            dntBday.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(26, 373);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 13;
            label8.Text = "*Course";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(29, 396);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(182, 23);
            cmbCourse.TabIndex = 14;
            // 
            // cmbSection
            // 
            cmbSection.FormattingEnabled = true;
            cmbSection.Location = new Point(29, 453);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(182, 23);
            cmbSection.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(26, 430);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 15;
            label9.Text = "*Section";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 563);
            button1.Name = "button1";
            button1.Size = new Size(182, 36);
            button1.TabIndex = 17;
            button1.Text = "UPDATE RECORD";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 505);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(182, 23);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(26, 483);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 18;
            label10.Text = "*Password";
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.ForeColor = SystemColors.Highlight;
            chbShowPassword.Location = new Point(103, 534);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(108, 19);
            chbShowPassword.TabIndex = 20;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(29, 610);
            button2.Name = "button2";
            button2.Size = new Size(182, 36);
            button2.TabIndex = 21;
            button2.Text = "DELETE RECORD";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(257, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(407, 23);
            txtSearch.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(670, 88);
            button3.Name = "button3";
            button3.Size = new Size(131, 33);
            button3.TabIndex = 23;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 459);
            dataGridView1.TabIndex = 24;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Highlight;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(857, 38);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 33);
            btnLogout.TabIndex = 25;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnx
            // 
            btnx.BackColor = Color.Transparent;
            btnx.FlatAppearance.BorderSize = 0;
            btnx.FlatStyle = FlatStyle.Flat;
            btnx.Font = new Font("Segoe UI", 12F);
            btnx.ForeColor = SystemColors.Highlight;
            btnx.Location = new Point(1003, 14);
            btnx.Name = "btnx";
            btnx.Size = new Size(35, 35);
            btnx.TabIndex = 26;
            btnx.Text = "x";
            btnx.UseVisualStyleBackColor = false;
            btnx.Click += btnx_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 668);
            Controls.Add(btnx);
            Controls.Add(btnLogout);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(txtSearch);
            Controls.Add(button2);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(cmbSection);
            Controls.Add(label9);
            Controls.Add(cmbCourse);
            Controls.Add(label8);
            Controls.Add(dntBday);
            Controls.Add(label7);
            Controls.Add(txtLname);
            Controls.Add(label6);
            Controls.Add(txtMname);
            Controls.Add(label5);
            Controls.Add(txtStudentNo);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtFname;
        private Label label3;
        private TextBox txtStudentNo;
        private Label label4;
        private TextBox txtMname;
        private Label label5;
        private TextBox txtLname;
        private Label label6;
        private Label label7;
        private DateTimePicker dntBday;
        private Label label8;
        private ComboBox cmbCourse;
        private ComboBox cmbSection;
        private Label label9;
        private Button button1;
        private TextBox txtPassword;
        private Label label10;
        private CheckBox chbShowPassword;
        private Button button2;
        private TextBox txtSearch;
        private Button button3;
        private DataGridView dataGridView1;
        private Button btnLogout;
        private Button btnx;
    }
}