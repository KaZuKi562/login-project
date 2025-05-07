using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Transactions;
// Import necessary namespaces for MySQL and Windows Forms functionality
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Log_In
{
    public partial class Register : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=nunez2_db;username=root;password=;");

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you want to close the program?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            Login.Show();
            this.Hide();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            if (cmbCourse.SelectedIndex == 0)
            {

                cmbSection.Items.Add("ACT1-A");
                cmbSection.Items.Add("ACT1-B");
                cmbSection.Items.Add("ACT1-C");
                cmbSection.Items.Add("ACT1-D");
                cmbSection.Items.Add("ACT1-E");
                cmbSection.Items.Add("ACT1-F");
            }
            else if (cmbCourse.SelectedIndex == 1)
            {

                cmbSection.Items.Add("HM1-A");
                cmbSection.Items.Add("HM1-B");
                cmbSection.Items.Add("HM1-C");
            }
            else if (cmbCourse.SelectedIndex == 2)
            {

                cmbSection.Items.Add("BSOA1-A");
                cmbSection.Items.Add("BSOA1-B");
                cmbSection.Items.Add("BSOA1-C");
            }


        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtStudNo.Text) ||
                String.IsNullOrWhiteSpace(txtFname.Text) ||
                String.IsNullOrWhiteSpace(txtLname.Text) ||
                String.IsNullOrWhiteSpace(txtMname.Text) ||
                String.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbCourse.SelectedIndex == -1 ||
                cmbSection.SelectedIndex == -1
                )

            {
                MessageBox.Show("All fields must be filled out", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            {
                try
                {
                    con.Open();
                    String checkQuery = "SELECT COUNT(*) FROM userinfotbl WHERE studentNo = @studentNo";
                    MySqlCommand checkcmd = new MySqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@studentNo", txtStudNo.Text);
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Student No. already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStudNo.Clear();
                        return;
                    }

                    string name = txtFname.Text + " " + txtLname.Text;

                    string registerquery = "INSERT INTO userinfotbl (studentNo, lastname, firstname, middlename, birthday, course, section, name, username, password, role)" +
                    "VALUES (@studentNo, @lastname, @firstname, @middlename, @birthday, @course, @section, @name, @username, @password, 'Student')";
                    MySqlCommand cmd = new MySqlCommand(registerquery, con);
                    cmd.Parameters.AddWithValue("@studentNo", txtStudNo.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLname.Text);
                    cmd.Parameters.AddWithValue("@firstname", txtFname.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMname.Text);
                    cmd.Parameters.AddWithValue("@birthday", txtBday.Value);
                    cmd.Parameters.AddWithValue("@course", cmbCourse.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@section", cmbSection.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", txtStudNo.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery(); // Execute insert query


                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear All inputs
                    txtStudNo.Clear();
                    txtLname.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtPassword.Clear();
                    cmbCourse.SelectedIndex = -1;
                    cmbSection.SelectedIndex = -1;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message); ;
                }

                finally
                {
                    con.Close();
                }
            }
        }

        private void cmbCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // prevent user from typing in the combobox
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
