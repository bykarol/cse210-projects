using System;

public class Entry
{
  public string _userInput;
  public DateTime _date = DateTime.Now;
  public string _question;
  public void DisplayEntry()
  {
    Console.WriteLine($"{_date} - {_question}");
    Console.WriteLine($"{_userInput}");

  }
}