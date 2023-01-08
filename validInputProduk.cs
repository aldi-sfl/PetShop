using System;
using System.Data.SqlClient;

public class Class1
{
	public Class1()
	{

	}

    /// silahkan ganti data source dan pastikan nama database sama yaitu db_PetShop
    SqlConnection con = new SqlConnection
        (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");

    private bool ValidateCredentialsproduct(int product)
    {
        SqlConnection con = new SqlConnection
        (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");
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

    private bool ValidateCredentialsname(string name)
    {
        SqlConnection con = new SqlConnection
        (@"Data Source=DESKTOP-48CBQ99; Initial Catalog=db_PetShop1;Integrated Security=True");
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

    public static void cekdata()
    {
        int product = int.Parse(txtidproduk.Text);
        string name = txtnama.Text;


        bool productvalid = ValidateCredentialsproduct(product);
        bool namevalid = ValidateCredentialsname(name);

        if (productvalid || namevalid)
        {

            DialogResult result = MessageBox.Show("Id produk atau nama produk sudah terdaftar. apakah anda ingin update?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                con.Open();

                SqlCommand ccmd = new SqlCommand();
                ccmd.Connection = con;
                ccmd.CommandType = CommandType.Text;
                ccmd.CommandText = " update Products set Name = '" + txtnama.Text + "', Price = '" + int.Parse(txtharga.Text) + "', Quantity ='" + int.Parse(txtjumlah.Text) + "' where ProductID = '" + int.Parse(txtidproduk.Text) + "'";

                ccmd.ExecuteNonQuery();

                con.Close();

                showdata();
                reset();


            }
            else
            {
                return;
            }
        }


    }
