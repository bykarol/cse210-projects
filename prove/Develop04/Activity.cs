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

  public int displayStartingMessage()
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

  public void displayFinalMessage(int duration)
  {
    Console.WriteLine("Well done!!");
    this.displayHoldAnimation();
    Console.WriteLine();
    Console.WriteLine("You have completed another " + duration + " seconds of the " + activityName);
    this.displayHoldAnimation();
  }


  public void displayHoldAnimation()
  {
    string[] listCharacters = new String[4] { "|", "/", "—", "\\" };
    for (int j = 0; j < 2; j++)
    {
      foreach (string c in listCharacters)
      {
        Console.Write(c);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the | character
      }
    }
  }

  public string randomPrompt(List<string> lists)
  {
    Random rndNum = new Random();
    string prompt;

    int listSize = lists.Count;
    int rndIndex = rndNum.Next(0, listSize);
    prompt = lists[rndIndex];
    return prompt;
  }


}