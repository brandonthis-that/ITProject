using System;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

public class Connection
{
    private readonly string _dbPath;
    private readonly IConfiguration _configuration;

    public Connection(IConfiguration configuration)
    {
        _dbPath = "assistant.db";
        _configuration = configuration;
    }

    public SqliteConnection CreateConnection() // Renamed method
    {
        try
        {
            var connection = new SqliteConnection(_configuration.GetConnectionString("DefaultConnection"));
            return connection;
        }
        catch (SqliteException ex)
        {
            // Handle connection errors here
            Console.WriteLine($"Error creating connection: {ex.Message}");
            return null;
        }
    }
}

// Usage in another class
public class MyClass
{
    public void UseConnection()
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connection = new Connection(configuration).CreateConnection(); // Call the renamed method
        if (connection != null)
        {
            connection.Open();
            Console.WriteLine("Connection Open...");
            // Use the connection object here
        }
    }
}


public class ConnectionData
{

}
