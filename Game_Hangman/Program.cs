using Game_Hangman;
using System.Text;

HangmanArt hangmanArt = new HangmanArt();

Console.WriteLine(hangmanArt.Logo);

string chosenWord = GetRandomWord();
int lives = 6;

List<char> guessedLetters = new List<char>();

bool isGameDone = false;

while (isGameDone == false)
{
    Console.WriteLine("\n");
    Console.Write("Guess a letter: ");

    char guessedLetter = Convert.ToChar(Console.ReadLine());

    if (chosenWord.Contains(guessedLetter) == true)
    {
        guessedLetters.Add(guessedLetter);
    }
    else
    {
        Console.WriteLine($"You guessed a letter {guessedLetter}, that's not in the word. You lose a life.");
        lives--; // lives = lives - 1;
    }


    StringBuilder displayString = new StringBuilder();

    for (int i = 0; i < chosenWord.Count(); i++)
    {

        if (guessedLetters.Contains(chosenWord[i]))
        {
            displayString.Append(chosenWord[i]);
        }
        else
        {
            displayString.Append("_");
        }
    }

    Console.WriteLine(displayString);

    Console.WriteLine(hangmanArt.Stages[lives]);

    if (lives == 0)
    {
        isGameDone = true;
        Console.WriteLine("You lost!");
    }
    else if (displayString.ToString().Contains("_") == false)
    {
        isGameDone = true;
        Console.WriteLine("You won!");
    }

}



Console.ReadLine();


string GetRandomWord()
{
    List<string> words = new List<string>()
    {
        "elma",
        "uçak",
        "bilgisayar",
        "dolap"
    };

    Random random = new Random();

    string randomWord = words[random.Next(words.Count())];

    return randomWord;
}

