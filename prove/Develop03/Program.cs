using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Scripture Memorizer!");
    Scripture txt = new Scripture();
    string verse = txt.WriteScripture();
    Console.Clear();
    txt.DisplayScripture(verse);

  }
}