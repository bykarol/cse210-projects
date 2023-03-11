public class SimpleGoal : Goal
{
  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  { }

  public override void RecordEvent()
  {
    base.RecordEvent();
  }

  public override bool isComplete(string txt)
  {
    return base.isComplete(txt);
  }
}