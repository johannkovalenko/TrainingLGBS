//Poprawcie ten kod pod względem zredukowania powtarzalności fragmentów kodu.

using System;

public class MainClass
{
    public static void Main()
    {
        int myInt = 85;

        if (myInt > 0 && myInt <= 20)
        {
            for (int i=0;i<10;i++)
                Console.WriteLine("A");
        } 
        else if (myInt > 20 && myInt <= 40)
        {
            for (int i=0;i<30;i++)
                Console.WriteLine("B");
        } 
        else if (myInt > 40 && myInt <= 60)
        {
            for (int i=0;i<50;i++)
                Console.WriteLine("C");
        } 
        else if (myInt > 60 && myInt <= 80)
        {
            for (int i=0;i<70;i++)
                Console.WriteLine("D");
        } 
        else if (myInt > 80 && myInt <= 100)
        {
            for (int i=0;i<90;i++)
                Console.WriteLine("E");
        }

        Console.ReadLine();
    }
}
