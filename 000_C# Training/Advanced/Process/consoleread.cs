using System;
using System.Threading;

public class MainClass
{
    public static void Main()
    {
        int counter = 0;
        string input;

        while (counter++ < 100)
        {
            input = Console.ReadLine();    
            Console.WriteLine(input);
        }
    }
}