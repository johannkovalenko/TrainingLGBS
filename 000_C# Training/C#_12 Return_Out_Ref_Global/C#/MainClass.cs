using System;
using System.Collections.Generic;

class MyClass
{
    public string myString;
    public int myInt;
}

class MainClass
{
    public static string globalString;

    public static void Main()
    {
        PassAndReturnTypeByValue();
        PassAndReturnSeveralSameTypesByValue();
        PassAndReturnDifferentTypesByValue();

        ReturnTypesByOut();

        PassAndReturnTypesByRef_DeFactoGlobal(); 

        GlobalString(); 

        Pitfall_PassComplexTypeByValue();
        Solution_Pitfall_PassComplexTypeByValue();

        Obsolete_PassComplexTypeByRef();

        Console.ReadLine();
    }

    public static void PassAndReturnTypeByValue()
    {
        string myString = PassAndReturnTypeByValue_Helper("ABC");
        Console.WriteLine(myString);
    }

    public static string PassAndReturnTypeByValue_Helper(string myString)
    {
        myString = "DEF";
        return myString;
    }

    public static void PassAndReturnSeveralSameTypesByValue()
    {
        string[] myStrings = PassAndReturnSeveralSameTypesByValue_Helper("ABC", "DEF");
        Console.WriteLine(myStrings[0] + " " + myStrings[1]);
    }

    public static string[] PassAndReturnSeveralSameTypesByValue_Helper(string myString, string myString2)
    {
        myString = "GHI";
        myString2 = "JKL";

        string[] myStrings = new string[] {myString, myString2};
        return myStrings; 
    }

    public static void PassAndReturnDifferentTypesByValue()
    {
        MyClass myClass = PassAndReturnDifferentTypesByValue_Helper("ABC", 1);
        Console.WriteLine(myClass.myString + " " + myClass.myInt);
    }

    public static MyClass PassAndReturnDifferentTypesByValue_Helper(string myString, int myInt)
    {
        MyClass myClass = new MyClass();

        myClass.myString = myString + "DEF";
        myClass.myInt = myInt + 2;

        return myClass;
    }

    public static void ReturnTypesByOut()
    {
        string myString;
        bool myBool;

        ReturnTypesByOut_Helper(out myString, out myBool);
        
        Console.WriteLine(myString + " " + myBool);
    }

    public static void ReturnTypesByOut_Helper(out string myString, out bool myBool)
    {
       myString = "ABC";
       myBool = true;
    }

    public static void PassAndReturnTypesByRef_DeFactoGlobal()
    {
        string myString = "aaa";
        int myInt = 0;
        PassAndReturnTypesByRef_DeFactoGlobal_Helper(ref myString, ref myInt);
        
        Console.WriteLine(myString + " " + myInt);
    }

    public static void PassAndReturnTypesByRef_DeFactoGlobal_Helper(ref string myString, ref int myInt)
    {
       myString = "ABC";
       myInt = 22;
    }


    public static void GlobalString()
    {
        GlobalString_Helper();
        Console.WriteLine(globalString);
    }

    public static void GlobalString_Helper()
    {
        globalString = "DEF";
    }

    public static void Pitfall_PassComplexTypeByValue()
    {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        myDict.Add(1, 10);

        int[] myInts = new int[] {5};

        Pitfall_PassComplexTypeByValue_Helper(myDict, myInts);

        Console.WriteLine(myDict[1] + " " + myInts[0]);

        //Expected Value:   10 5
        //Real Value:       50 20

        //Explanation: Complex Data Types cannot be passed by value. (ByValue = making a copy)
        //When passing an complex type, we pass in fact its start address.
        //So any change done in the called function is a change on the original element 

    }

    public static void Pitfall_PassComplexTypeByValue_Helper(Dictionary<int, int> myDict, int[] myInts)
    {
        myDict[1] = 50;
        myInts[0] = 20;
    }

    public static void Solution_Pitfall_PassComplexTypeByValue()
    {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        myDict.Add(1, 10);

        int[] myInts = new int[] {5};

        Solution_Pitfall_PassComplexTypeByValue_Helper(myDict, myInts);

        Console.WriteLine(myDict[1] + " " + myInts[0]);

        //Expected Value:   10 5
        //Real Value:       10 5

        //Explanation: a deep copy (dictionary) or clone (array) creates a copy of the complex type
        //and puts it to a new address. now every change under the new address has no effect to the object under the old address
    
        //Attention: although this solution solves the problem, it is not recommended to pass complex types
        // by clone/deep copy, because it is very uneconomical.
    }

    public static void Solution_Pitfall_PassComplexTypeByValue_Helper(Dictionary<int, int> myDict, int[] myInts)
    {
        Dictionary<int, int> myCopiedDict = new Dictionary<int, int> (myDict);
        int[] myClonedInts = (int[])myInts.Clone();

        myCopiedDict[1] = 50;
        myClonedInts[0] = 20;
    }

    public static void Obsolete_PassComplexTypeByRef()
    {
        Dictionary<int, int> myDict = new Dictionary<int, int>();
        myDict.Add(1, 10);

        int[] myInts = new int[] {5};

        Obsolete_PassComplexTypeByRef_Helper(ref myDict, ref myInts);

        Console.WriteLine(myDict[1] + " " + myInts[0]);

        //Explanation: ref is obsolete here, because all complex types are by default passed by reference
    }

    public static void Obsolete_PassComplexTypeByRef_Helper(ref Dictionary<int, int> myDict, ref int[] myInts)
    {
        myDict[1] = 50;
        myInts[0] = 20;
    }
}


