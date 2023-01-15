using PetShop.class_class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.class_class;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class nota : Form
    {
        public nota()
        {
            InitializeComponent();
            
        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void nota_Load(object sender, EventArgs e)
        {
            labelusername.Text = showusername.username;
            ldidorder.Text = notanota.orderid;
            showdata();
        }

        private void showdata()
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from OrderItems where OrderID ='"+ldidorder.Text+"'";
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "OrderItems");

            dgvnota.DataSource = ds;

            dgvnota.DataMember = "OrderItems";

            dgvnota.ReadOnly = true;


        }

        private void btexit_Click(object sender, EventArgs e)
        {
            halaman_utama home = new halaman_utama();
            home.Show();
            this.Hide   ();
        }
    }
}
