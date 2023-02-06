using System;

public class Prompt
{
  List<string> questions = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
  };
  // //method that can add to the list a new prompt from user
  // public void AddPrompt(string userInput)
  string prompt;
  // {
  //   questions.Add(userInput);
  // }

  public string DisplayQuestion()
  {
    Random rndNum = new Random();
    int listSize = questions.Count;
    int rndIndex = rndNum.Next(0, listSize);
    prompt = questions[rndIndex];
    Console.WriteLine(prompt);
    return prompt;
  }

  public string PromptDate()
  {
    Console.Write("Fecha: ");
    string date = Console.ReadLine();
    return date;
  }

}