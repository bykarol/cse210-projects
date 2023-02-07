class Scripture
{
  public string WriteScripture()
  {
    Prompt prompt = new Prompt();
    string txt = prompt.AskTxt();
    return txt;
  }

  public void HideScripture()
  {

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