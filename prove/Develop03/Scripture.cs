using System;
class Scripture
{
  public string WriteVerse()
  {
    Word txtVerse = new Word();
    string verse = txtVerse.WriteVerse();
    return verse;
  }
  public string WriteReference()
  {
    Reference txtReference = new Reference();
    string reference = txtReference.WriteReference();
    return reference;
  }

  public void HideScripture(string txtRef, string txtVerse)
  {
    string wholeScripture = txtRef + " " + txtVerse;
    string[] words = wholeScripture.Split(' ');
    List<string> newWords = new List<string>();
    string palabra = "";
    int i = 0;
    Random rndNum = new Random();
    int listSize = words.Length;
    int rndIndex = rndNum.Next(0, listSize);
    foreach (string word in words)
    {
      if (i == rndIndex)
      {
        palabra = words[i];
      }

      // Console.WriteLine(words[i]);
      i++;

    }
    foreach (char item in palabra)
    {
      int palabraSize = palabra.Length;
    }
    Console.WriteLine();

  }

  public void DisplayScripture(string txtRef, string txtVerse)
  {
    Console.WriteLine(txtRef + " -> " + txtVerse);

  }

  public bool IsCompletelyHidden()
  {
    return 1 == 2;
  }
}