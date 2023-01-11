using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Prep4 Lists");
    Console.WriteLine("*******************");

    Console.WriteLine("Enter a a list of numbers, type 0 when finish: ");
    List<int> numbers = new List<int>();
    int number;
    double sum = 0;
    int listSize;
    double average;

    //loop to append the user entries to the List
    do
    {
      Console.Write("Enter a number: ");
      string userEntry = Console.ReadLine();
      number = int.Parse(userEntry);
      numbers.Add(number);

    } while (number != 0);

    //sum of the numbers in the list
    foreach (int n in numbers)
    {
      sum += n;
    }
    Console.WriteLine($"The sum is: {sum}");

    //Average of the numbers of the list
    listSize = numbers.Count() - 1; //-1 because we not count the cero typed to finish the function
    average = sum / listSize;
    Console.WriteLine($"The average is: {average}");




  }
}