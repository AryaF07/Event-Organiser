
class Birthday : Event
{


    List<string> Guests = new List<string>();   

    public void AddGuest()
    {
        bool guest = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Enter the name of a guest");
            string Guest = Console.ReadLine();
            Guests.Add(Guest);
            if (Guest == "")
            {
                guest = true;
            }
        } while (guest == false);

    }
    public override string Print()
    {
        string output = base.Print();
        foreach (string s in Guests)
        {
            output += "\n"+ s;
        }
        return output;  

    }


}

