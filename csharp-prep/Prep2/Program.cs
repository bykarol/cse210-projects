using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Prep2 Conditional");
    Console.WriteLine("*******************");

    Console.Write("Please write your grade percent: ");
    string userInput = Console.ReadLine();
    int percent = int.Parse(userInput);
    string letterGrade = "";
    string sign;
    int lastNum = percent % 10; //to know the last number I divide the percent by 10 and get the remainder

    //Evaluating and assigning the correspondant letter
    if (percent >= 90 && percent <= 100)
    {
      letterGrade = "A";
    }
    else if (percent >= 80 && percent < 90)
    {
      letterGrade = "B";
    }
    else if (percent >= 70 && percent < 80)
    {
      letterGrade = "C";
    }
    else if (percent >= 60 && percent < 70)
    {
      letterGrade = "D";
    }
    else if (percent >= 0 && percent < 60)
    {
      letterGrade = "F";
    }
    else
    {
      Console.WriteLine("Please enter a value between 00 and 100");
    }

    //Assigning the sign +, - or nothing
    if (percent > 60 && lastNum >= 7 || percent == 100)
    {
      sign = "+";
    }
    else if (percent > 60 && lastNum < 3)
    {
      sign = "-";
    }
    else
    {
      sign = "";
    }

    //Printing the letter grade plus the correspondant sign
    if (percent >= 0 && percent <= 100)
    {
      Console.WriteLine($"Your letter grade is {letterGrade}{sign}");
    }

    //Evaluating if it is approve or not and printing the result
    if (percent >= 70 && percent <= 100)
    {
      Console.WriteLine("Congratulations!! You are approved.");
    }
    else if (percent >= 0 && percent < 101)
    {
      Console.WriteLine("Not for now, keep trying. You will get it!!!");
    }


  }
}