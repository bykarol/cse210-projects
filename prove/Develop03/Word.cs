using System;
class Word
{
  string verse;
  public string WriteVerse()
  {
    Prompt prompt = new Prompt();
    prompt.AskVerse();
    verse = Console.ReadLine();
    return verse;
  }
  public void DisplayVerse(string txt)
  {
    Console.WriteLine(txt);
  }


}