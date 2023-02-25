using System;
class ReflectingActivity : Activity
{
  List<string> scenarios = new List<string>()
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    };

  List<string> questions = new List<string>()
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?",
    };
  public ReflectingActivity(string activity, string description) : base(activity, description)
  { }
  public void runReflectingActivity(int duration)
  {
    Console.WriteLine();
    string scenario = base.randomPrompt(scenarios);
    Console.Write(scenario);
    base.displayHoldAnimation();
    Console.WriteLine();
    Console.WriteLine();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    if (startTime < endTime)
    {
      while (DateTime.Now < endTime)
      {
        string question = base.randomPrompt(questions);
        Console.Write(question);
        base.displayHoldAnimation();
        Console.WriteLine();
        Console.WriteLine();
      }
    }
  }

}