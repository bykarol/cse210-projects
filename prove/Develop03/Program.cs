using System;

class Program
{
  static void Main(string[] args)
  {
    string flag = "";
    Console.WriteLine("Welcome to the Scripture Memorizer!");
    Scripture txt = new Scripture();
    string verse = txt.WriteScripture();
    Console.Clear();
    do
    {
      txt.DisplayScripture(verse);
      Console.WriteLine("Press enter to continue or type 'quit' to finish:");
      flag = Console.ReadLine();
      ConsoleKeyInfo key = Console.ReadKey();
      if (Console.ReadKey().Key == ConsoleKey.Enter)
      {
        txt.HideScripture(verse);
      }

    } while (flag != "quit");
    Console.WriteLine("See you soon!!");

  }
}