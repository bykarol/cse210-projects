using System;
class ListingActivity : Activity
{
  List<string> scenarios = new List<string>()
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    };
  public ListingActivity(string activity, string description) : base(activity, description)
  { }

  public void runListingActivity(int duration)
  {
    Console.WriteLine();
    string scenario = base.randomPrompt(scenarios);
    Console.WriteLine("List as many responses you can to the following prompt:");
    Console.WriteLine("——" + scenario + "——");
    Console.Write("You may begin in:");
    base.displayHoldAnimation();
    Console.WriteLine();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    if (startTime < endTime)
    {
      while (DateTime.Now < endTime)
      {
        Console.Write("> ");
        Console.ReadLine();
      }
    }

  }
}