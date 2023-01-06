using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class login_admin : Form
    {
        public login_admin()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
        }

        private bool ValidateCredentials(string username, string password)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_petshop;Integrated Security=True");
            {
                con.Open();

                // Check if the username and password match a record in the database
                string query = "SELECT COUNT(*) FROM Admin WHERE Email = @username AND password = @password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void login_admin_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username = txtemail.Text;
            string password = txtpassword.Text;
            bool isValid = ValidateCredentials(username, password);

            if (isValid)
            {
                // Show the main form and close the login form
                MessageBox.Show("login berhasil");
                order mainForm = new order();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
    
}
