public class Prompt
{
  List<string> prompts = new List<string>()
    {
      "Name of the Goal: ",
      "Brief goal description: ",
      "How many points?: "
    };

  public List<string> DisplayPrompt()
  {
    List<string> userInputs = new List<string>();
    foreach (string prompt in prompts)
    {
      Console.Write(prompt);
      string userIn = Console.ReadLine();
      userInputs.Add(userIn);
    }
    return userInputs;

  }

  public int TimesComplete()
  {
    Console.Write("How many times need to be acomplished for this bonus?: ");
    int userIn = int.Parse(Console.ReadLine());
    return userIn;
  }

  public int BonusTime()
  {
    Console.Write("How many points for extra bonus?: ");
    int userIn = int.Parse(Console.ReadLine());
    return userIn;
  }

  public string FileName()
  {
    Console.Write("What is the filename for the goal file?: ");
    string filename = Console.ReadLine();
    return filename;
  }





}