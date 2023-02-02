using System;
using System.Collections.Generic;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  Entry entry = new Entry();
  Prompt prompt = new Prompt();
  DateTime date = DateTime.Now;
  // string author = "";


  public void WriteEntry(Entry userEntry)
  {
    // entries.Add(userEntry);
    prompt.PromptGenerator();
    prompt.DisplayPrompt();
    entry._userInput = Console.ReadLine();
  }

  public void ReadEntry()
  {
    entries.Add(entry);
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