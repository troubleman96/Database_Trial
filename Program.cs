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

                // Define the update query
                string updateQuery = "UPDATE YourTableName SET Name = @NewName WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Parameterized query
                    command.Parameters.AddWithValue("@NewName", "Eve");
                    command.Parameters.AddWithValue("@Id", 2); // Assuming the ID to update is 2

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}


    
    

   


