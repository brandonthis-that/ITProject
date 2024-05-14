using System;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string message = "Hello world!";
        Console.SetCursorPosition((Console.WindowWidth - message.Length) / 2, Console.CursorTop);
        Console.WriteLine(message);
        Console.WriteLine("Press enter to continue: ");
        Console.ReadLine();

        Route();
    }

    void ConnectionString()
    {

    }


    public static void Route()
    {
        Console.Clear();
        Console.WriteLine("====== MENU ======");
        Console.WriteLine("1. Home");
        Console.WriteLine("2. ToDo");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                new HomePage().Display();
                break;
            case "2":
                new ToDo().FuncToDo();
                break;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }

    }
}

