using System;
using System.Collections.Generic;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  Entry userEntry = new Entry();
  Prompt prompt = new Prompt();
  // Entry entry = new Entry();
  // DateTime date = DateTime.Now;
  // string author = "";


  public void WriteEntry()
  {
    userEntry._question = prompt.PromptGenerator();
    prompt.DisplayPrompt();
    userEntry._userInput = Console.ReadLine();
    this.AddEntry(userEntry);
  }

  public void AddEntry(Entry input)
  {
    entries.Add(input);
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