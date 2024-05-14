class HomePage
{
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Welcome to IT ASSISTANT (MRM)");
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("1. Check connection status");
        Console.WriteLine("2. View database ");
        Console.WriteLine("3. Log in/ Sign up");
        Console.WriteLine("4. Settings");
        Console.WriteLine("5. Log out");
        Console.WriteLine("6. Go back to main menu");

        string? displayInput = Console.ReadLine();

        switch (displayInput)
        {
            case "1":
                Console.WriteLine();
                break;
            case "2":
                Console.WriteLine();
                break;
            case "3":
                Console.WriteLine();
                break;
            case "4":
                Console.WriteLine();
                break;
            case "5":
                Console.WriteLine();
                break;
            case "6":
                Program.Route();
                break;


        }

    }
}

