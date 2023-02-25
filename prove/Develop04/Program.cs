using System;

class Program
{
  static void Main(string[] args)
  {
    int duration = 0;
    int flag = 4;
    do
    {
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1. Start breathing activity");
      Console.WriteLine("2. Start reflecting activity");
      Console.WriteLine("3. Start listing activity");
      Console.WriteLine("4. Quit");
      Console.Write("Select a choice from the menu: ");
      flag = int.Parse(Console.ReadLine());

      if (flag == 1)
      {
        BreathingActivity actv1 = new BreathingActivity("Breathing Activity.", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        duration = actv1.displayStartingMessage();
        Console.WriteLine("Get Ready...");
        actv1.displayHoldAnimation();
        actv1.runBreathingActivity(duration);
        Console.Clear();
        actv1.displayFinalMessage(duration);

      }
      else if (flag == 2)
      {
        ReflectingActivity actv2 = new ReflectingActivity("Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        duration = actv2.displayStartingMessage();
        Console.WriteLine("Get Ready...");
        actv2.displayHoldAnimation();
        actv2.runReflectingActivity(duration);
        Console.Clear();
        actv2.displayFinalMessage(duration);
      }
      else if (flag == 3)
      {
        ListingActivity actv3 = new ListingActivity("Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        duration = actv3.displayStartingMessage();
        Console.WriteLine("Get Ready...");
        actv3.displayHoldAnimation();
        actv3.runListingActivity(duration);
        Console.Clear();
        actv3.displayFinalMessage(duration);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Namasté!");
      }

    } while (flag != 4);

  }
}