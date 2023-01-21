// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Menu(name, date);

void AdditionGame(string message)
{
    Console.WriteLine("Addition game selected");
}
void SubtractionGame(string message)
{
    Console.WriteLine("Subtraction game selected");
}
void MultiplicationGame(string message)
{
    Console.WriteLine("Multiplication game selected");
}
void DivisionGame(string message)
{
    Console.WriteLine("Division game selected");
}

void Menu(string? name, DateTime date)
{
    Console.WriteLine("---------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine($@"What game would yo like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("---------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }
}