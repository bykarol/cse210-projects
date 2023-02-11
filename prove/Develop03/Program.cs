using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Scripture Memorizer!");
    Scripture txt = new Scripture();
    string verse = txt.WriteVerse();
    string reference = txt.WriteReference();
    Console.Clear();
    txt.DisplayScripture(reference, verse);
    bool flag = true;
    while (flag)
    {
      Console.WriteLine("Press enter to continue or type 'q' to finish:");
      ConsoleKeyInfo key = Console.ReadKey();
      // flag = Console.ReadLine();
      // if (Console.ReadKey().Key == ConsoleKey.Enter)
      if (key.Key == ConsoleKey.Enter)
      {
        Console.Clear();
        txt.HideScripture(reference, verse);
      }
      else if (key.Key == ConsoleKey.Q)
      {
        flag = false;
        Console.WriteLine();
      }
      else
      {
        Console.WriteLine();
        Console.WriteLine("Command not value.");
      }
    }
    Console.WriteLine("See you soon!!!");
  }
}