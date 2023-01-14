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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PetShop
{
    public partial class register : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

        public register()
        {
            InitializeComponent();
            
            
        }

        

        private void register_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-48CBQ99;Initial Catalog=db_PetShop1;Integrated Security=True");
            con.Open();
            txtpassword.UseSystemPasswordChar = true;
            txtconfirmpassword.UseSystemPasswordChar = true;
        }


        private void btrng_Click(object sender, EventArgs e)
        {
           
        }



        private void btsave_Click(object sender, EventArgs e)
        {

            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty || txtemail.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    cmd = new SqlCommand("select * from Customers where username='" + txtusername.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username sudah ada silahkan coba yang lain ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (dr.Read())
                    //{
                    //    dr.Close();
                    //    MessageBox.Show("Email sudah ada silahkan coba yang lain ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    else if (!reg.IsMatch(txtemail.Text))
                    {
                        dr.Close();
                        MessageBox.Show("Email harus berupa alamat email yang valid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(txtpassword.Text, @"[A-Z]") || !Regex.IsMatch(txtpassword.Text, @"\d"))
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
                        cmd = new SqlCommand("insert into Customers values(@username,@password,@name,@phonenumber,@email,@address)", con);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.Parameters.AddWithValue("name", txtnama.Text);
                        cmd.Parameters.AddWithValue("phonenumber", txthp.Text);
                        cmd.Parameters.AddWithValue("email", txtemail.Text);
                        cmd.Parameters.AddWithValue("address", txtalamat.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Akun Anda telah dibuat. Silakan masuk sekarang.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 balik = new Form1();
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
            Form1 registrationForm = new Form1();
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

        private void txthp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
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
    }
}
