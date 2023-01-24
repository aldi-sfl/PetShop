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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtdto.Visible = false;
            dgvhewan.Visible = false;
            dgvproduk.Visible = false;

            iddetailorder();
            dataproduk();
            tampilhewan();
            idorder();
            totalharga();

            string id = add_customer.idcustomers.ToString();
            txtcustomer.Text = id;
        }

        private void idorder()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);
            string id = "OD-" + num;
            txtidorder.Text = id;
        }


        private void iddetailorder()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);
            string id = "DTO-" + num;
            txtdto.Text = id;


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

        private void tampildetail()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tb_order_detail ";
            DataSet ds = new DataSet();


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tb_order_detail");

            dgvbayar.DataSource = ds;

            dgvbayar.DataMember = "tb_order_detail";

            dgvbayar.ReadOnly = true;


        }

        private void showpriceproduk()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = koneksi.con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select harga from tb_produk where nama='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int price = reader.GetInt32("harga");
                    int hasil = price * int.Parse(txtjumlah.Text);
                    txttotal.Text = hasil.ToString();
                }
                //else
                //{
                //    MessageBox.Show("Product not found");
                //}
            }
            koneksi.con.Close();

        }

        private void showpricehewan()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = koneksi.con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select harga from tb_hewan where jenis_hewan ='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int price = reader.GetInt32("harga");
                    int hasil = price * int.Parse(txtjumlah.Text);
                    txttotal.Text = hasil.ToString();

                }
                //else
                //{
                //    MessageBox.Show("Product not found");
                //}
            }
            koneksi.con.Close();

        }


        private void pemesanan()
        {

            //DataTable dt = new DataTable();
            //dt.Columns.Add("id_detail", typeof(string));
            //dt.Columns.Add("id_order", typeof(string));
            //dt.Columns.Add("id_hewan", typeof(string));
            //dt.Columns.Add("id_produk", typeof(string));
            //dt.Columns.Add("jumlah", typeof(int));
            //dt.Columns.Add("harga", typeof(int));
            //dgvbayar.DataSource = dt;
            //string id_detail = txtdto.Text;
            //string id_order = txtidorder.Text;
            //string id_hewan = txtproduct.Text;
            //string id_produk = txtproduct.Text;
            //int jumlah = Convert.ToInt32(txtjumlah.Text);
            //int harga = Convert.ToInt32(txtharga.Text);

            //dt.Rows.Add(id_detail, id_order, id_hewan, id_produk, jumlah, harga);





        }




        private void idproduk()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = koneksi.con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select id_produk from tb_produk where nama ='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string id = reader.GetString("id_produk");

                    lbproduk.Text = id.ToString();

                }

            }
            koneksi.con.Close();
        }

        private void idhewan()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = koneksi.con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select id_hewan from tb_hewan where jenis_hewan ='" + txtproduct.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string id = reader.GetString("id_hewan");

                    lbhewan.Text = id.ToString();

                }

            }
            koneksi.con.Close();
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            //pemesanan();
            showpriceproduk();
            showpricehewan();
            iddetailorder();
            idorder();
            koneksi.con.Open();
            string dateTimeNow = DateTime.Now.ToString();

            SqlCommand cmds = new SqlCommand("ADD_ORDER", koneksi.con);
            cmds.CommandType = CommandType.StoredProcedure;
            cmds.Parameters.AddWithValue("@idorder", txtidorder.Text);
            cmds.Parameters.AddWithValue("@customerid", txtcustomer.Text);
            cmds.Parameters.AddWithValue("@orderdate", dateTimeNow);

            int cek = cmds.ExecuteNonQuery();
            if (cek > 0)
            {
                MessageBox.Show("data berhasil disimpan");
                idhewan();
                idproduk();

                koneksi.con.Close();

            }

            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("ADD_ORDERDETAIL", koneksi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idorderdetail", txtdto.Text);
            cmd.Parameters.AddWithValue("@idorder", txtidorder.Text);
            cmd.Parameters.AddWithValue("@idhewan", lbhewan.Text);
            cmd.Parameters.AddWithValue("@idproduk", lbproduk.Text);
            cmd.Parameters.AddWithValue("@jumlah", txtjumlah.Text);
            cmd.Parameters.AddWithValue("@total", txttotal.Text);
            int cekdata = cmd.ExecuteNonQuery();
            if (cekdata > 0)
            {
                MessageBox.Show("data berhasil disimpan");
                tampildetail();
                iddetailorder();
                tampilhewan();
                dataproduk();
                totalharga();


            }
            koneksi.con.Close();
            



        }

        private void totalharga()
        {
            double total = 0;
            foreach (DataGridViewRow row in dgvbayar.Rows)
            {
                total += Convert.ToDouble(row.Cells["total"].Value);
            }
            lbtotal.Text = "Rp" + total.ToString();

        }


        private void btco_Click(object sender, EventArgs e)
        {
            koneksi.con.Open();
            MessageBox.Show("total uang yang harus dibayarkan adalah" + lbtotal.Text + "");
            SqlCommand cmdd = new SqlCommand("delete from tb_order_detail ", koneksi.con);
            cmdd.ExecuteNonQuery();
            koneksi.con.Close();
            halaman_utama tambah = new halaman_utama();
            tambah.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {
            idhewan();
            idproduk();
        }

        private void bthome_Click(object sender, EventArgs e)
        {
            halaman_utama home = new halaman_utama();
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

                dgvhewan.Visible = true;
            }
            else if (cbjenis.SelectedItem == "Alat, pakan, dll")
            {

                dgvproduk.Visible = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvproduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = dgvproduk.Rows[e.RowIndex].Cells["id_vendor"].Value.ToString();
            string value2 = dgvproduk.Rows[e.RowIndex].Cells["id_produk"].Value.ToString();
            string value3 = dgvproduk.Rows[e.RowIndex].Cells["nama"].Value.ToString();
            string value4 = dgvproduk.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            string value5 = dgvproduk.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            string value6 = dgvproduk.Rows[e.RowIndex].Cells["harga"].Value.ToString();


            txtproduct.Text = value3;
            txtharga.Text = value6;
            idhewan();
            idproduk();
        }

        private void dgvhewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = dgvhewan.Rows[e.RowIndex].Cells["id_hewan"].Value.ToString();
            string value2 = dgvhewan.Rows[e.RowIndex].Cells["id_vendor"].Value.ToString();
            string value3 = dgvhewan.Rows[e.RowIndex].Cells["jenis_hewan"].Value.ToString();
            string value4 = dgvhewan.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            string value5 = dgvhewan.Rows[e.RowIndex].Cells["stok_hewan"].Value.ToString();
            string value6 = dgvhewan.Rows[e.RowIndex].Cells["harga"].Value.ToString();


            txtproduct.Text = value3;
            txtharga.Text = value6;
            idhewan();
            idproduk();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvbayar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = dgvbayar.Rows[e.RowIndex].Cells["id_detail"].Value.ToString();

            txtdto.Text = value1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hapusproduk();
        }

        private void hapusproduk()
        {
            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_order_detail where id_detail = @idproduk", koneksi.con);
            {
                cmd.Parameters.AddWithValue("@idproduk", txtdto.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {

                    SqlCommand cmdd = new SqlCommand("delete  from tb_order_detail where id_detail = '" + txtdto.Text + "'", koneksi.con);
                    cmdd.ExecuteNonQuery();
                    koneksi.con.Close();
                    MessageBox.Show("produk berhasil di hapus");
                    tampildetail();
                    return;

                }
                else
                {
                    MessageBox.Show("data tidak ditemukan");
                    return;
                }
            }
        }


    }
}
