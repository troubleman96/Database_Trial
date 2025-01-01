using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Define the connection string
        string connectionString = @"Server=TROUBLEMANPC;Database=Database Trial;Trusted_Connection=True;";


        // Define the SQL query
        string query = "SELECT * FROM YourTableName";

        try
        {
            // Create a SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connection established!");

                // Create a SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and read data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming your table has columns: Id and Name
                            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

