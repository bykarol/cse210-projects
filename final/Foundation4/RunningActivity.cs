public class RunningActivity : Activity
{
  private double _distance;

  public RunningActivity(string actvName, string date, double duration, double distance) : base(actvName, date, duration)
  {
    _distance = distance;
  }

  public override double getDistance()
  {
    return _distance;
  }
}
