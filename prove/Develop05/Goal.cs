public class Goal
{
  protected string _goalName;
  protected string _goalDescription;
  protected bool _isCompleted;
  protected int _goalPoints;
  List<Goal> goals = new List<Goal>();
  public Goal(string name, string description, int points)
  {
    _goalName = name;
    _goalDescription = description;
    _goalPoints = points;
  }
  // public string GetName()
  // {
  //   return _goalName;
  // }
  // public void SetName(string name)
  // {
  //   _goalName = name;
  // }

  // public string GetDescription()
  // {
  //   return _goalDescription;
  // }
  // public void SetDescription(string description)
  // {
  //   _goalDescription = description;
  // }
  // public bool GetIsCompleted()
  // {
  //   return _isCompleted;
  // }
  // public void SetIsCompleted(bool isComplete)
  // {
  //   _isCompleted = isComplete;
  // }

  // protected int GetPoints()
  // {
  //   return _goalPoints;
  // }
  // public void SetPoints(int points)
  // {
  //   _goalPoints = points;
  // }

  public virtual void RecordEvent()
  {

  }

  public virtual void CreateGoal()
  {
    Console.Write("Name of the Simple Goal: ");
    _goalName = Console.ReadLine();
    Console.Write("Brief goal description: ");
    _goalDescription = Console.ReadLine();
    Console.Write("How many points?: ");
    _goalPoints = int.Parse(Console.ReadLine());
  }

  public virtual void DisplayGoal(List<Goal> goals)
  {
    Console.WriteLine("The goals are:");
    for (int i = 1; i <= goals.Count; i++)
    {
      Console.WriteLine($"{i}. [ ] {_goalName} ({_goalDescription})");
    }
  }

  public virtual bool isComplete(string txt)
  {
    return true;
  }

  public void DisplayPoints()
  {


  }


}