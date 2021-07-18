using System;

class MainClass
{
    static void MaximumReached(object source, MyEventArgs e)
    {
        Console.WriteLine(e.GetInfo());
    }

    static void Main(string[] args)
    {
        MyClass MyObject = new MyClass();
        MyObject.OnMaximum += new MyEventHandler(MaximumReached);

        for(int x = 0; x <= 15; x++)
        {
            Console.WriteLine("AAA");
            MyObject.MyValue = x;
            Console.WriteLine("BBB");
        }
    }
}