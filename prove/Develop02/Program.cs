using System;

class Program
{
  static void Main(string[] args)
  {
    bool flag = true;
    int menuNum;
    Prompt prompt = new Prompt();
    Entry userEntry = new Entry();
    Journal journal = new Journal();
    Console.WriteLine("Welcome to your Journal!");

    do
    {
      Console.WriteLine("What do you want to do?");
      Console.WriteLine("1 - Write");
      Console.WriteLine("2 - Display");
      Console.WriteLine("0 - Quit");
      Console.Write("write a number: ");
      menuNum = int.Parse(Console.ReadLine());

      if (menuNum == 1)
      {
        // journal.WriteEntry();
        userEntry._question = prompt.PromptGenerator();
        prompt.DisplayPrompt();
        userEntry._userInput = Console.ReadLine();
      }
      else if (menuNum == 2)
      {
        // journal.ReadEntries();
        userEntry.DisplayEntry();
      }
      else
      {
        Console.WriteLine("Come back soon!!");
        flag = false;
      }

    } while (flag == true);





  }
}