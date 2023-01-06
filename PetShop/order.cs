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
using System.ComponentModel.Design.Serialization;

namespace PetShop
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop;Integrated Security=True");

        

        private void reset()
        {
            txtid.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";
            txtjumlah.Text = "";

        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "select * from Products";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvproduk.DataSource = ds;

            dgvproduk.DataMember = "Products";

            dgvproduk.ReadOnly=true;

        
        }

        private void order_Load(object sender, EventArgs e)
        {
            reset();
            showdata();
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
           
           
            



            if (txtid.Text == "")
            {
                MessageBox.Show("id harus diisi.");
                return;
            }

            if (txtnama.Text =="")
            {
                MessageBox.Show("nama harus diisi.");
                return;
            }

            if (txtjumlah.Text=="")
            {
                MessageBox.Show("jumlah harus diisi.");
                return;
            }

            if (txtharga.Text == "")
            {
                MessageBox.Show("harga harus diisi.");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Products values ('" + int.Parse(txtid.Text) + "','" + txtnama.Text + "','" + int.Parse(txtharga.Text) + "','" + int.Parse(txtjumlah.Text) + "')";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata(); 
            reset();    

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("id harus diisi.");
                return;
            }

            if (txtnama.Text == "")
            {
                MessageBox.Show("nama harus diisi.");
                return;
            }

            if (txtjumlah.Text == "")
            {
                MessageBox.Show("jumlah harus diisi.");
                return;
            }

            if (txtharga.Text == "")
            {
                MessageBox.Show("harga harus diisi.");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update Products set Name = '" + txtnama.Text + "', Price = '" + int.Parse(txtharga.Text) + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtid.Text)+"'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            reset();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if(txtid.Text == "")
            {
                MessageBox.Show("isi id produk yang akan dihapus");
                return;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Products where ProductID = '" + int.Parse(txtid.Text)+"'";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            reset();

        }
    }
}
