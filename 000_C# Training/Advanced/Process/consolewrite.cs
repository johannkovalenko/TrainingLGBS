using System;
using System.Threading;

public class MainClass
{
    public static void Main()
    {
        int counter = 0;
        while (counter++ < 100)
        {
            Console.WriteLine("Tour " + counter);
            Thread.Sleep(1000);
        }
    }
}