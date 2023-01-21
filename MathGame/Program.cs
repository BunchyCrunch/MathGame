// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

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

if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected");
} 
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Subtraction game selected");
} 
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid input");
}

