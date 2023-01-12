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
    public partial class dgv : Form
    {
        public dgv()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-PEPU3AA; Initial Catalog=db_PetShop1;Integrated Security=True");
        private void DisplayCustomers()
        {
            con.Open();
            string Query = "Select * from Customers";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Clear()
        {
            txtalamat.Text = "";
            txtemail.Text = "";
            txtnama.Text = "";
            txtnomor.Text = "";
            txtpassword.Text = "";
            txtusername.Text = "";
        }
        //private void showdata()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from Customers  ";
        //    DataSet ds = new DataSet();


        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds, "Customers");

        //    dgvUser.DataSource = ds;

        //    dgvUser.DataMember = "Customers";

        //    dgvUser.ReadOnly = true;


        //}


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataUser_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Halaman_Utama_Admin halaman_Utama_Admin = new Halaman_Utama_Admin();
            halaman_Utama_Admin.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtnama.Text == "" || txtnomor.Text == "" || txtalamat.Text == "" ||txtpassword.Text =="" || txtemail.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Costumers (username,password,name,phonenumber,email,address) values(@username,@password,@name,@phonenumber,@email,@address)");
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@name", txtnama.Text);
                    cmd.Parameters.AddWithValue("@phonenumber", txtnomor.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@address", txtalamat.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Berhasil Ditambah");
                    con.Close();
                    DisplayCustomers();
                    Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtusername.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtpassword.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtnama.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
            txtnomor.Text = dgvUser.SelectedRows[0].Cells[4].Value.ToString();
            txtemail.Text = dgvUser.SelectedRows[0].Cells[5].Value.ToString();
            txtalamat.Text = dgvUser.SelectedRows[0].Cells[6].Value.ToString();
            if (txtusername.Text == "")
            {
                Key = 0;   
            }
            else
            {
                Key = Convert.ToInt32(dgvUser.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
