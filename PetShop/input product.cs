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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace PetShop
{
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            cbkategori.SelectedIndex= 0; 
        }
        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop;Integrated Security=True");

        

        private void reset()
        {
            txtidproduk.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";
            txtjumlah.Text = "";
            cbkategori.SelectedIndex = 0;
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType =CommandType.Text;
            cmd.CommandText = "select ProductID, Category, Name, Price, Quantity from Products ";
            DataSet ds = new DataSet();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvproduk.DataSource = ds;

            dgvproduk.DataMember = "Products";
            
            dgvproduk.ReadOnly=true;

        
        }

        private void showmaxid()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "SELECT MAX(ProductID) +1 FROM Products";
            object hasil = cmdd.ExecuteScalar();
            txtidproduk.Text = hasil.ToString();
            con.Close();

        }

        private void order_Load(object sender, EventArgs e)
        {
            reset();
            showdata();
            showmaxid();
            
        }



        private bool ValidateCredentialsproduct(int product)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM Products WHERE ProductID = @product";
                SqlCommand command = new SqlCommand(query, con);
                {
                    command.Parameters.AddWithValue("@product", product);                   
                    
                }
                int count = (int)command.ExecuteScalar();

                return count > 0; 
            }
        }

        private bool ValidateCredentialsname(string name)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM Products WHERE  Name = @name";
                SqlCommand command = new SqlCommand(query, con);
                {
                    
                    command.Parameters.AddWithValue("@name", name);
                }
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

       

        private void btcari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where Name  like '%"+txtcari.Text+"%' ";
            cmd.CommandText = "select * from Products where Category  like '%" + txtcari.Text + "%' ";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Products");

            dgvproduk.DataSource = ds;

            dgvproduk.DataMember = "Products";

            dgvproduk.ReadOnly = true;
        }


        private void btinsert_Click(object sender, EventArgs e)
        {

            if (txtidproduk.Text == "")
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

            string selectedItem = cbkategori.SelectedItem.ToString();


            int product = int.Parse(txtidproduk.Text);
            string name = txtnama.Text;
            bool productvalid = ValidateCredentialsproduct(product);
            bool namevalid = ValidateCredentialsname(name);

            if (productvalid || namevalid)
            {

                DialogResult result = MessageBox.Show("Id produk atau nama produk sudah terdaftar. apakah anda ingin update?", "Confirm", MessageBoxButtons.YesNo);
                 
                if (result == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand ccmd = new SqlCommand();
                    ccmd.Connection = con;
                    ccmd.CommandType = CommandType.Text;
                    ccmd.CommandText = " update Products set Name = '" + txtnama.Text + "', Price = '" + txtharga.Text + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtidproduk.Text) + "'";

                    ccmd.ExecuteNonQuery();

                    con.Close();

                    showdata();
                    showmaxid();
                    reset();
                    return;


                }
                else
                {
                    return;
                }


            }

            con.Open();

            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = " insert into Products values ('" + customid + "','" + selectedItem+"','"+ txtnama.Text + "','" + int.Parse(txtharga.Text) + "','" + int.Parse(txtjumlah.Text) + "')";

            cmd.CommandText = " insert into Products (ProductID, Category, Name, Price, Quantity) values ('" + int.Parse(txtidproduk.Text) + "','" + selectedItem + "','" + txtnama.Text + "','" + txtharga.Text + "','" + int.Parse(txtjumlah.Text) + "')";

            cmd.ExecuteNonQuery();

            con.Close();

            showdata();
            showmaxid();
            reset();    

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtidproduk.Text == "")
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

            int product = int.Parse(txtidproduk.Text);
            bool productvalid = ValidateCredentialsproduct(product);
            if(productvalid )
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update Products set Name = '" + txtnama.Text + "', Price = '" + txtharga.Text + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtidproduk.Text) + "'";

                cmd.ExecuteNonQuery();

                con.Close();

                showdata();
                showmaxid();
                reset();
            }
            else
            {
                MessageBox.Show("id tidak ditemukan");
            }

            
        }


        

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (txtidproduk.Text == "")
            {
                MessageBox.Show("isi id produk yang akan dihapus");
                return;
            }

            int product = int.Parse(txtidproduk.Text);
            bool productvalid = ValidateCredentialsproduct(product);

            if (productvalid)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " delete from Products where ProductID = '" + int.Parse(txtidproduk.Text) + "'";

                cmd.ExecuteNonQuery();

                con.Close();

                showdata();
                showmaxid();
                reset();
            }
            else
                {
                MessageBox.Show("id produk tidak terdaftar");
                    return;
                }

        }


        private void btreset_Click(object sender, EventArgs e)
        {
            reset();
            showmaxid();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Halaman_Utama_Admin halaman_Utama_Admin = new Halaman_Utama_Admin();
            halaman_Utama_Admin.Show();
            this.Hide();
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);

        }


    }
}
