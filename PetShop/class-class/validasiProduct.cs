using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.class_class
{
    internal class validasiProduct
    {

        public static bool ValidateCredentialsproduct(int product)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop2;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM Products WHERE ProductID = @product";
                SqlCommand command = new SqlCommand(query, con);
                {
                    command.Parameters.AddWithValue("@product", product);

                }
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public static bool ValidateCredentialsname(string name)
        {
            SqlConnection con = new SqlConnection
            (@"Data Source=LAPTOP-D2PPFK1M; Initial Catalog=db_PetShop2;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM Products WHERE  Name = @name";
                SqlCommand command = new SqlCommand(query, con);
                {

                    command.Parameters.AddWithValue("@name", name);
                }
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    }


}
