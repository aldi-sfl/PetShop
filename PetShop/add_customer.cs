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
    public partial class add_customer : Form
    {
        public add_customer()
        {
            InitializeComponent();
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
            
            id();
        }

        private void id()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);
            string id = "ID-" + num;
            txtid.Text = id;    


        }

        

        private void btsimpan_Click(object sender, EventArgs e)
        {
            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("ADD_CUSTOMER", koneksi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcustomer", txtid.Text);
            cmd.Parameters.AddWithValue("@nama", txtnama.Text);
            cmd.Parameters.AddWithValue("@nohp", txthp.Text);
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
            int cekdata = cmd.ExecuteNonQuery();
            if (cekdata > 0)
            {
                MessageBox.Show("data berhasil disimpan");

            }
        }
    }
}
