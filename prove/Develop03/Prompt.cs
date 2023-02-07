class Prompt
{
  public string verse;
  public string reference;

  public string AskTxt()
  {
    Console.WriteLine("Text the verse without the reference:");
    verse = Console.ReadLine();
    Console.WriteLine("Enter the reference:");
    reference = Console.ReadLine();
    return reference + " " + verse;
  }

}