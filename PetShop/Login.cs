using Microsoft.VisualBasic.Logging;
using PetShop.class_class;
using System.Data;
using System.Data.SqlClient;
using PetShop.class_class;

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

            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(@"Data Source=DESKTOP-48CBQ99;Initial Catalog=db_PetShop1;Integrated Security=True");
            //con.Open();
            koneksi.con.Open();
            
            
            txtpassword.UseSystemPasswordChar = true;
        }
        

        private void btlogin_Click(object sender, EventArgs e)
        {
            showusername.username = txtuser.Text;
            if (txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Customers where username='" + txtuser.Text + "' and password='" + txtpassword.Text + "'", koneksi.con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("login berhasil","succes",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
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