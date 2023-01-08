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

namespace PetShop
{
    public partial class mencoba : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public mencoba()
        {
            InitializeComponent();
        }

        private void mencoba_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-RSFBMM3I\XFRHK;Initial Catalog=db_PetShop;Integrated Security=True");
            cn.Open();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobacoba registration = new cobacoba();
            registration.ShowDialog();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Users where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
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
    }
}
