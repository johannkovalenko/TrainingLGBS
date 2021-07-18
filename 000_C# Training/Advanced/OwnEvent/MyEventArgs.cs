using System;

public class MyEventArgs : EventArgs
{
    private string EventInfo;
    public MyEventArgs(string Text)
    {
        EventInfo = Text;
    }
    public string GetInfo()
    {
        return EventInfo;
    }
}