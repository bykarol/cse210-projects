using System;
class Reference
{
  string reference;
  public void WriteReference()
  {
    Prompt prompt = new Prompt();
    prompt.AskReference();
    reference = Console.ReadLine();
  }

  public void DisplayReference(string txt)
  {
    Console.WriteLine(txt);
  }


}