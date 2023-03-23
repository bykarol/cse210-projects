using System;

class Program
{
  static void Main(string[] args)
  {
    List<Event> events = new List<Event>();
    Console.WriteLine("EVENT PLANNING");
    Console.WriteLine("*****************");

    //creating address
    Address address1 = new Address("47 Anyville", "Orlando", "FL", "15007");
    Address address2 = new Address("15 Anytown", "Phoenix", "AZ", "15000");
    Address address3 = new Address("Football Central Stadium", "San Diego", "CA", "12000");
    //creating Lecture Event
    LectureEvent event1 = new LectureEvent("How to make friends", "The best way to make new friends", "Jun 26th", "20:00", address1, "Joaquin Perez", 100);
    //creating Reception Event
    ReceptionEvent event2 = new ReceptionEvent("My Graduation", "Come to celebrate the Prom 2023", "May 1st", "10:00", address2, "confirmation@events.com");
    //creating Outgathering Event
    OutdoorGatheringEvent event3 = new OutdoorGatheringEvent("Football Play", "Watch the game with friends and meet some famous football players", "Jul 10th", "15:30", address3, "Will be sunny - Bring your sunglasses!");
    //Adding events to the list os events
    events.Add(event1);
    events.Add(event2);
    events.Add(event3);

    foreach (Event plannedEvent in events)
    {
      Console.WriteLine("---Standard Details---");
      plannedEvent.displayStandardDetails();
      Console.WriteLine("---Full Details---");
      plannedEvent.displayFullDetails();
      Console.WriteLine("---Short Description---");
      Console.WriteLine(plannedEvent.GetType());
      plannedEvent.displayShortDescription();
      Console.WriteLine("***********************");
      Console.WriteLine("***********************");
    }
  }
}