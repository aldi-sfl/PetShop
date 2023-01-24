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
using System.Data.Linq;
using System.Text.RegularExpressions;
using PetShop.class_class;
using System.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;




namespace PetShop
{
    public partial class register : Form
    {
        SqlCommand cmd;
        //SqlConnection con;
        SqlDataReader dr;
        Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

        public register()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();


        }

        

        private void register_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(@"Data Source=LAPTOP-D2PPFK1M;Initial Catalog=petshop;Integrated Security=True");
            //con.Open();
            koneksi.con.Open();
            txtPassword.UseSystemPasswordChar = true;
            txtconfirmpassword.UseSystemPasswordChar = true;
            txtID.Focus();
        }


        private void btrng_Click(object sender, EventArgs e)
        {
           
        }



        private void btsave_Click(object sender, EventArgs e)
        {

            if (txtID.Text != string.Empty || txtnama.Text != string.Empty || txtRole.Text != string.Empty || txtPassword.Text != string.Empty || txtconfirmpassword.Text != string.Empty )
            {
                if (txtPassword.Text == txtconfirmpassword.Text)
                {
                    cmd = new SqlCommand("select * from admin where nama='" + txtnama.Text + "'", koneksi.con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("nama sudah ada silahkan coba yang lain ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    else if (!Regex.IsMatch(txtPassword.Text, @"[A-Z]") || !Regex.IsMatch(txtPassword.Text, @"\d"))
                    {
                        dr.Close();
                        MessageBox.Show("Kata Sandi Harus Mengandung setidaknya satu huruf besar atau satu angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(txtnama.Text, @"^[a-zA-Z]+$"))
                    {
                        dr.Close();
                        MessageBox.Show("Nama harus berupa huruf ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into admin values(@id_admin,@nama,@Role,@password)", koneksi.con);

                        cmd.Parameters.AddWithValue("id_admin", txtID.Text);
                        cmd.Parameters.AddWithValue("nama", txtnama.Text);
                        cmd.Parameters.AddWithValue("Role", txtRole.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        
                      
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Akun Anda telah dibuat. Silakan masuk sekarang.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login_admin balik = new login_admin();
                        balik.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Silakan masukkan kedua kata sandi yang sama ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("\"Tolong isi semua kolom.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



            

        }

        private void btcanccel_Click(object sender, EventArgs e)
        {
            login_admin registrationForm = new login_admin();
            registrationForm.Show();
            this.Hide();

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtconfirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtconfirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
