// See https://aka.ms/new-console-template for more information


var date = DateTime.UtcNow;

var name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void AdditionGame(string message)
{
    Console.WriteLine("Addition game selected");

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for(int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if(int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        } 
        else 
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}.");
    }


}
void SubtractionGame(string message)
{
    Console.WriteLine("Subtraction game selected");

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}.");
    }
}
void MultiplicationGame(string message)
{
    Console.WriteLine("Multiplication game selected");

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}.");
    }
}
void DivisionGame(string message)
{
    Console.WriteLine("Division game selected");

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect.");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}.");
    }
}

void Menu(string name)
{
    Console.WriteLine("---------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game\n");
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