using System;
using Microsoft.Extensions.Configuration;

class ToDo
{

    private readonly Connection _connection;
    public ToDo(Connection connection)
    {
        _connection = connection;
    }

    public void FuncToDo() // No return needed
    {
        Console.WriteLine("ADD TODO?\t(y/n)");
        string? todoInput = Console.ReadLine();

        switch (todoInput)
        {
            case "y":
                    AddTodo(); // Call AddTodo directly
                break;
            default:
                Console.WriteLine("nothing happens");
                break;
        }
    }

    public void AddTodo(string title, string description, DateTime? dueDate) // No return needed
    {
        System.Console.WriteLine("you are about to add a todo");
        using (var connection = _connection.CreateConnection())
        {
            if (connection != null)
            {
                connection.Open();
                // Prepare a SQL statement to insert into the database
                string sql = "INSERT INTO Todos (Title, Description, DueDate) VALUES (@title, @description, @dueDate)";
                var command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);

                if (dueDate.HasValue)
                {
                    command.Parameters.AddWithValue("@dueDate", dueDate.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@dueDate", null); // handle null values
                }

                command.ExecuteNonQuery(); // Execute the insert statement
            }
        }
    }

    public List<TodoItem> GetAllTodos() // Implement to retrieve all todos
    {
        // Implement logic to retrieve all todos from the database and return them as a List<TodoItem>
        throw new NotImplementedException();
    }

    public TodoItem GetTodoById(int id) // Corrected parameter name
    {
        // Implement logic to retrieve a specific todo by id from the database and return it as a TodoItem
        throw new NotImplementedException();
    }

    public void DeleteTodo(int id) // No return needed
    {
        // Implement logic to delete a todo with the given id from the database
        throw new NotImplementedException();
    }

    public void ToDoDialogue() // No return needed, implement logic here
    {
        // You can add ToDoDialogue logic here, potentially for user interaction related to modifying existing todos
    }
}
