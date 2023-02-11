using System;
class Word
{
  string verse;
  public void WriteVerse()
  {
    Prompt prompt = new Prompt();
    prompt.AskVerse();
    verse = Console.ReadLine();
  }
  public void DisplayVerse(string txt)
  {
    Console.WriteLine(txt);
  }


}