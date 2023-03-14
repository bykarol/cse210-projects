public class ChecklistGoal : Goal
{
  private int _timesToComplete;
  private int _bonusTime;
  private int _currentChecked = 1;
  private int _bonusPoints;
  public ChecklistGoal(string name, string description, int points, int timesComplete, int bonusTime) : base(name, description, points)
  {
    _timesToComplete = timesComplete;
    _bonusTime = bonusTime;
  }

  public override void RecordEvent()
  {
    base.RecordEvent();
  }

  public override void DisplayGoal()
  {
    Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_currentChecked}/{_timesToComplete}");
  }

  public override bool isComplete(string txt)
  {
    return base.isComplete(txt);
  }
}