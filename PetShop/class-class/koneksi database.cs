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
                (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop2;Integrated Security=True");




    }
}
