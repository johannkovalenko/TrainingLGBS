/* This programme prints:
2 4 6
2 4 6
2 4 6

which is clearly an unintended behaviour. Repair the programme and explain the error.
*/

using System;
using System.Collections.Generic;

class JUN_6M_B
{
    private List<int[]> data = new List<int[]>();

    public void Run()
    {
        Fill();
        Print();
    }

    private void Fill()
    {
        var set = new int[3];

        for (int i=0; i<3; i++)
        {
            set[0] = i;
            set[1] = i*2;
            set[2] = i*3;

            data.Add(set);
        }
    }

    private void Print()
    {
        foreach (int[] set in data)
            Console.WriteLine(set[0] + " " + set[1] + " " + set[2]);
    }
}