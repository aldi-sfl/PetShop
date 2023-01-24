using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.class_class
{
    public static class koneksi
    {

        public static SqlConnection con = new SqlConnection
                (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=petshop;Integrated Security=True");




    }
}
