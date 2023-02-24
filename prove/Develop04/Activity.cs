using System;

class Activity
{
  public int duration;
  protected string description;
  protected string activityName;
  // private int _initialPauseDurationSec;
  // private int _finalPauseDurationSec;
  // private string _endingMessage;

  public Activity(string name, string description)
  {
    this.activityName = name;
    this.description = description;
  }

  public int DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine("Welcome to the " + activityName);
    Console.WriteLine();
    Console.WriteLine(description);
    Console.WriteLine();
    Console.WriteLine("How long, in seconds, would you like for your session?");
    duration = int.Parse(Console.ReadLine());
    return duration;
  }

  public void displayHoldAnimation()
  {
    string[] characters = new String[4] { "|", "/", "—", "\\" };
    Console.WriteLine("Get Ready...");
    for (int j = 0; j < 3; j++)
    {
      for (int i = 0; i < characters.Length; i++)
      {
        Console.Write(characters[i]);
        Thread.Sleep(600);
        Console.Write("\b \b"); // Erase the | character
      }
    }

  }


}