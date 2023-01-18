using System;
public class Resume
{
  public string _name = "";
  public List<Job> _jobs = new List<Job>();
  public Resume()
  {
  }
  public void Display()
  {
    // Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
  }
}