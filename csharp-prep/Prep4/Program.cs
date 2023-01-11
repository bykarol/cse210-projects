using System;
using System.Linq; //library that contain math functions

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Prep4 Lists");
    Console.WriteLine("*******************");

    Console.WriteLine("Enter a a list of numbers, type 0 when finish: ");
    List<int> numbers = new List<int>();
    int number;
    int sum = 0;
    double listSize;
    double average;

    //loop to append the user entries to the List
    do
    {
      Console.Write("Enter a number: ");
      string userEntry = Console.ReadLine();
      number = int.Parse(userEntry);
      if (number != 0)
      {
        numbers.Add(number);
      }

    } while (number != 0);

    //sum of the numbers in the list
    foreach (int n in numbers)
    {
      sum += n;
    }
    // //SUM USING sum() function from LINQ LIBRARY
    // sum = numbers.Sum();
    Console.WriteLine($"The sum is: {sum}");

    //Average of the numbers in the list

    //Average of the numbers of the list using the Linq library
    listSize = numbers.Count();
    average = sum / listSize;
    // average = Queryable.Average(numbers.AsQueryable());
    Console.WriteLine($"The average is: {average}");

    //Finding the largest number
    int maxNum = 0;

    for (int i = 0; i < listSize; i++)
    {
      int num1 = numbers[i];
      if (maxNum < num1)
      {
        maxNum = num1;
      }
    }
    //Finding the largest number with Linq Library
    // largestNum = numbers.Max();
    Console.WriteLine($"The largest num is: {maxNum}");
  }
}