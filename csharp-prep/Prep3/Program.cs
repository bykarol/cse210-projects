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

      if (magicNum == guessNum)
      {
        Console.WriteLine("You guessed it!!");
      }
      else if (magicNum < guessNum)
      {
        Console.WriteLine("Lower");
      }
      else
      {
        Console.WriteLine("Higher");
      }
      counter++;
    } while (magicNum != guessNum);
    Console.WriteLine($"You made {counter} attemps.");



  }
}