public class CyclingActivity : Activity
{
  private double _speed;
  public CyclingActivity(string actvName, string date, double duration, double speed) : base(actvName, date, duration)
  {
    _speed = speed;
  }
  public override double getSpeed()
  {
    return _speed;
  }
}
