public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  { }

  public override void RecordEvent()
  {
    base.RecordEvent();
  }

  public override void DisplayGoal()
  {
    base.DisplayGoal();
  }

  public override bool isComplete(string txt)
  {
    return base.isComplete(txt);
  }
}