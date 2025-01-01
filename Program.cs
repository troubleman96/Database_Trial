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

                // Define the delete query
                string deleteQuery = "DELETE FROM YourTableName WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Parameterized query
                    command.Parameters.AddWithValue("@Id", 3); // Assuming the ID to delete is 3

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) deleted.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}


    
    

   


