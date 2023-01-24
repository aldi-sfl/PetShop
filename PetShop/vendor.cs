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
    public partial class vendor : Form
    {
        public vendor()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            
        }

        

        private void vendor_Load(object sender, EventArgs e)
        {
            
        }

        private void btsimpan_Click(object sender, EventArgs e)
        {
            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("ADD_VENDOR", koneksi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idvendor", txtidvendor.Text);
            cmd.Parameters.AddWithValue("@namavendor", txtnama.Text);
            cmd.Parameters.AddWithValue("@nohp", txthp.Text);
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
            int cekdata = cmd.ExecuteNonQuery();
            if (cekdata > 0)
            {
                MessageBox.Show("data berhasil disimpan");

            }

        }

        private void btshow_Click(object sender, EventArgs e)
        {
            koneksi.con.Open();
            SqlDataAdapter tampildata = new SqlDataAdapter("select * from tb_vendor", koneksi.con);
            DataTable datatabel = new DataTable();
            tampildata.Fill(datatabel);
            dgvvendor.DataSource = datatabel;
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            
        }
    }
}
