using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main()
    {
        CreateAndFillDictionary();

        Dictionary<int, string> myIntStringDict = CreateAndFillDictionaryAndReturnIt();

        GetValueOfKey();
        
        OverwriteWhenItemExists();

        LoopThroughAllElementsOfList(myIntStringDict);
        
        Dictionary<int, int[]> myNestedDictionary = CreateAndFillNestedDictionary();

        LoopThroughAllElementsOfNestedDictionary(myNestedDictionary);

        OverwriteWhenItemExistsNested(myNestedDictionary);
        ManipulateValueWhenItemExistsNested(myNestedDictionary);

        Exercise_CountAppearances();

        Pitfall_1();
        Solution_Pitfall_1();

        Pitfall_2();
        Solution_Pitfall_2();

        Pitfall_3();
        Solution_Pitfall_3();
        
        Console.ReadLine();
    }

    public static void CreateAndFillDictionary()
    {
        Dictionary<int, string> myIntStringDict = new Dictionary<int, string>();
        Dictionary<string, int> myStringIntDict = new Dictionary<string, int>();

        if (!myIntStringDict.ContainsKey(34))
            myIntStringDict.Add(34, "abc");

        if (!myIntStringDict.ContainsKey(34))    
            myIntStringDict.Add(34, "abc");

        for (int i=35;i<50;i++)
            if (!myIntStringDict.ContainsKey(i)) 
                myIntStringDict.Add(i, "abc");

        
        if (!myStringIntDict.ContainsKey("34"))
            myStringIntDict.Add("34", 111);

        if (!myStringIntDict.ContainsKey("34"))    
            myStringIntDict.Add("34", 111);

        for (int i=35;i<50;i++)
            if (!myStringIntDict.ContainsKey(i.ToString())) 
                myStringIntDict.Add(i.ToString(), 111);
    }

    public static Dictionary<int, string> CreateAndFillDictionaryAndReturnIt()
    {
        Dictionary<int, string> myIntStringDict = new Dictionary<int, string>();

        if (!myIntStringDict.ContainsKey(34))
            myIntStringDict.Add(34, "abc");

        if (!myIntStringDict.ContainsKey(34))    
            myIntStringDict.Add(34, "abc");

        for (int i=35;i<50;i++)
            if (!myIntStringDict.ContainsKey(i)) 
                myIntStringDict.Add(i, "abc");

        return myIntStringDict;
    }

    public static void GetValueOfKey()
    {
        // Always check if keys exists, if you don't, your program crashes, when trying to get an noexistent key
        
        Dictionary<int, string> myIntStringDict = new Dictionary<int, string>();
        string myString;

        myIntStringDict.Add(34, "abc"); 

        if (myIntStringDict.ContainsKey(34))
        {
            myString = myIntStringDict[34];
            Console.WriteLine(myString);
        }
    }

    public static void OverwriteWhenItemExists()
    {
        Dictionary<int, int> myIntIntDict = new Dictionary<int, int>();

        myIntIntDict.Add(45, 1);

        if (myIntIntDict.ContainsKey(45))
            myIntIntDict[45] = 2;
        else
            myIntIntDict.Add(45, 2);

        Console.WriteLine(myIntIntDict[45]);
    }

    public static void LoopThroughAllElementsOfList(Dictionary<int, string> myIntStringDict)
    {
        Console.WriteLine("Approach 1:");

        foreach (int item in myIntStringDict.Keys)
            Console.WriteLine("Key: " + item + "\tValue: " + myIntStringDict[item]);

        Console.WriteLine("\r\nApproach 2:");

        foreach (KeyValuePair<int, string> pair in myIntStringDict)
            Console.WriteLine("Key: " + pair.Key + "\tValue: " + pair.Value);

        Console.WriteLine("\r\nApproach 3:");

        Dictionary<int, string>.Enumerator iEnumerator = myIntStringDict.GetEnumerator();
        KeyValuePair<int, string> pair2;

        while (iEnumerator.MoveNext())
        {
            pair2 = iEnumerator.Current;
            Console.WriteLine("Key: " + pair2.Key + "\tValue: " + pair2.Value);
        }

        Console.WriteLine("\r\nApproach 4:");

        iEnumerator = myIntStringDict.GetEnumerator();

        while (iEnumerator.MoveNext())
            Console.WriteLine("Key: " + iEnumerator.Current.Key + "\tValue: " + iEnumerator.Current.Value);
    }

    public static Dictionary<int, int[]> CreateAndFillNestedDictionary()
    {
        Dictionary<int, int[]> myNestedDictionary = new Dictionary<int, int[]>();

        int[] tempInt;
        int testCounter = 0;

        for (int i=35;i<50;i++)
        {
            tempInt = new int[10];

            for (int j=0;j<10;j++)
            {
                ++testCounter;
                tempInt[j] = testCounter;
            }

            myNestedDictionary.Add(i, tempInt);
        }

        return myNestedDictionary;
    }

    public static void LoopThroughAllElementsOfNestedDictionary(Dictionary<int, int[]> myNestedDictionary)
    {
        foreach (int key in myNestedDictionary.Keys)
            foreach (int item in myNestedDictionary[key])
                Console.WriteLine(item);
    }

    public static void OverwriteWhenItemExistsNested(Dictionary<int, int[]> myNestedDictionary)
    {
        int[] tempInt;

        if (myNestedDictionary.ContainsKey(5))
        {
            tempInt = new int[] {3, 5, 6, 3, 2, 3};
            myNestedDictionary[5] = tempInt;

            foreach (int testInt in myNestedDictionary[5])
                Console.WriteLine(testInt);
        }
    }

    public static void ManipulateValueWhenItemExistsNested(Dictionary<int, int[]> myNestedDictionary)
    {
        int[] tempInt;

        if (myNestedDictionary.ContainsKey(5))
        {
            tempInt = myNestedDictionary[5];
            tempInt[4] = 555;
            myNestedDictionary[5] = tempInt;

            foreach (int testInt in myNestedDictionary[5])
                Console.WriteLine(testInt);
        }
    }

    public static void Exercise_CountAppearances()
    {
        string[] inputNames = new string[] {"Pat", "Ann", "Paul", "Paul", "Joe", "Mike", "Pat", "Paul"};
        Dictionary<string, int> outputDict = new Dictionary<string, int>();

        foreach (string name in inputNames)
            if (!outputDict.ContainsKey(name))
                outputDict.Add(name, 1);
            else
                ++outputDict[name];

        foreach (string name in outputDict.Keys)
            Console.WriteLine(name + "\t" + outputDict[name]);

    }

    public static void Pitfall_1()
    {
        //Most problems connected to Dictionaries are due to the fact that dictionaries link by reference 

        Dictionary<int, int[]> myDict = new Dictionary<int, int[]>();
        int[] tempInt = new int[1];

        for (int i=0;i<3;i++)
        {
            tempInt[0] = i;
            myDict.Add(i, tempInt);

            Console.WriteLine();

            foreach (int key in myDict.Keys)
                Console.WriteLine(myDict[key][0]);

            //Expected output:  0, 0 1, 0 1 2
            //Real output:      0, 1 1, 2 2 2

            //Explanation: the dictionary links to the address of "tempInt"
            //the adddress of "tempInt" never changes though (= there is only one instance of "tempInt"
            //every item of myDict points to the same address of "tempInt"
            //hence every change of "tempInt" results in the change of every value of "myDict"
        }
    }

    public static void Solution_Pitfall_1()
    {
        Dictionary<int, int[]> myDict = new Dictionary<int, int[]>();
        int[] tempInt; 

        for (int i=0;i<3;i++)
        {
            tempInt = new int[1];
            tempInt[0] = i;
            myDict.Add(i, tempInt);

            Console.WriteLine();

            foreach (int key in myDict.Keys)
                Console.WriteLine(myDict[key][0]);

            //Expected output:  0, 0 1, 0 1 2
            //Real output:      0, 0 1, 0 1 2

            //Explanation: now there are three addresses (three instances) of "tempInt"
            //so any change in one instance of "tempInt" does not affect the rest of instances
        }
    }

    public static void Pitfall_2()
    {
        Dictionary<int, int[]> myDict = new Dictionary<int, int[]>();

        myDict.Add(0, new int[] {0});
        myDict.Add(1, new int[] {1});

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[1] = myDict[0];

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[0][0] = 9;       

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[1][0] = 8;

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        //Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        //Real outputs:         0   1   |   0   0   |   9   9   |   8   8

        //When copying one entry to another, suddenly every further change in ANY value affects both entries.
        //Explanation: when copying one entry to another, we ONLY copy the address
        // -> both entries now point to the same address in memory
        // -> any change in the address pointed to affects both entries. 

    }

    public static void Solution_Pitfall_2()
    {
        Dictionary<int, int[]> myDict = new Dictionary<int, int[]>();

        myDict.Add(0, new int[] {0});
        myDict.Add(1, new int[] {1});

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[1] = (int[])myDict[0].Clone();

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[0][0] = 9;       

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        myDict[1][0] = 8;

        Console.WriteLine(myDict[0][0]);
        Console.WriteLine(myDict[1][0]);

        //Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        //Real outputs:         0   1   |   0   0   |   9   0   |   9   8

        //Explanation: when cloning an array, a copy of the array under a NEW ADDRESS is created
        // -> every entries now points to a different address in memory
        // -> any change in one address does not affect the other address. 

    }

    public static void Pitfall_3()
    {
        Dictionary<int, int[]> myDict = new Dictionary<int, int[]>();

        myDict.Add(0, new int[] {0});

        Console.WriteLine(myDict[0][0]);
        
        Pitfall_3_Helper(myDict);

        Console.WriteLine(myDict[0][0]);

        //Expected outputs:     0   0
        //Real output:          0   9

        //When calling a function with parameter (which is NOT by reference), we expect no change in the original dictionary
        //But the dictionary calls to the address of the int[]
        //so no matter where we change the int[], it will always affect the whole dictionary
        //(which is actually a very good behavior, nobodys wants to copy dictionaries)

    }

    public static void Solution_Pitfall_3()
    {
        Dictionary<int, int[]> myDict       = new Dictionary<int, int[]>();
        Dictionary<int, int[]> myDictCopy   = new Dictionary<int, int[]>(myDict);

        myDict.Add(0, new int[] {0});

        Console.WriteLine(myDict[0][0]);
        
        Pitfall_3_Helper(myDictCopy);

        Console.WriteLine(myDict[0][0]);

        //Expected outputs:     0   0
        //Real output:          0   0

        //By copying the whole dictionary, a second address is created
        //a change in one address does not affect the second address
    }

    public static void Pitfall_3_Helper(Dictionary<int, int[]> myDict)
    {
        myDict[0] = new int[] {9};
    }
}