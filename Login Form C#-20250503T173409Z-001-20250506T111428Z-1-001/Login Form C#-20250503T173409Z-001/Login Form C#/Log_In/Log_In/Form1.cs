using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Form1 : Form
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=nunez2_db;username=root;password=;");

        public Form1()
        {
            InitializeComponent();
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

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult Close = MessageBox.Show("Do you want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Close == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                con.Open();
                string query = "SELECT * FROM student_info WHERE username=@username and password=@password;";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string name = reader["firstname"].ToString();
                    string role = reader["role"].ToString();

                    MessageBox.Show($"Welcome {name}! You are logged in as {role}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (role == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }

                    else if (role == "student")
                    {
                        StudentForm studForm = new StudentForm();
                        studForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
