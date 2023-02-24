using System;
class BreathingActivity : Activity
{
  public BreathingActivity(string activity, string description) : base(activity, description)
  { }

  public void runBreathingActivity(int duration)
  {
    // string[] breath = new String[2] { "Breath in...", "Now breath out..." };
    Console.WriteLine();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    Thread.Sleep(3000);
    DateTime currentTime = DateTime.Now;
    if (currentTime < endTime)
    {
      Console.Write("Breath in...");
      Thread.Sleep(5000);
      Console.WriteLine();
      Console.WriteLine("Now breath out...");
      Thread.Sleep(5000);
      Console.WriteLine();
    }
  }

}