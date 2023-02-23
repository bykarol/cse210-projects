using System;

class Program
{
  static void Main(string[] args)
  {
    int flag = 4;
    int sessionInSec = 0;
    do
    {
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Start breathing activity");
      Console.WriteLine("2. Start reflecting activity");
      Console.WriteLine("3. Start listing activity");
      Console.WriteLine("4. Quit");
      Console.Write("Select a choice from the menu: ");
      flag = Int32.Parse(Console.ReadLine());

      if (flag == 1)
      {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        sessionInSec = Int32.Parse(Console.ReadLine());
      }
      else if (flag == 2)
      {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        sessionInSec = Int32.Parse(Console.ReadLine());
      }
      else if (flag == 3)
      {
        Console.WriteLine("Welcome to the Listing Activity.");
      }
      else
      {
        Console.WriteLine("Namasté");
      }

    } while (flag != 4);

  }
}