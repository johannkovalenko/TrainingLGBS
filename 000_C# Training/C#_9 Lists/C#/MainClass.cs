using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main()
    {
        CreateAndFillList();

        List<int> myIntList = CreateAndFillListAndReturnIt();

        CheckIfItemExists();

        LoopThroughAllElementsOfList(myIntList);
        
        List<int[]> myNestedIntList = CreateAndFillNestedList();

        LoopThroughAllElementsOfNestedList(myNestedIntList);

        Exercise_EliminateDoubleAppearances();

        Pitfall_1();
        
        Console.ReadLine();
    }

    public static void CreateAndFillList()
    {
        List<int> myIntList = new List<int>();
        List<string> myStringList = new List<string>();

        myIntList.Add(34);
        myIntList.Add(34);

        for (int i=5;i<8;i++)
            myIntList.Add(i);

        
        myStringList.Add("34");
        myStringList.Add("34");

        for (int i=5;i<8;i++)
            myStringList.Add(i.ToString());
    }

    public static List<int> CreateAndFillListAndReturnIt()
    {
        List<int> myIntList = new List<int>();

        myIntList.Add(34);
        myIntList.Add(34);

        for (int i=5;i<8;i++)
            myIntList.Add(i);

        return myIntList;
    }

    public static void CheckIfItemExists()
    {
        List<int> myIntList = new List<int>();

        if (!myIntList.Contains(45))
            myIntList.Add(45);
    }

    public static void LoopThroughAllElementsOfList(List<int> myIntList)
    {
        foreach (int item in myIntList)
            Console.WriteLine(item);

        for (int i=0;i<myIntList.Count;i++)
            Console.WriteLine(myIntList[i]);
    }

    public static List<int[]> CreateAndFillNestedList()
    {
        List<int[]> myIntList = new List<int[]>();

        int[] tempInt;
        int testCounter = 0;

        for (int i=5;i<8;i++)
        {
            tempInt = new int[10];

            for (int j=0;j<10;j++)
            {
                ++testCounter;
                tempInt[j] = testCounter;
            }

            myIntList.Add(tempInt);
        }

        return myIntList;
    }

    public static void LoopThroughAllElementsOfNestedList(List<int[]> myNestedIntList)
    {
        foreach (int[] itemArray in myNestedIntList)
            foreach (int item in itemArray)
                Console.WriteLine(item);

        for (int j=0;j<myNestedIntList.Count;j++)
            for (int i=0;i<myNestedIntList[j].Length;i++)
                Console.WriteLine(myNestedIntList[j][i]);
    }

    public static void Exercise_EliminateDoubleAppearances()
    {
        int[] inputNumbers = new int[] {3, 7, 5, 5, 4, 3, 2, 7};
        List<int> outputList = new List<int>();

        foreach (int number in inputNumbers)
            if (!outputList.Contains(number))
                outputList.Add(number);

        foreach (int number in outputList)
            Console.WriteLine(number);

    }

    public static void Pitfall_1()
    {
        List<int> myList = new List<int>();

        myList.Add(100);
        myList.Add(200);

        //OK
        Console.WriteLine(myList[0]);
        Console.WriteLine(myList[1]);

        //This will cause an error
        Console.WriteLine(myList[100]);
        Console.WriteLine(myList[200]);
    }

}