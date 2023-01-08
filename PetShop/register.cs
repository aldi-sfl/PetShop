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
        (@"Data Source=DESKTOP-48CBQ99;Initial Catalog=db_PetShop1;Integrated Security=True");

        private void randomid()
        {
            Random rng= new Random();

            string id = "ID";
            for(int i = 0; i < 2; i++)
            {
                int r = rng.Next(0, 30);
                if(r < 26)
                {
                    id += (int)('0' + r);
                }
                else
                {
                    id += (int)('9' + r - 26);
                }
            }
            txtId.Text = id;
        }

        private void register_Load(object sender, EventArgs e)
        {
            randomid();
            txtId.ReadOnly= true;
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

        private void btrng_Click(object sender, EventArgs e)
        {
            randomid();
        }



        private void btsave_Click(object sender, EventArgs e)
        {

            string nama, email, nohp, alamat;

            nama = txtnama.Text;
            email = txtemail.Text;
            nohp = txthp.Text;
            alamat = txtalamat.Text;


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

            con.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = con;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "INSERT INTO Customers values ('" + txtId.Text + "','" + txtnama.Text + "','" + txthp.Text + "','" + txtemail.Text + "', '" + txtpassword.Text + "', '" + txtalamat.Text + "')";

            

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

        private void txthp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
    }
}
