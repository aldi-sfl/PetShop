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
            txtid.ReadOnly= true;
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=petshop;Integrated Security=True");




        private void register_Load(object sender, EventArgs e)
        {
            
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

            

            

        }

        private void btcanccel_Click(object sender, EventArgs e)
        {
            Form1 registrationForm = new Form1();
            registrationForm.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
