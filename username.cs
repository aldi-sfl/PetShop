using System;
using system.Data.SqlClient;

public class Class1
{
    private SqlConnection connection;
    private string connectionString = "Data Source=DESKTOP-48CBQ99;Initial Catalog=db_PetShop1;Integrated Security=True;";
    private string currentUsername;
    public Class1()
	{
        connection = new SqlConnection(connectionString);
    }

    public bool Login(string username, string password)
    {
        try
        {
            connection.Open();

            // Check if username and password match
            string loginQuery = "SELECT COUNT(*) FROM Customers WHERE username = @username AND password = @password";
            SqlCommand loginCommand = new SqlCommand(loginQuery, connection);
            loginCommand.Parameters.AddWithValue("@username", username);
            loginCommand.Parameters.AddWithValue("@password", password);
            int count = (int)loginCommand.ExecuteScalar();

            if (count == 1)
            {
                currentUsername = username;
                Console.WriteLine("Login successful! Welcome, " + currentUsername + ".");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect username or password.");
                return false;
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Error connecting to database: " + ex.Message);
            return false;
        }
        finally
        {
            connection.Close();
        }
    }

    public void ShowCurrentUsername()
    {
        Console.WriteLine("Current username: " + currentUsername);
    }
}
