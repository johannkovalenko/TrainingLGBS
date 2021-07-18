//Zredukujcie wymiar hardkodowania 

using System;

public class MainClass
{
    public static void Main()
    {
        DoInEveryIteration();
        DoInEveryIteration();
        DoSporadically();
        DoInEveryIteration();
        DoSporadically();
        DoInEveryIteration();
        DoInEveryIteration();
        DoInEveryIteration();
        DoSporadically();

    }

    public static void DoInEveryIteration()
    {
        Console.WriteLine("AAA");
    }

    public static void DoSporadically()
    {
        Console.WriteLine("BBB");
    }
}