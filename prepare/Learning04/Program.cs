using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Assignments - inheritance");

    Assignment assignment1 = new Assignment("Karol", "Inheritance");
    Console.WriteLine(assignment1.GetSummary());
    Console.WriteLine("Testing GetSummary() and GetHomeworkList() methods (no using parent class getters)");
    MathAssignment assignment2 = new MathAssignment("Roberto Rodríguez", "Fractions", "Section 7.3", "Problems 8-19");
    Console.WriteLine(assignment2.GetSummary()); // Testing GetSummary() from base class
    Console.WriteLine(assignment2.GetHomeworkList()); // Testing GetHomeworkList() from MathAssignment class
    Console.WriteLine("Testing GetWritingInfo() using getters from parent class");
    WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
    Console.WriteLine(assignment3.GetSummary());
    Console.WriteLine(assignment3.GetWritingInfo());
  }
}