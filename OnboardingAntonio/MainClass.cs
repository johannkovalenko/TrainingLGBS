using System;
using System.Collections.Generic;

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Meta data to make McAfee happy
[assembly: AssemblyTitle("MyProject")]
[assembly: AssemblyProduct("RPA")]
[assembly: AssemblyCopyright("Lufthansa Group Business Services")]
[assembly: AssemblyTrademark("Lufthansa Group Business Services")]
[assembly: AssemblyVersion("1.0.0.9")]
[assembly: AssemblyFileVersion("1.0.0.9")]

class MainClass
{

    public static void Main()
    {
        Console.WriteLine("Hello, world");
        //FirstFunction();
        //SecondFunction("abc", 43);
        //ThirdFunction();
        //FirstDictionary();
        FirstList();
    }

    private static void FirstFunction() 
    {
        string myString = "ABC";
        int myInt = 46;

        myString += "DEF";
        myInt += 18;

        Console.WriteLine(myString);
        Console.WriteLine(myInt);
    }

    private static void SecondFunction(string myString, int myInt)
    {
        myString += "GHI";
        myInt += 46;
        Console.WriteLine(myString + "   " + myInt);
    }

    private static void ThirdFunction()
    {
        MyEmployee myEmployee = new MyEmployee("Antonio", 24, false, 1000000.00);
        myEmployee.PrintAll();
    }

    private static void FirstDictionary() 
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("Mexico", "Mexico D.F.");
        myDict.Add("USA", "Washington D.C.");
        myDict.Add("Poland", "Warsaw");
        myDict.Add("Austria", "Vienna");

        if (!myDict.ContainsKey("Germany"))
            myDict.Add("Germany", "Berlin");

        foreach (string country in myDict.Keys)
        {
            Console.WriteLine(country + "   " + myDict[country]);
        }

        foreach (KeyValuePair<string, string> pair in myDict) {
            Console.WriteLine(pair.Key + "   " + pair.Value);
        }
    }

    private static void FirstList() 
    {
        List<string> myList = new List<string>();

        myList.Add("Antonio");
        myList.Add("Johann");
        if (!myList.Contains("Paul"))
            myList.Add("Paul");

        foreach (string element in myList)
            Console.WriteLine(element);    
    }
}

class MyEmployee
{
    private string name;
    private int age;
    private bool married;
    private double salary;

    public MyEmployee(string name, int age, bool married, double salary) {
        this.name = name;
        this.age = age;
        this.married = married;
        this.salary = salary;
    }


    public void PrintAll()
    {
        Console.WriteLine(name + "\t" + age + "\t" + married + "\t" + salary);
    }
}


// Build a capital-quiz?
//Program asks: what is the capital of Germany.
//User enters: Vienna.
//Program says: wrong.
//User enters: Berlin.
//Programm says: correct

//string answer = Console.ReadLine();

//Password for zip: abc