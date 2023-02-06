using System;
using System.Collections.Generic;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  // DateTime date = DateTime.Now;
  // string author = "";


  public void WriteEntry()
  {
    Prompt prompt = new Prompt();
    Entry userEntry = new Entry();
    userEntry._question = prompt.DisplayQuestion();
    userEntry._userInput = Console.ReadLine();
    userEntry._date = prompt.PromptDate();

    entries.Add(userEntry);
  }

  public void ReadEntry()
  {
    foreach (Entry entry in entries)
    {
      // This calls the Display method in Entry class
      entry.DisplayEntry();
    }

  }

  public void RemoveEntry()
  {

  }



}