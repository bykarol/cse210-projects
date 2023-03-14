public class FilesHandler
{
  private string _fileName;

  public FilesHandler(string fileName)
  {
    _fileName = fileName;

  }
  public void SaveFile(List<Goal> goalsList)
  {
    using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
      foreach (Goal goal in goalsList)
      {
        outputFile.Write(goal.GetType() + ":");
        outputFile.WriteLine(goal.SaveGoal());
      }
    }
  }

  // public List<Goal> LoadFile()
  // {
  //   string[] lines = System.IO.File.ReadAllLines(_fileName);
  //   List<Goal> goalsList = new List<Goal>();
  //   foreach (string line in lines)
  //   {
  //     line.Split(",");
  //   }
  //   return goalsList;
  // }




}