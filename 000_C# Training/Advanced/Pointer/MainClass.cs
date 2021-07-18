using System;

class MainClass
{
    public unsafe static void Main()
    {
        int myInt = 45;
        int* myIntAddress = &myInt;
        Console.WriteLine((int)myIntAddress);

        ByVal(myInt);
        ByRef(ref myInt);
    }

    public unsafe static void ByVal(int myInt)
    {
        int* myIntAddress = &myInt;
        Console.WriteLine("ByVal " + (int)myIntAddress);
    }

    public unsafe static void ByRef(ref int myInt)
    {
        fixed (int* myIntAddress = &myInt)
        {
            Console.WriteLine("ByRef " + (int)myIntAddress);
        }
    }
}