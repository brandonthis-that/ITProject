
using Microsoft.Data.Sqlite;

class Connection
{
    readonly string connectionString = "Data Source=assistant.db";

    public SqliteConnection CreateConnection() // Renamed method
    {
        try
        {
            var connection = new SqliteConnection(connectionString);
            return connection;
        }
        catch (SqliteException ex)
        {
            // Handle connection errors here
            Console.WriteLine($"Error creating connection: {ex.Message}");
            return null; // Or throw an exception
        }
    }
}

// Usage in another class
public class MyClass
{
    public void UseConnection()
    {
        var connection = new Connection().CreateConnection(); // Call the renamed method
        if (connection != null)
        {
            connection.Open();
            Console.WriteLine("Connection Open...");
            // Use the connection object here
        }
    }
}
