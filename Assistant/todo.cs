using System;
using Microsoft.Extensions.Configuration;
class ToDo
{

    private readonly Connection _connection;
    public ToDo(Connection connection)
    {
        _connection = connection;
    }

    public ToDo FuncToDo()
    {
        Console.WriteLine("ADD TODO?\t(y/n)");
        string? todoInput = Console.ReadLine();

        switch (todoInput)
        {
            case "y":
                // AddTodo();
                new ToDo().AddTodo().ToDoDialogue();
                break;
            default:
                Console.WriteLine("nothing happens");
                break;
        }
        return this;
    }

    public ToDo AddTodo(string title, string description, DateTime? dueDate)
    {
        System.Console.WriteLine("you are about to add a todo");
        using (var connection = _connection.CreateConnection())
        {
            if (connection != null)
            {
                connection.Open();
                // Prepare a SQL statement to insert into the database (replace with actual table and columns)
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

        return this;
    }

    public List<TodoItem> GetAllTodos()
    {

    }

    public TodoItem GetTodoById(ind id)
    {

    }
    public void DeleteTodo(int id)
    {

    }

    public ToDo ToDoDialogue()
    {
        // You can add ToDoDialogue logic here
        return this;
    }
}
