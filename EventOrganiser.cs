


using System.ComponentModel.Design;
using System.Data;

class EventOrganiser
{
    List<Event> Events = new List<Event>();
    public void Add()
    {

        Event AnEvent = new Event();
        Console.WriteLine("Enter the title of the event.");
        AnEvent.Title = Console.ReadLine();
        Console.WriteLine("Enter the description of the event");
        AnEvent.Description = Console.ReadLine();
        Console.WriteLine("Enter the time of the event: YYYY/DD/MM HH:MM");
        string date = Console.ReadLine();   
        AnEvent.Time = DateTime.Parse(date);
      

        Events.Add(AnEvent);

        Events = Events.OrderBy(e=> e.Time).ToList();
        
        
    }
    public void AddBirthday()
    {
        Birthday birthday = new Birthday();
        
        Console.WriteLine("Enter the title of the event.");
        birthday.Title = Console.ReadLine();
        Console.WriteLine("Enter the description of the event");
        birthday.Description = Console.ReadLine();
        Console.WriteLine("Enter the time of the event: YYYY/DD/MM HH:MM");
        string date = Console.ReadLine();
        birthday.Time = DateTime.Parse(date);
        birthday.AddGuest();

        Events.Add(birthday);
        Events = Events.OrderBy(e => e.Time).ToList();
    }
    public void Remove()
    {
        Console.Clear();
        bool EventsCount = true;
        if (Events.Count == 0)
        {
            Console.WriteLine("No events.");
            EventsCount = false;
        }
        
        
        foreach (Event Event in Events)
        {
            Console.WriteLine(" \n {0} ", Event.Title);
        }
        bool inList = false;
        while (inList == false && EventsCount == true) 
        {
            Console.WriteLine("Enter the title of the event you want to remove.");
            string titleEntered = Console.ReadLine();
            foreach (Event Event in Events.ToList())
            {
                if (Event.Title == titleEntered)
                {
                    Events.Remove(Event);
                    Console.WriteLine("Event removed.");
                    inList = true;
                }
            }
        }
        
        


    }
    public void DisplayEvents()
    {
        Console.Clear();
        int count = 1;
        foreach (Event Event in Events)
        {
            Console.WriteLine(" \n {0} {1}", count, Event.Print());
        }
        if (Events.Count == 0)
        {
            Console.WriteLine("No events.");
        }
     
    }
}

