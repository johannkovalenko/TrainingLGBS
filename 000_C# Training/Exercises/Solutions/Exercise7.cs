//Poprawcie ten kod pod względem zredukowania powtarzalności fragmentów kodu.

using System;

public class MainClass
{
    public static void Main()
    {
        int myInt = 85;

        int myIntDiv = myInt / 20;
        string[] myArr = new string[] {"A", "B", "C", "D", "E"};

        int iterations = myIntDiv * 20 + 10;
        
        for (int i=0;i<iterations;i++)
            Console.WriteLine(myArr[myIntDiv]);

        Console.ReadLine();
    }
}
