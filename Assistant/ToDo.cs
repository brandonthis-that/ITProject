class ToDo
{
    public ToDo FuncToDo()
    {
        Console.WriteLine("ADD TODO?\t(y/n)");
        string? todoInput = Console.ReadLine();

        switch (todoInput)
        {
            case "y":
                AddTodo();
                break;
            default:
                System.Console.WriteLine("nothing happens");
                break;
        }
        return this;
    }

    public ToDo AddTodo()
    {
        System.Console.WriteLine("you are about to add a todo");





        
        return this;
    }
     public ToDo ToDoDialogue()
    {
        // You can add ToDoDialogue logic here
        return this;
    }
}
