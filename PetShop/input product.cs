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
            cbkategori.SelectedIndex = 0;
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();

        }
        
        private void vendorname()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("select id_vendor from tb_vendor", koneksi.con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cbvendor.Items.Add(read["id_vendor"].ToString());
                cbvendor.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


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
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlDataAdapter tampildata = new SqlDataAdapter("select * from tb_produk", koneksi.con);
            DataTable datatabel = new DataTable();
            tampildata.Fill(datatabel);
            dgvproduk.DataSource = datatabel;
            dgvproduk.ReadOnly = true;


        }

       

        private void order_Load(object sender, EventArgs e)
        {
            cbkategori.DropDownStyle = ComboBoxStyle.DropDownList;
            reset();
            showdata();
            vendorname();
            idproduk();
          
        }

        private void idproduk()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);

            if (cbkategori.SelectedItem == "Pakan")
            {
                string id = "PK-" + num;
                txtidproduk.Text = id;
            }
            else if(cbkategori.SelectedItem == "Alat-alat"){
                string id = "ALT-" + num;
                txtidproduk.Text = id;
            }else
            {
                txtidproduk.Text = "-";
            }
            
           
            
            
        }






        private void btcari_Click(object sender, EventArgs e)
        {
            SqlCommand cmda = new SqlCommand();
            cmda.Connection = koneksi.con;
            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "select * from tb_produk where nama like '%" + txtcari.Text + "%' or kategori like '%" + txtcari.Text + "%'";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmda);
            da.Fill(ds, "tb_produk");

            dgvproduk.DataSource = ds;

            dgvproduk.DataMember = "tb_produk";

            dgvproduk.ReadOnly = true;
        }


        private void btinsert_Click(object sender, EventArgs e)
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

            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();

            SqlCommand cmd = new SqlCommand("ADD_PRODUCT", koneksi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idvendor", cbvendor.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@kategori", cbkategori.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@idproduk", txtidproduk.Text);
            cmd.Parameters.AddWithValue("@nama", txtnama.Text);
            cmd.Parameters.AddWithValue("@stok", int.Parse(txtjumlah.Text));
            cmd.Parameters.AddWithValue("@harga", int.Parse(txtharga.Text));
            var result = new SqlParameter("@result", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(result);
            cmd.ExecuteNonQuery();
            if (result.Value.ToString() == "0")
            {

                DialogResult hasil = MessageBox.Show("produk terdaftar . apakah anda ingin update produk ini?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (hasil == DialogResult.Yes)
                {
                    MessageBox.Show("data berhasil di update");
                    showdata();
                    return;
                    
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("data berhasil disimpan");
            }
            koneksi.con.Close();        

            showdata();
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
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from tb_produk where id_produk = @idproduk or nama = @nama", koneksi.con);
            {
                cmd.Parameters.AddWithValue("@idproduk", txtidproduk.Text);
                cmd.Parameters.AddWithValue("@nama", txtnama.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    SqlCommand cmdd = new SqlCommand("UPDATE tb_produk SET nama = @nama, stok = @stok, harga = @harga WHERE id_produk = @id_produk", koneksi.con);
                    cmdd.Parameters.AddWithValue("@nama", txtnama.Text);
                    cmdd.Parameters.AddWithValue("@stok", int.Parse(txtjumlah.Text));
                    cmdd.Parameters.AddWithValue("@harga", int.Parse(txtharga.Text));
                    cmdd.Parameters.AddWithValue("@id_produk", txtidproduk.Text);

                   
                    cmdd.ExecuteNonQuery();
                    koneksi.con.Close();
                    MessageBox.Show("produk berhasil di update");
                    showdata();
                    return;
                }
                else
                {
                    MessageBox.Show("produk tidak ditemukan");
                    return;
                }
            }

        }




        private void btdelete_Click(object sender, EventArgs e)
        {
            if (txtidproduk.Text == "")
            {
                MessageBox.Show("isi id produk yang akan dihapus");
                return;
            }
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            
            SqlCommand cmd = new SqlCommand("select count(*) from tb_produk where id_produk = @idproduk", koneksi.con);
            {
                cmd.Parameters.AddWithValue("@idproduk", txtidproduk.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    
                    SqlCommand cmdd = new SqlCommand("delete  from tb_produk where id_produk = '"+txtidproduk.Text+"'", koneksi.con);
                    cmdd.ExecuteNonQuery();
                    koneksi.con.Close();
                    MessageBox.Show("produk berhasil di hapus");
                    showdata();
                    return;

                }
                else
                {
                    MessageBox.Show("data tidak ditemukan");
                    return;
                }
            }
            

        }


        private void btreset_Click(object sender, EventArgs e)
        {
            reset();
            
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsSymbol(e.KeyChar); ;


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            idproduk();
        }

        private void dgvproduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string value1 = dgvproduk.Rows[e.RowIndex].Cells["id_vendor"].Value.ToString();
            string value2 = dgvproduk.Rows[e.RowIndex].Cells["id_produk"].Value.ToString();
            string value3 = dgvproduk.Rows[e.RowIndex].Cells["nama"].Value.ToString();
            string value4 = dgvproduk.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            string value5 = dgvproduk.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            string value6 = dgvproduk.Rows[e.RowIndex].Cells["harga"].Value.ToString();

            
            cbvendor.Text = value1;
            txtidproduk.Text = value2;
            txtnama.Text= value3;
            cbkategori.Text= value4;
            txtjumlah.Text = value5;
            txtharga.Text=value6;

            // Check if the clicked column is the one you want
            if (e.ColumnIndex == 1) // 0 is the index of the column
            {
                // Get the value of the clicked cell
                string cellValue = dgvproduk.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Set the value of the TextBox
                txtidproduk.Text = cellValue;
            }
        }
    }
}