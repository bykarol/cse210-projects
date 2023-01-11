using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep5 World!");
    Console.WriteLine("************************");

    DisplayMessage();
    string name = PromptUserName();
    int number = PromptUserNumber();
    int squareNum = SquareNumber(number);
    DisplayResult(name, squareNum);
  }

  static void DisplayMessage()
  {
    Console.WriteLine("Welcome to the Program!");
  }
  static string PromptUserName()
  {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
  }
  static int PromptUserNumber()
  {
    Console.Write("Please enter your favorite number: ");
    int favNum = int.Parse(Console.ReadLine());
    return favNum;
  }
  static int SquareNumber(int favNum) //double favNum
  {
    int squareNum = favNum * favNum; //this code is more according to the requirements
    return squareNum;
    // double squareNum = Math.Pow(favNum, 2);
    // int squareNumInt = (int)squareNum;
    // return squareNumInt;
  }
  static void DisplayResult(string name, int num)
  {
    Console.WriteLine($"{name}, the square of your number is {num}");
  }

}