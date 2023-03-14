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

  public string GetGoalName()
  {
    return _goalName;
  }

  public string GetGoalDescription()
  {
    return _goalDescription;
  }

  public int GetGoalPoints()
  {
    return _goalPoints;
  }


  public virtual void RecordEvent()
  {

  }

  public virtual void DisplayGoal()
  {
    Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
  }

  public virtual string SaveGoal()
  {
    return ($"{_goalName},{_goalDescription},{_goalPoints}");
  }

  public virtual bool isComplete(string txt)
  {
    return true;
  }

  public void DisplayPoints()
  {


  }


}