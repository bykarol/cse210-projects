public class Goal
{
  protected string _goalName;
  protected string _goalDescription;
  protected bool _isCompleted;
  protected int _goalPoints;

  public Goal(string name, string description, int points)
  {
    _goalName = name;
    _goalDescription = description;
    _goalPoints = points;
  }

  public virtual void RecordEvent()
  {

  }

  public virtual void DisplayGoal()
  {
    Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
  }

  public virtual bool isComplete(string txt)
  {
    return true;
  }

  public void DisplayPoints()
  {


  }


}