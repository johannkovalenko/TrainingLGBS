using System;

class MainClass
{
    public static string globalVariableInHomeClass = "DEF";

    public static void Main()
    {
        MyStrings();
        MyInts();
        MyArray();
        AccessGlobalVariables();

        Console.ReadLine();
    }  

    public static void MyStrings()
    {
        string myString1 = "ABC";
        string myString2 = "DEF";
        string myString3 = myString1 + myString2;
        Console.WriteLine(myString3);
    } 

    public static void MyInts()
    {
        int myInt1 = 7;
        int myInt2 = 5;
        int myInt3 = myInt1 * myInt2;
        Console.WriteLine(myInt3);
    }

    public static void MyArray()
    {
        string[] myStringArray = new string[] {"abc", "def", "ghi"};
        string myString = myStringArray[2];
        Console.WriteLine(myString);

        string[] myStringArray2 = new string[3];
        myStringArray2[0] = "abc";
        myStringArray2[1] = "def";
        myStringArray2[2] = "ghi";
        Console.WriteLine(myStringArray2[2]);
    }

    public static void AccessGlobalVariables()
    {
        string myConcatString = globalVariableInHomeClass + OtherClass.globalVariableInOtherClass;
        Console.WriteLine(myConcatString);
    }

}

class OtherClass
{
    public static string globalVariableInOtherClass = "ABC";
}