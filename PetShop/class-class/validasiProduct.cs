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
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=petshop;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM tb_produk WHERE id_produk = @product";
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
            (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=petshop;Integrated Security=True");
            {
                con.Open();

                // Ccek apakah ada  database sudah ada
                string query = "SELECT COUNT(*) FROM tb_produk WHERE  nama = @name";
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
