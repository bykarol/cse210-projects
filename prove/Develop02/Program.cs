using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");

    Prompt prompt = new Prompt();
    Entry userEntry = new Entry();
    userEntry._question = prompt.PromptGenerator();
    prompt.DisplayPrompt();
    userEntry._userInput = Console.ReadLine();
    Console.WriteLine();
    userEntry.DisplayEntry();
  }
}