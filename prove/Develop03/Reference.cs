using System;
class Reference
{
  string reference;
  public string WriteReference()
  {
    Prompt prompt = new Prompt();
    prompt.AskReference();
    reference = Console.ReadLine();
    return reference;
  }

  public void DisplayReference(string txt)
  {
    Console.WriteLine(txt);
  }


}