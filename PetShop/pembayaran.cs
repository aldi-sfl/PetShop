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
using PetShop.class_class;

namespace PetShop
{
    public partial class pembayaran : Form
    {
        public pembayaran()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();

        }

        

        private void pembayaran_Load(object sender, EventArgs e)
        {
            
            dataproduk();
            tampilhewan();
        }

       

        private void dataproduk()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_produk ";
            DataSet ds = new DataSet();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tb_produk");

            dgvproduk.DataSource = ds;

            dgvproduk.DataMember = "tb_produk";

            dgvproduk.ReadOnly = true;
            
        }

        private void tampilhewan()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_hewan ";
            DataSet ds = new DataSet();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tb_hewan");

            dgvhewan.DataSource = ds;

            dgvhewan.DataMember = "tb_hewan";

            dgvhewan.ReadOnly = true;


        }









        private void button1_Click(object sender, EventArgs e)
        {
            if(txtproduct.Text == "")
            {
                MessageBox.Show("masukan nama produk");
                return;
            }
            if (txtjumlah.Text == "")
            {
                MessageBox.Show("masukan jumlah produk");
                return;
            }
            

          
            
          
        }
        

       

        private void btco_Click(object sender, EventArgs e)
        {
            
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
            
            
        }

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvhewan.Visible = false;
            dgvproduk.Visible = false;
            if (cbjenis.SelectedItem == "Hewan")
            {
                paneltutup.Visible = false;
                dgvhewan.Visible= true;    
            }else if(cbjenis.SelectedItem =="Alat, pakan, dll")
            {
                paneltutup.Visible = false;
                dgvproduk.Visible= true;
            }
            else
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login_admin keluar = new login_admin();
            keluar.Show();
            this.Hide();
        }

        private void btexit_Click(object sender, EventArgs e)
        {

        }
    }
}
