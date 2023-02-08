class Scripture
{
  public string WriteScripture()
  {
    Prompt prompt = new Prompt();
    string txt = prompt.AskTxt();
    return txt;
  }

  public void HideScripture(string txt)
  {
    Random rndNum = new Random();
    int txtSize = txt.Length;
    int rndIndex = rndNum.Next(0, txtSize);
    // falta escribir el algoritmo que me esconda las palabras

  }

  public void DisplayScripture(string verse)
  {
    Console.WriteLine(verse);

  }

  public bool IsCompletelyHidden()
  {
    return 1 == 2;
  }

}