using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{
    public static void Main()
    {
        //DeclareWriteAndRead();
        //SaveClassInstanceForFurtherUse_List();
        //SaveClassInstanceForFurtherUse_Array();
        //Inherit_ExtendFunctionalityOfClass();
        Initializer();
        GetterSetter();

        Console.ReadLine();
    }

    public static void DeclareWriteAndRead()
    {
        MyClass.myStaticVariable = 66;

        MyClass first = new MyClass();
        MyClass second = new MyClass();

        first.myNonStaticVariable = 99;
        first.myNonStaticVariable2 = 77;

        second.myNonStaticVariable = 88;
        second.myNonStaticVariable2 = 55;        

        Console.WriteLine(MyClass.myStaticVariable);
        Console.WriteLine(first.myNonStaticVariable);
        Console.WriteLine(first.myNonStaticVariable2);
        Console.WriteLine(second.myNonStaticVariable);
        Console.WriteLine(second.myNonStaticVariable2);
        Console.ReadLine();    
    }

    public static void SaveClassInstanceForFurtherUse_List()
    {
        List<MyClass> myList = new List<MyClass>();

        MyClass first = new MyClass();
        MyClass second = new MyClass();

        first.myNonStaticVariable = 99;
        first.myNonStaticVariable2 = 77;

        second.myNonStaticVariable = 88;
        second.myNonStaticVariable2 = 55; 

        myList.Add(first);
        myList.Add(second);

        //Further use:

        foreach (MyClass classInstance in myList)
        {
            Console.WriteLine(classInstance.myNonStaticVariable);
            Console.WriteLine(classInstance.myNonStaticVariable2);
        }
    }

    public static void SaveClassInstanceForFurtherUse_Array()
    {
        MyClass[] myArray = new MyClass[2];

        MyClass first = new MyClass();
        MyClass second = new MyClass();

        first.myNonStaticVariable = 99;
        first.myNonStaticVariable2 = 77;

        second.myNonStaticVariable = 88;
        second.myNonStaticVariable2 = 55; 

        myArray[0] = first;
        myArray[1] = second;

        //Further use:

        for (int i=0;i<myArray.Length;i++)
        {
            Console.WriteLine(myArray[i].myNonStaticVariable);
            Console.WriteLine(myArray[i].myNonStaticVariable2);
        }
    }

    public static void Inherit_ExtendFunctionalityOfClass()
    {
        //Take all functionality of List<int> but add own (hopefully better) functionality to it.

        ListJK list = new ListJK(new int[] {6, 5, 3, 2, 5, 6, 9, 8});
        list.Add(1);
        list.Add(15);

        if (list.Contains(5))
            Console.WriteLine("Contains 5");

        list.SortJK();
        list.PrintJK();
    }

    public static void Initializer()
    {
        MyClass2 myClass2 = new MyClass2(32, "Johann");
        Console.WriteLine(myClass2.myInt);
        Console.WriteLine(myClass2.myString);
    }

    public static void GetterSetter()
    {
        // C# does not require Getters and Setters, Java does not have them, Ruby and VBA require them

        MyClass3 myClass3 = new MyClass3();
        myClass3.myInt = 1;
        Console.WriteLine(myClass3.myInt);
    }
}

class MyClass
{
    public static int myStaticVariable;
    public int myNonStaticVariable;
    public int myNonStaticVariable2;
}

class MyClass2
{
    public MyClass2(int myInt, string myString)
    {
        this.myInt = myInt;
        this.myString = myString;
    }

    public int myInt;
    public string myString;
}

class MyClass3
{
    private int _myInt;

    public int myInt
    {
        get
        {
            return _myInt + 5;
        }
        set
        {
            _myInt = value + 5;
        }
    }
}

class ListJK : List<int>
{
    public ListJK()
    {
    }

    public ListJK (int[] input)
    {
        foreach (int singleInt in input)
            base.Add(singleInt);
    }

    public void SortJK()
    {
        int maximumNumber = 0;
        int finalCounter = 0;

        for (int i=0;i<base.Count;i++)
            if (base[i] > maximumNumber)
                maximumNumber = base[i];

        int[] finalArray = new int[maximumNumber + 1];

        for (int i=0;i<base.Count;i++)
            ++finalArray[base[i]];

        for (int i=0;i<finalArray.Length;i++)
            for (int j=0;j<finalArray[i];j++)
                base[finalCounter++] = i;
    }

    public void PrintJK()
    {
        for (int i=0;i<base.Count;i++)
            Console.Write(base[i] + " ");
        
        Console.WriteLine();
    }
}
