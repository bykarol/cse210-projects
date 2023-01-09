using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");
    Console.WriteLine("*************************");
    // Console.Write("What is the magic number? ");
    // string userInput = Console.ReadLine();
    // int magicNum = int.Parse(userInput);
    Random randomGenerator = new Random();
    int magicNum = randomGenerator.Next(1, 11);
    int guessNum;
    int counter = 0;
    do
    {
      Console.Write("What is your guess? ");
      string guessInput = Console.ReadLine();
      guessNum = int.Parse(guessInput);
      counter++;

      if (magicNum == guessNum)
      {
        Console.WriteLine("You guessed it!!");
        Console.WriteLine($"You made {counter} attemps.");
        Console.WriteLine("***********************");
        Console.Write("Do you want to play again? (yes or no) ");
        string playAgain = Console.ReadLine();
        if (playAgain == "yes")
        {
          magicNum = randomGenerator.Next(1, 11);
          counter = 0;
        }
        else
        {
          Console.WriteLine("Come back soon! Bye bye!!");
        }


      }
      else if (magicNum < guessNum)
      {
        Console.WriteLine("Lower");
      }
      else
      {
        Console.WriteLine("Higher");
      }
    } while (magicNum != guessNum);




  }
}