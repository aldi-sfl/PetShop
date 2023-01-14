﻿using System;
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
            
        }

        private void idorder()
        {
            Random rng = new Random();

            string id = "";
            for (int i = 0; i < 2; i++)
            {
                int r = rng.Next(0, 30);
                if (r < 26)
                {
                    id += (int)('0' + r);
                }
                else
                {
                    id += (int)('9' + r - 26);
                }
            }
            txtidorder.Text= id;
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            idorder();
            showcustomerid();
            showdata();
            dgvtampil.ReadOnly = true;
            labelusername.Text = showusername.username;
            txtharga.ReadOnly = true;
            //lbid.Hide();
            //lbidproduct.Hide();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");

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


        private void showproductid()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select ProductID from Products where Name='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int ID = reader.GetInt32("ProductID");
                    txtidproduct.Text = ID.ToString();
  
                }
            }con.Close();
        }

        private void showcustomerid()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select CustomerID from Customers where username='" + labelusername.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int ID = reader.GetInt32("CustomerID");
                    lbidcust.Text = ID.ToString();

                }
            }
            con.Close();
        }

        private void showprice()
        {
            con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select Price from Products where Name='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int price = reader.GetInt32("Price");
                    int hasil = price*int.Parse(txtjumlah.Text);
                    txtharga.Text = hasil.ToString();

                    //MessageBox.Show("Price of " + txtproduct.Text + " dengan jumlah yang dipesan"+txtjumlah.Text+"adalah : " + hasil);
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            con.Close();

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            showprice();
            showproductid();
            showcustomerid();

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "ADD_ORDER";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter CustomerID = new SqlParameter("@customerid", SqlDbType.Int);
            SqlParameter OrderID = new SqlParameter("@orderid", SqlDbType.Int);
            SqlParameter Username = new SqlParameter("@username", SqlDbType.VarChar);

            CustomerID.Value = int.Parse(lbidcust.Text);
            OrderID.Value = int.Parse(txtidorder.Text);
            Username.Value = labelusername.Text;

            cmd.Parameters.Add(CustomerID);
            cmd.Parameters.Add(OrderID);
            cmd.Parameters.Add(Username);
            

            int cekdata = cmd.ExecuteNonQuery();
            if (cekdata > 0)
            {
                MessageBox.Show("data berhasil disimpan");
            }
            con.Close();
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

        private void btco_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "ADD_ORDERITEM";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter OrderID = new SqlParameter("@orderid", SqlDbType.VarChar);
            SqlParameter ProductID = new SqlParameter("@productid", SqlDbType.Int);
            SqlParameter Quantity = new SqlParameter("@jumlah", SqlDbType.Int);
            SqlParameter Price = new SqlParameter("@harga", SqlDbType.Int);

            OrderID.Value = txtidorder.Text;
            ProductID.Value = int.Parse(txtidproduct.Text);
            Quantity.Value = int.Parse(txtjumlah.Text);
            Price.Value = int.Parse(txtharga.Text);

            cmd.Parameters.Add(OrderID);
            cmd.Parameters.Add(ProductID);
            cmd.Parameters.Add(Quantity);
            cmd.Parameters.Add(Price);

            int cekdata = cmd.ExecuteNonQuery();
            if (cekdata > 0)
            {
                MessageBox.Show("data berhasil disimpan");
            }
            con.Close();
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
