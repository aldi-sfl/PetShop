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
using PetShop.class_class;

namespace PetShop
{
    public partial class DataUser : Form
    {


        public DataUser()
        {
            InitializeComponent();
            SqlConnection con = koneksi.con;
            if (con.State == ConnectionState.Open)
                con.Close();
        }

       
       
       

        private void DataUser_Load(object sender, EventArgs e)
        {

        }

       

    }
}
    
