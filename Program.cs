using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Define the connection string
        string connectionString = @"Server=TROUBLEMANPC;Database=Database Trial;Trusted_Connection=True;";


        

       try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connection established!");

                // Define the insert query
                string insertQuery = "INSERT INTO YourTableName (Name) VALUES (@Name)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Parameterized query to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", "David");

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}


    
    

   


