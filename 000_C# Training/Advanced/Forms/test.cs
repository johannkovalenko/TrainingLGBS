using System;

public delegate void MyDelegate(string username);

class EventProgram 
{
    event MyDelegate MyEvent;

    static void Main(string[] args) 
    {
        EventProgram obj1 = new EventProgram();
        obj1.MyEvent += new MyDelegate(obj1.WelcomeUser);
        obj1.MyEvent("Tutorials Point");
        Console.ReadLine();
    }

    public void WelcomeUser(string username) 
    {
        Console.WriteLine(username);
    }
}
