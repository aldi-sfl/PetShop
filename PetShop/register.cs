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

namespace PetShop
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=petshop;Integrated Security=True");

        

        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = con;
            cmd.CommandType= CommandType.Text;
            cmd.CommandText= "insert into tb_user values ('"+ txtnama.Text+"','"+txtpassword.Text+"','"
                +txtalamat.Text+"','"+txthp.Text+"','"+txtemail.Text+"')";
            cmd.ExecuteNonQuery();

            con.Close();

            
        }

        private void btcanccel_Click(object sender, EventArgs e)
        {
            Form1 registrationForm = new Form1();
            registrationForm.Show();
            this.Hide();

        }
    }
}
