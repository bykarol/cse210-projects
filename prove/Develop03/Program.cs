using System;

class Program
{
  static void Main(string[] args)
  {
    string flag = "";
    Console.WriteLine("Welcome to the Scripture Memorizer!");
    Reference reference = new Reference();
    Word verse = new Word();
    reference.WriteReference();
    verse.WriteVerse();
    while (flag != "quit")
    {
      Console.WriteLine("Press enter to continue or type 'quit' to finish:");
      flag = Console.ReadLine();
      //   Console.Clear();
      string[] newString = txt.HideScripture(reference, verse);
      txt.DisplayScripture(newString);
    }
    Console.WriteLine("See you soon!!!");
  }
}