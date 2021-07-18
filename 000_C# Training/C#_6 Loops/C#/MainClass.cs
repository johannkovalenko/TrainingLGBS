using System;

class MainClass
{
    public static void Main()
    {
        ForLoop_ZeroToNine();
        ForLoop_OneToTen();
        ForLoop_NineToZero();
        ForLoop_JumpTwo();
        LoopWhile();
        LoopWhile_AtLeastOneIteration();
        EndlessLoopWithEmergencyExit();
        ForEach();
        DeFactoForEach();
        ForEachCharInString();
        DefactoForEachCharInString();

        Console.ReadLine();
    }

    public static void ForLoop_ZeroToNine()
    {
        for (int i=0; i<10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ForLoop_OneToTen()
    {
        for (int i=1; i<11; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ForLoop_NineToZero()
    {
        for (int i = 9;i>=0;i--)
            Console.WriteLine(i);
    }

    public static void ForLoop_JumpTwo()
    {
        for (int i=0;i<10;i+=2)
            Console.WriteLine(i);
    }


    public static void LoopWhile()
    {
        int i = 0;

        while (i < 10)
        {
            Console.WriteLine(i);
            i++;  
        }
    }

    public static void LoopWhile_AtLeastOneIteration()
    {
        int i = 10;

        do
        {
            Console.WriteLine(i);
            i++;  
        }
        while (i < 10);
    }

    public static void EndlessLoopWithEmergencyExit()
    {
        int i = 0;

        while (true)
        {
            i++;
            Console.WriteLine(i);
            
            if (i > 100)
                break;
        }
    }

    public static void ForEach()
    {
        string[] myArray = new string[] {"abc", "def", "ghi", "jkl"};

        foreach (string mySingleString in myArray)
        {
            Console.WriteLine(mySingleString);
        }

        //Short version when only one-liner
        foreach (string mySingleString in myArray)
            Console.WriteLine(mySingleString);       
    }

    public static void DeFactoForEach()
    {
        string[] myArray = new string[] {"abc", "def", "ghi", "jkl"};

        for (int i=0;i<myArray.Length;i++)
            Console.WriteLine(myArray[i]);
    }

    public static void ForEachCharInString()
    {
        string myString = "LGBSMNLKRK";

        foreach (char singleChar in myString)
            Console.WriteLine(singleChar);
    }

    public static void DefactoForEachCharInString()
    {
        string myString = "LGBSMNLKRK";

        for (int i=0;i<myString.Length;i++)
            Console.WriteLine(myString[i]);
    }
}