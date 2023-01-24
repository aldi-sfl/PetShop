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
    public partial class input_hewan : Form
    {
        public input_hewan()
        {
            InitializeComponent();
        }

        private void input_hewan_Load(object sender, EventArgs e)
        {
            showdata();
            vendorname();
            idhewan();
        }

        private void resetdata()
        {
            txtcari.Text = "";
            txtharga.Text = "";
            txtidhewan.Text = "";
            txtjumlah.Text = "";
            cbgender.SelectedIndex = 0;
            cbvendor.SelectedIndex = 0;
            cbhewan.SelectedIndex = 0;
            
            showdata();
        }

        private void showdata()
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();
            SqlDataAdapter tampildata = new SqlDataAdapter("select * from tb_hewan", koneksi.con);
            DataTable datatabel = new DataTable();
            tampildata.Fill(datatabel);
            dgvhewan.DataSource = datatabel;
            dgvhewan.ReadOnly = true;


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

        private void idhewan()
        {
            Random rand = new Random();
            int num = rand.Next(1000, 9999);

            if (cbhewan.SelectedItem == "Burung")
            {
                string id = "BR-" + num;
                txtidhewan.Text = id;
            }
            else if (cbhewan.SelectedItem == "Kucing")
            {
                string id = "KC-" + num;
                txtidhewan.Text = id;
            }
            else if (cbhewan.SelectedItem == "Anjing")
            {
                string id = "AJ-" + num;
                txtidhewan.Text = id;
            }
            else if (cbhewan.SelectedItem == "Kelinci")
            {
                string id = "KL-" + num;
                txtidhewan.Text = id;
            }
            else if (cbhewan.SelectedItem == "Hamster")
            {
                string id = "HM-" + num;
                txtidhewan.Text = id;
            }
            else
            {
                txtidhewan.Text = "-";
            }
        }

        private void btinsert_Click(object sender, EventArgs e)
        {
            if (txtidhewan.Text == "")
            {
                MessageBox.Show("id harus diisi.");
                return;
            }

            if (txtjumlah.Text == "")
            {
                MessageBox.Show("nama harus diisi.");
                return;
            }

            if (txtharga.Text == "")
            {
                MessageBox.Show("jumlah harus diisi.");
                return;
            }

            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();

            koneksi.con.Open();
            SqlCommand cmd = new SqlCommand("ADD_HEWAN", koneksi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@idhewan", txtidhewan.Text);
            cmd.Parameters.AddWithValue("@idvendor", cbvendor.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@jenishewan", cbhewan.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@gender", cbgender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@stokhewan", int.Parse(txtjumlah.Text));
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
                showdata();
            }
            koneksi.con.Close();
        }

        private void cbhewan_SelectedIndexChanged(object sender, EventArgs e)
        {
            idhewan();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            if (txtidhewan.Text == "")
            {
                MessageBox.Show("id harus diisi.");
                return;
            }

            if (txtjumlah.Text == "")
            {
                MessageBox.Show("nama harus diisi.");
                return;
            }

            if (txtharga.Text == "")
            {
                MessageBox.Show("jumlah harus diisi.");
                return;
            }

            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from tb_hewan where id_hewan = @idhewan ", koneksi.con);
            {
                cmd.Parameters.AddWithValue("@idhewan", txtidhewan.Text);
                
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    SqlCommand cmdd = new SqlCommand("UPDATE tb_hewan SET stok_hewan = @stokhewan, harga = @harga WHERE id_hewan = @idhewan", koneksi.con);

                    cmdd.Parameters.AddWithValue("@idhewan", txtidhewan.Text);
                    cmdd.Parameters.AddWithValue("@stokhewan", int.Parse(txtjumlah.Text));
                    cmdd.Parameters.AddWithValue("@harga", int.Parse(txtharga.Text));
                    


                    cmdd.ExecuteNonQuery();
                    koneksi.con.Close();
                    MessageBox.Show("produk hewan berhasil di update");
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

        private void dgvhewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string value1 = dgvhewan.Rows[e.RowIndex].Cells["id_hewan"].Value.ToString();
            string value2 = dgvhewan.Rows[e.RowIndex].Cells["id_vendor"].Value.ToString();
            string value3 = dgvhewan.Rows[e.RowIndex].Cells["jenis_hewan"].Value.ToString();
            string value4 = dgvhewan.Rows[e.RowIndex].Cells["gender"].Value.ToString();
            string value5 = dgvhewan.Rows[e.RowIndex].Cells["stok_hewan"].Value.ToString();
            string value6 = dgvhewan.Rows[e.RowIndex].Cells["harga"].Value.ToString();


            txtidhewan.Text = value1;
            cbvendor.Text = value2;
            cbhewan.Text = value3;
            cbgender.Text = value4;
            txtjumlah.Text = value5;
            txtharga.Text = value6;

            // Check if the clicked column is the one you want
            if (e.ColumnIndex == 1) // 0 is the index of the column
            {
                // Get the value of the clicked cell
                string cellValue = dgvhewan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Set the value of the TextBox
                dgvhewan.Text = cellValue;
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
            koneksi.con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from tb_hewan where id_hewan = @idhewan", koneksi.con);
            {
                cmd.Parameters.AddWithValue("@idhewan", txtidhewan.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {

                    SqlCommand cmdd = new SqlCommand("delete  from tb_hewan where id_hewan = '" + txtidhewan.Text + "'", koneksi.con);
                    cmdd.ExecuteNonQuery();
                    koneksi.con.Close();
                    MessageBox.Show("data hewan berhasil di hapus");
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
            resetdata();
        }

        private void btcari_Click(object sender, EventArgs e)
        {
            SqlCommand cmda = new SqlCommand();
            cmda.Connection = koneksi.con;
            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "select * from tb_hewan where gender like '%" + txtcari.Text + "%' or jenis_hewan like '%" + txtcari.Text + "%'";

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmda);
            da.Fill(ds, "tb_hewan");

            dgvhewan.DataSource = ds;

            dgvhewan.DataMember = "tb_hewan";

            dgvhewan.ReadOnly = true;
            
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Halaman_Utama_Admin vendor = new Halaman_Utama_Admin();
            vendor.Show();
            this.Hide();

        }
    }
}
