using System;
using System.Collections.Generic;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  Prompt prompt = new Prompt();
  // DateTime date = DateTime.Now;
  // string author = "";


  public void WriteEntry()
  {
    Entry userEntry = new Entry();
    userEntry._question = prompt.PromptGenerator();
    prompt.DisplayPrompt();
    userEntry._userInput = Console.ReadLine();
    // AddEntry(userEntry);
    entries.Add(userEntry);
  }

  public void AddEntry()
  {

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