import java.util.Scanner;
import java.util.HashMap;

class MyClass
{
    public String myString;
    public int myInt;
}

class MainClass
{
    public static String globalString;

    public static void main(String[] args)
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

        new Scanner(System.in).nextLine();
    }

    public static void PassAndReturnTypeByValue()
    {
        String myString = PassAndReturnTypeByValue_Helper("ABC");
        System.out.println(myString);
    }

    public static String PassAndReturnTypeByValue_Helper(String myString)
    {
        myString = "DEF";
        return myString;
    }

    public static void PassAndReturnSeveralSameTypesByValue()
    {
        String[] myStrings = PassAndReturnSeveralSameTypesByValue_Helper("ABC", "DEF");
        System.out.println(myStrings[0] + " " + myStrings[1]);
    }

    public static String[] PassAndReturnSeveralSameTypesByValue_Helper(String myString, String myString2)
    {
        myString = "GHI";
        myString2 = "JKL";

        String[] myStrings = new String[] {myString, myString2};
        return myStrings; 
    }

    public static void PassAndReturnDifferentTypesByValue()
    {
        MyClass myClass = PassAndReturnDifferentTypesByValue_Helper("ABC", 1);
        System.out.println(myClass.myString + " " + myClass.myInt);
    }

    public static MyClass PassAndReturnDifferentTypesByValue_Helper(String myString, int myInt)
    {
        MyClass myClass = new MyClass();

        myClass.myString = myString + "DEF";
        myClass.myInt = myInt + 2;

        return myClass;
    }

    public static void ReturnTypesByOut()
    {
        // not supported by Java
    }

    public static void PassAndReturnTypesByRef_DeFactoGlobal()
    {
        // not supported by Java
    }

    public static void GlobalString()
    {
        GlobalString_Helper();
        System.out.println(globalString);
    }

    public static void GlobalString_Helper()
    {
        globalString = "DEF";
    }

    public static void Pitfall_PassComplexTypeByValue()
    {
        HashMap<Integer, Integer> myDict = new HashMap<Integer, Integer>();
        myDict.put(1, 10);

        int[] myInts = new int[] {5};

        Pitfall_PassComplexTypeByValue_Helper(myDict, myInts);

        System.out.println(myDict.get(1) + " " + myInts[0]);

        //Expected Value:   10 5
        //Real Value:       50 20

        //Explanation: Complex Data Types cannot be passed by value. (ByValue = making a copy)
        //When passing an complex type, we pass in fact its start address.
        //So any change done in the called function is a change on the original element 

    }

    public static void Pitfall_PassComplexTypeByValue_Helper(HashMap<Integer, Integer> myDict, int[] myInts)
    {
        myDict.put(1, 50);
        myInts[0] = 20;
    }

    public static void Solution_Pitfall_PassComplexTypeByValue()
    {
        HashMap<Integer, Integer> myDict = new HashMap<Integer, Integer>();
        myDict.put(1, 10);

        int[] myInts = new int[] {5};

        Solution_Pitfall_PassComplexTypeByValue_Helper(myDict, myInts);

        System.out.println(myDict.get(1) + " " + myInts[0]);

        //Expected Value:   10 5
        //Real Value:       10 5

        //Explanation: a deep copy (HashMap) or clone (array) creates a copy of the complex type
        //and puts it to a new address. now every change under the new address has no effect to the object under the old address
    
        //Attention: although this solution solves the problem, it is not recommended to pass complex types
        // by clone/deep copy, because it is very uneconomical.
    }

    public static void Solution_Pitfall_PassComplexTypeByValue_Helper(HashMap<Integer, Integer> myDict, int[] myInts)
    {
        HashMap<Integer, Integer> myCopiedDict = new HashMap<Integer, Integer> (myDict);
        int[] myClonedInts = (int[])myInts.clone();

        myCopiedDict.put(1, 50);
        myClonedInts[0] = 20;
    }

    public static void Obsolete_PassComplexTypeByRef()
    {
        //Not supported by Java
    }
}


