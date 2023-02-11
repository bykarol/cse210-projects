using System;
class Scripture
{

  public void DisplayWholeScripture(string txtRef, string txtVerse)
  {
    Console.WriteLine(txtRef + "->" + txtVerse);
  }

  public int RandomNumber(int scriptureSize)
  {
    Random rndNum = new Random();
    int rndIndex = rndNum.Next(0, scriptureSize);
    return rndIndex;
  }

  public string[] HideScripture(string txtRef, string txtVerse)
  {
    string wholeScripture = txtRef + " " + txtVerse;
    string[] words = wholeScripture.Split(' ');
    int listSize = words.Length;
    int rndIndex = RandomNumber(listSize);
    List<string> newStringWithHiddenWords = new List<string>();

    for (int i = 0; i < listSize; i++)
    {
      words[i] = new string('*', words[i].Length);
    }
    return words;
  }

  public void hiddenWordsScripture(string[] hiddenWordsScripture)
  {
    Console.WriteLine(hiddenWordsScripture);
  }

  public bool IsCompletelyHidden()
  {
    return 1 == 2;
  }
}