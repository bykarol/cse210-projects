using System;
class Prompt
{
  private string promptQuestion = "Type the verse without the reference:";
  private string promptReference = "Enter the reference:";

  public void AskVerse()
  {
    Console.WriteLine(promptQuestion);
  }

  public void AskReference()
  {
    Console.WriteLine(promptReference);
  }

}