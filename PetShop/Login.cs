using System.Data;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar= true;
        }
        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        SqlConnection con = new SqlConnection
                (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop;Integrated Security=True");

        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
private bool ValidateCredentials(string email, string password)
    {
            SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_petshop;Integrated Security=True");
            {
            con.Open();

            // Check if the username and password match a record in the database
            string query = "SELECT COUNT(*) FROM Customers WHERE Email = @email AND Password = @password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", password);
            int count = (int)command.ExecuteScalar();

            return count > 0;
        }
    }


    private void btlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpassword.Text;
            bool isValid = ValidateCredentials(username, password);

            if (isValid)
            {
                // Show the main form and close the login form
                halaman_utama mainForm = new halaman_utama();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                // Show an error message
                MessageBox.Show("Invalid username or password.");
            }
        }



        private void btnregis_Click(object sender, EventArgs e)
        {
            register registrationForm = new register();
            registrationForm.Show();
            this.Hide();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 

        private void btadmin_Click_1(object sender, EventArgs e)
        {
            login_admin admin = new login_admin();
            admin.Show();
            this.Hide();
        }
    }
}