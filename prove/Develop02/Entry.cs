using System;

public class Entry
{
  public string _userInput;
  public DateTime _date = DateTime.Now;
  public string _question;
  public void DisplayEntry()
  {
    if (String.IsNullOrEmpty(_userInput))
    {
      Console.WriteLine("*************************************************");
      Console.WriteLine("Write an empty first or load your journal.");
      Console.WriteLine("*************************************************");

    }
    else
    {
      Console.WriteLine("*************************************************");
      Console.WriteLine($"{_date} - {_question}");
      Console.WriteLine($"{_userInput}");
      Console.WriteLine("*************************************************");
    }

  }
}