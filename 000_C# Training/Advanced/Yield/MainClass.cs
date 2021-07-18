using System;
using System.Collections.Generic;
// using System.Collections;

class MainClass
{
    static int[] myInts;

    static void Main()
    {
        myInts = new int[] {3, 5, 4, 31, 2, 7};

        IEnumerable<int> coll = FilterOut();
        Console.WriteLine("---");
    
        foreach (int myInt in coll)
        {
            Console.WriteLine("Y: " + myInt);
        }
    }

    static IEnumerable<int> FilterOut()
    {
        int sum = 0;
        foreach (int myInt in myInts)
        {
            Console.WriteLine("X: " + myInt);
            sum += myInt;
                yield return sum;
        }
    }
}