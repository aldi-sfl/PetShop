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
    public partial class produk : Form
    {
        public produk()
        {
            InitializeComponent();
        }

        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvtampil.DataSource = ds;

            dgvtampil.DataMember = "Products";

            dgvtampil.ReadOnly = true;


        }

        private void produk_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttampil_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            halaman_utama balik_utama = new halaman_utama();
            balik_utama.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where Name like '%" + txtcari.Text + "%' or Category like '%" + txtcari.Text + "%'";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvtampil.DataSource = ds;

            dgvtampil.DataMember = "Products";

            dgvtampil.ReadOnly = true;
        }

        private void btbelanja_Click(object sender, EventArgs e)
        {
            pembayaran kebayar = new pembayaran();
            kebayar.Show();
            this.Hide();
        }
    }
}
