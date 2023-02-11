using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Scripture Memorizer");
    Scripture scripture = new Scripture();
    Word userVerse = new Word();
    Reference userReference = new Reference();
    string txtVerse = userVerse.WriteVerse();
    string txtReference = userReference.WriteReference();
    scripture.DisplayWholeScripture(txtReference, txtVerse);
    string flag = "";

    while (flag != "quit")
    {
      Console.WriteLine("Press enter to continue or type 'quit' to finish:");
      flag = Console.ReadLine();
      Console.Clear();
      scripture.HideScripture(txtReference, txtVerse);
    }
    Console.WriteLine("Come back soon!!");


  }
}