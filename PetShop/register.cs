using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PetShop
{
    public partial class register : Form


    {
        public register()
        {
            InitializeComponent();
            
        }

        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        SqlConnection con = new SqlConnection
        (@"Data Source=LAPTOP-RSFBMM3I\XFRHK;Initial Catalog=db_PetShop;Integrated Security=True");



        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void  ClearData()
        {
            txtnama.Clear();
            txtalamat.Clear();
            txthp.Clear();
            txtemail.Clear();
            txtpassword.Clear();
            txtId.Clear();
        }
        




        private void btsave_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "INSERT INTO Customers values ('" + txtId.Text + "','" + txtnama.Text + "','" + txthp.Text + "','" + txtemail.Text + "', '" + txtpassword.Text + "', '" + txtalamat.Text + "')";

            string nama, email /*= "SELECT COUNT(*) FROM Users WHERE Email = @email"*/, nohp, alamat;
            //sqlcmd.Parameters.AddWithValue("@email", email);
            nama = txtnama.Text;
            email = txtemail.Text;
            nohp = txthp.Text;
            alamat = txtalamat.Text;

            //menghindari data duplicate
            //int count = (int)sqlcmd.ExecuteScalar();
            //if (count > 0)
            //{
            //    MessageBox.Show("This username is already taken. Please choose a different one.");
            //    return;
            //}
            if (string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("nama harus diisi.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("email harus diisi.");
                return;
            }

            if (string.IsNullOrEmpty(nohp))
            {
                MessageBox.Show("nomor handphone harus diisi.");
                return;
            }

            if (string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("alamat harus diisi.");
                return;
            }

            MessageBox.Show("register berhasil");
            Form1 balik = new Form1();
            balik.Show();
            this.Hide();

            

            sqlcmd.ExecuteNonQuery();
            con.Close();
            
            ClearData();



            

        }

        private void btcanccel_Click(object sender, EventArgs e)
        {
            Form1 registrationForm = new Form1();
            registrationForm.Show();
            this.Hide();

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
