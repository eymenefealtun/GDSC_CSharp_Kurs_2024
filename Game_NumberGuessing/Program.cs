Random random = new Random();

Console.WriteLine("Welcome to Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 0 and 100!");

int numberToBeGuessed = random.Next(0, 100);
bool isGameDone = false;

while (isGameDone == false)
{

    Console.Write("Guess a number: ");
    string input = Console.ReadLine();
    int guess = Convert.ToInt32(input);

    if (guess < numberToBeGuessed)
    {
        Console.WriteLine("Too low!");
    }
    else if (guess > numberToBeGuessed)
    {
        Console.WriteLine("Too high!");
    }
    else
    {
        Console.WriteLine($"You got it. The answer {numberToBeGuessed}");
        isGameDone = true;
    }

}


Console.ReadLine();