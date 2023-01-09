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
    public partial class pembayaran : Form
    {
        public pembayaran()
        {
            InitializeComponent();
            
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            showdata();
            dgvtampil.ReadOnly = true;
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop;Integrated Security=True");

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ProductID, Category, Name, Price, Quantity from Products ";
            DataSet ds = new DataSet();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvtampil.DataSource = ds;

            dgvtampil.DataMember = "Products";

            dgvtampil.ReadOnly = true;
        }

        private void showprice()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            //cmdd.CommandText = "SELECT * FROM Products WHERE Name = ('" + txtproduct.Text + "')";
            cmdd.CommandText = "SELECT * FROM Products WHERE Name like '%" + txtproduct.Text + "%' ";
            

            object hasil = cmdd.ExecuteScalar();
            txtproduct.Text = hasil.ToString(); 
            con.Close();

        }
        
        private void showprice1()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "SELECT * FROM Products WHERE Price = ('" + showprice + "')";
            object hasil = cmdd.ExecuteScalar();
            txtharga.Text = hasil.ToString();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //showprice1();
        }
        private void cbview()
        {
            string selectedItem = cbkategori.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where Category like '%" + selectedItem + "%' ";
            
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvtampil.DataSource = ds;

            dgvtampil.DataMember = "Products";

            dgvtampil.ReadOnly = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            produk keproduk = new produk();
            keproduk.Show();
            this.Hide();
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            halaman_utama home= new halaman_utama();
            home.Show();
            this.Hide();
        }

        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbview();
        }

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {
            //showprice1();
        }

       
    }
}
