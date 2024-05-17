using System;
class Menu
{
    EventOrganiser eventOrganiser = new EventOrganiser();
    private void Display()
    {
        Console.WriteLine("(1) Add event");
        Console.WriteLine("(2) Add birthday");
        Console.WriteLine("(3) Remove events");
        Console.WriteLine("(4) Display events");
        Console.WriteLine("(q) Quit");
    }
    public void Execute()
    {
        string option;
        do
        {
         Display();
         option = Console.ReadLine();
        
            switch (option)
            {
                    case "1":
                    {
                        eventOrganiser.Add();
                        break;
                    }
                    case "2":
                    {
                        eventOrganiser.AddBirthday();
                        break;
                    }
                    case "3":
                    {
                        eventOrganiser.Remove();
                      break;
                    }
                    case "4":
                    {
                        eventOrganiser.DisplayEvents();
                        break;
                    }

            }
        } while (option != "q" && option != "Q");
            
    }
}

