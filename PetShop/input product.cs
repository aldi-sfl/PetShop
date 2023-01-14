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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Text.RegularExpressions;
using PetShop.class_class;

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
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");

        

        private void reset()
        {
            txtidproduk.Text = "";
            txtnama.Text = "";
            txtharga.Text = "";
            txtjumlah.Text = "";
            cbkategori.SelectedIndex = 0;
            txtcari.Text = "";
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




       

        private void btcari_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Products where Name like '%"+txtcari.Text+"%' or Category like '%" + txtcari.Text + "%'";
            
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
            
            int product = int.Parse(txtidproduk.Text);
            string name = txtnama.Text;
            bool productvalid = validasiProduct.ValidateCredentialsproduct(product);
            bool namevalid = validasiProduct.ValidateCredentialsname(name);
            //bool namevalid = ValidateCredentialsname(name);

            if (productvalid || namevalid)
            {

                DialogResult result = MessageBox.Show("Id produk atau nama produk sudah terdaftar. apakah anda ingin update?", "Confirm", MessageBoxButtons.YesNo);
                 
                if (result == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand ccmd = new SqlCommand();
                    ccmd.Connection = con;
                    ccmd.CommandType = CommandType.Text;
                    ccmd.CommandText = " update Products set  Price = '" + int.Parse(txtharga.Text) + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtidproduk.Text) + "' or Name = '" + txtnama.Text + "'";

                    ccmd.ExecuteNonQuery();

                    con.Close();

                    showdata();
                    
                    reset();
                    showmaxid();
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
            string selectedItem = cbkategori.SelectedItem.ToString();
            //cmd.CommandText = " insert into Products values ('" + customid + "','" + selectedItem+"','"+ txtnama.Text + "','" + int.Parse(txtharga.Text) + "','" + int.Parse(txtjumlah.Text) + "')";
            //cmd.CommandText = " insert into Products (ProductID, Category, Name, Price, Quantity) values ('" + int.Parse(txtidproduk.Text) + "','" + selectedItem + "','" + txtnama.Text + "','" + txtharga.Text + "','" + int.Parse(txtjumlah.Text) + "')";
            cmd.CommandText = "INSERT INTO Products (ProductID, Category, Name, Price, Quantity) VALUES (@productId, @category, @name, @price, @quantity)";
            cmd.Parameters.AddWithValue("@productId", int.Parse(txtidproduk.Text));
            cmd.Parameters.AddWithValue("@category", selectedItem);
            cmd.Parameters.AddWithValue("@name", txtnama.Text);
            cmd.Parameters.AddWithValue("@price", txtharga.Text);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtjumlah.Text));

            SqlParameter ProductID = new SqlParameter("@productid", SqlDbType.Int);
            SqlParameter Category = new SqlParameter("@category", SqlDbType.VarChar);
            SqlParameter Name = new SqlParameter("@name", SqlDbType.VarChar);
            SqlParameter Price = new SqlParameter("@harga", SqlDbType.Int);
            SqlParameter Quantity = new SqlParameter("@jumlah", SqlDbType.Int);

            ProductID.Value = int.Parse(txtidproduk.Text);
            Category.Value = selectedItem;
            Name.Value = txtnama.Text;
            Price.Value = int.Parse(txtharga.Text);
            Quantity.Value = int.Parse(txtjumlah.Text);

            cmd.Parameters.Add(ProductID);
            cmd.Parameters.Add(Category);
            cmd.Parameters.Add(Name);
            cmd.Parameters.Add(Price);
            cmd.Parameters.Add(Quantity);

            con.Close();

            showdata();
            reset();
            showmaxid();

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
            //bool productvalid = ValidateCredentialsproduct(product);
            bool productvalid = validasiProduct.ValidateCredentialsproduct(product);
            if (productvalid )
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " update Products set Category = '"+selectedItem+"', Name = '" + txtnama.Text + "', Price = '" + int.Parse(txtharga.Text) + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtidproduk.Text) + "'";

                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di update", "pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.None);

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
            //bool productvalid = ValidateCredentialsproduct(product);
            bool productvalid = validasiProduct.ValidateCredentialsproduct(product);

            if (productvalid)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = " delete from Products where ProductID = '" + int.Parse(txtidproduk.Text) + "'";
                cmd.CommandText = "select Name from Products where ProductID = '" + int.Parse(txtidproduk.Text) + "'";
                using(SqlDataReader read = cmd.ExecuteReader())
                
                {
                    if(read.Read())
                    {
                        string readname = read.GetString("Name");
                        con.Close();
                        DialogResult result = MessageBox.Show("apakah anda yakin ingin hapus produk " + readname + "", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            con.Open();

                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = " delete from Products where ProductID = '" + int.Parse(txtidproduk.Text) + "'";
                            cmd.ExecuteNonQuery();
                            con.Close();

                            showdata();
                            showmaxid();
                            reset();
                        }

                    }
                    
                }
                }
            else
            {
                MessageBox.Show("id produk tidak terdaftar silahkan periksa kembali id produk yang tersedia");
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar)&& !char.IsSymbol(e.KeyChar); ;
           

        }

        private void order_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtcari_Click(object sender, EventArgs e)
        {

        }

        private void txtcari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btcari.PerformClick();
            }
        }

        private void txtjumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar); ;
            
        }
    }
}
