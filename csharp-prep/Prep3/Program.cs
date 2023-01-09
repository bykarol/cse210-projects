using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep3 World!");
    Console.WriteLine("*************************");
    Console.Write("What is the magic number? ");
    string userInput = Console.ReadLine();
    int magicNum = int.Parse(userInput);
    int guessNum;
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
    } while (magicNum != guessNum);



  }
}