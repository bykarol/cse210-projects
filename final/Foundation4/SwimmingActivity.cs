public class SwimmingActivity : Activity
{
  private int _lapsNum;
  public SwimmingActivity(string actvName, string date, double duration, int laps) : base(actvName, date, duration)
  {
    _lapsNum = laps;
  }
  public override double getDistance()
  {    //in miles
    return _lapsNum * 50 / 1000 * 0.62;
  }

}
