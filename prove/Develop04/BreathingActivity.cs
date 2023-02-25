using System;
class BreathingActivity : Activity
{
  public BreathingActivity(string activity, string description) : base(activity, description)
  { }

  public void runBreathingActivity(int duration)
  {
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    if (startTime < endTime)
    {
      while (DateTime.Now < endTime)
      {
        Console.Write("Breath in...");
        this.countDown(5);
        Console.Write("Now breath out...");
        this.countDown(5);
      }
    }
  }

  public void countDown(int startCount)
  {
    for (int i = startCount; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
    Console.WriteLine();
    Console.WriteLine();
  }
}
