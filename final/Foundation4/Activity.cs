public class Activity
{
  private string _actvName;
  private string _date;
  private double _lengthInMinutes;

  public Activity(string actvName, string date, double duration)
  {
    _actvName = actvName;
    _date = date;
    _lengthInMinutes = duration;
  }

  public void displaySummary()
  {
    Console.WriteLine($"{_date} {_actvName} ({_lengthInMinutes} min) - Distance {getDistance()} miles, Speed: {getSpeed().ToString("0.#")} mph, Pace: {getPace().ToString("0.#")} min per mile");
  }
  public virtual double getDistance()
  {
    return getSpeed() * _lengthInMinutes;
  }
  public virtual double getSpeed()
  {
    return (getDistance() / _lengthInMinutes) * 60;
  }
  protected virtual double getPace()
  {
    return 60 / getSpeed();
  }
}

