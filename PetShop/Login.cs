using System.Data;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar= true;
        }
        

        


       

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-RSFBMM3I\XFRHK;Initial Catalog=db_PetShop1;Integrated Security=True");
            con.Open();
            txtpassword.UseSystemPasswordChar = true;
        }
        private bool ValidateCredentials(string id, string password)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_petshop;Integrated Security=True");
            {
            con.Open();

            // Check if the username and password match a record in the database
            string query = "SELECT COUNT(*) FROM Customers WHERE UsernameID = @id AND Password = @password";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@password", password);
            int count = (int)command.ExecuteScalar();

            return count > 0;
            }
        }


        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Customers where username='" + txtuser.Text + "' and password='" + txtpassword.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    halaman_utama home = new halaman_utama();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Tidak ada Akun yang tersedia dengan nama pengguna dan kata sandi ini ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Tolong isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btadmin_Click_1(object sender, EventArgs e)
        {
            login_admin admin = new login_admin();
            admin.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}