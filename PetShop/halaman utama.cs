using PetShop.class_class;
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
    public partial class halaman_utama : Form
    {
        public halaman_utama()
        {
            InitializeComponent();
        }

        /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
        //SqlConnection con = new SqlConnection
        //    (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");

        //public string GetCurrentUsername()
        //{
        //    try
        //    {
        //        con.Open();

        //        // Retrieve current user's username
        //        string getUsernameQuery = "SELECT username FROM Customers WHERE CustomerID = @userid";
        //        SqlCommand getUsernameCommand = new SqlCommand(getUsernameQuery, con);
        //        getUsernameCommand.Parameters.AddWithValue("@userid", currentUserId);
        //        string currentUsername = (string)getUsernameCommand.ExecuteScalar();

        //        return currentUsername;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine("Error connecting to database: " + ex.Message);
        //        return "";
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void halaman_utama_Load(object sender, EventArgs e)
        {
            labelusername.Text = showusername.username;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btproduk_Click(object sender, EventArgs e)
        {
            Halaman_Utama_Admin keproduk = new Halaman_Utama_Admin();
            keproduk.Show();
            this.Hide();
        }

        private void bttransaksi_Click(object sender, EventArgs e)
        {
            add_customer kebayar = new add_customer();
            kebayar.Show();
            this.Hide();
        }

        private void btkeluar_Click(object sender, EventArgs e)
        {
            login_admin keluar = new login_admin();
            keluar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vendor vendor = new vendor();
            vendor.Show();
            this.Hide();
        }
    }
}
