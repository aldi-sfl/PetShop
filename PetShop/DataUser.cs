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
using PetShop.class_class;

namespace PetShop
{
    public partial class DataUser : Form
    {


        public DataUser()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        //SqlConnection con = new SqlConnection
        //    (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");
       
        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customers";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customers");

            dgvds.DataSource = ds;

            dgvds.DataMember = "Customers";

            dgvds.ReadOnly = true;


        }

        private void DataUser_Load(object sender, EventArgs e)
        {

        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customers where username like '%" + txtcari.Text + "%'";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customers");

            dgvds.DataSource = ds;

            dgvds.DataMember = "Customers";

            dgvds.ReadOnly = true;
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            
            
}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Halaman_Utama_Admin home = new Halaman_Utama_Admin();
            home.Show();
            this.Hide();
        }
    }
}
    
