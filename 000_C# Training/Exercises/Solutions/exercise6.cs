using System;

public class MainClass
{
    public static void Main()
    {
        int myInt = Write(4, 31, 7, 25);
        Read(myInt);

        Console.ReadLine();
    }

    public static int Write(int weekDay, int day, int month, int years)
    {
        int myInt = weekDay;
        myInt <<= 5;
        myInt += day;
        myInt <<= 4;
        myInt += month;
        myInt <<= 7;
        myInt += years;

        string binary = Convert.ToString(myInt, 2);
        Console.WriteLine(binary);

        return myInt;
    }

    public static void Read(int myInt)
    {
        int weekDay, day, month, years;

        years = myInt & 127;
        myInt >>= 7;
        month = myInt & 15;
        myInt >>= 4;
        day = myInt & 31;
        myInt >>= 5;
        weekDay = myInt;

        foreach (int result in new int[] {weekDay, day, month, years})
            Console.WriteLine(result);
    }
}