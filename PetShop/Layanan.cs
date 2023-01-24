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
    public partial class Layanan : Form
    {
        public Layanan()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();

        }

        private void Layanan_Load(object sender, EventArgs e)
        {
            idPET();
            showcustomerid();
            txtPet.ReadOnly=true;
            
            lblUsername.Text = showusername.username;

        }

        public void showcustomerid()
        {
            koneksi.con.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = koneksi.con;
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select CustomerID from Customers where username='" + lblUsername.Text + "'";
            using (SqlDataReader reader = cmdd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int ID = reader.GetInt32("CustomerID");
                    txtCustomer.Text = ID.ToString();
                    noid.Text = ID.ToString();
                }
            }
            koneksi.con.Close();
        }
        private void idPET()
        {
            Random rng = new Random();

            string id = "";
            for (int i = 0; i < 2; i++)
            {
                int r = rng.Next(0, 30);
                if (r < 26)
                {
                    id += (int)('0' + r);
                }
                else
                {
                    id += (int)('9' + r - 26);
                }
            }
            txtPet.Text = "PET-" + id + "";
        }
        private void btnext_Click(object sender, EventArgs e)


        {
            showcustomerid();
            koneksi.con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = koneksi.con;

            cmd.CommandText = "ADD_PET";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter PetID = new SqlParameter("@PetID", SqlDbType.VarChar);
            SqlParameter Name = new SqlParameter("@Name", SqlDbType.VarChar);
            SqlParameter Breed = new SqlParameter("@Breed", SqlDbType.VarChar);
            SqlParameter CustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);

            PetID.Value = txtPet.Text;
            Name.Value = txtname.Text;
            Breed.Value = txtRas.Text;
            CustomerID.Value = int.Parse(txtCustomer.Text);

            cmd.Parameters.Add(PetID);
            cmd.Parameters.Add(Name);
            cmd.Parameters.Add(Breed);
            cmd.Parameters.Add(CustomerID);
            int cekdata = cmd.ExecuteNonQuery();
            if(cekdata >0 )
            {
                DialogResult result = MessageBox.Show("Apakah data sudab benar", "peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    MessageBox.Show("data berhasil disimpan");
                }
                else
                {
                    return;
                }
            }
            



            koneksi.con.Close();
        }

        private void txtPet_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
    

   
       
