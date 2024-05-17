 class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Time { get; set; }

    public virtual string Print()
    {
        string output = string.Format("{0} {1} {2}", Title, Description , Convert.ToString(Time));

        return output;
    }

}

