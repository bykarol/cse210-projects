public class Prompt
{
  List<string> prompts = new List<string>()
    {
      "Name of the Simple Goal: ",
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





}