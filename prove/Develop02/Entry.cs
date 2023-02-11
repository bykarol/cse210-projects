using System;

public class Entry
{
  public string _userInput;
  public string _date;
  public string _question;
  public void DisplayEntry()
  {
    if (String.IsNullOrEmpty(_userInput))
    {
      Console.WriteLine("*************************************************");
      Console.WriteLine("Write an entry first or load your journal.");
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