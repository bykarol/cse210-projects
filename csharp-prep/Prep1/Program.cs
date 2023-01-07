using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep1 World!");
    Console.WriteLine("************************");

    Console.Write("What is your first name? ");
    string userName = Console.ReadLine();

    Console.Write("What is your last name? ");
    string userLastname = Console.ReadLine();

    Console.WriteLine($"Your name is {userLastname}, {userName} {userLastname}.");
  }
}