import java.util.List;
import java.util.ArrayList;
import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
    {
        DeclareWriteAndRead();
        SaveClassInstanceForFurtherUse_List();
        SaveClassInstanceForFurtherUse_Array();
        Inherit_ExtendFunctionalityOfClass();
        Initializer();
        GetterSetter();

        new Scanner(System.in).nextLine();
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

        System.out.println(MyClass.myStaticVariable);
        System.out.println(first.myNonStaticVariable);
        System.out.println(first.myNonStaticVariable2);
        System.out.println(second.myNonStaticVariable);
        System.out.println(second.myNonStaticVariable2);  
    }

    public static void SaveClassInstanceForFurtherUse_List()
    {
        List<MyClass> myList = new ArrayList<MyClass>();

        MyClass first = new MyClass();
        MyClass second = new MyClass();

        first.myNonStaticVariable = 99;
        first.myNonStaticVariable2 = 77;

        second.myNonStaticVariable = 88;
        second.myNonStaticVariable2 = 55; 

        myList.add(first);
        myList.add(second);

        //Further use:

        for (MyClass classInstance : myList)
        {
            System.out.println(classInstance.myNonStaticVariable);
            System.out.println(classInstance.myNonStaticVariable2);
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

        for (int i=0;i<myArray.length;i++)
        {
            System.out.println(myArray[i].myNonStaticVariable);
            System.out.println(myArray[i].myNonStaticVariable2);
        }
    }

    public static void Inherit_ExtendFunctionalityOfClass()
    {
        //Take all functionality of List<int> but add own (hopefully better) functionality to it.

        ListJK list = new ListJK(new int[] {6, 5, 3, 2, 5, 6, 9, 8});
        list.add(1);
        list.add(15);

        if (list.contains(5))
            System.out.println("Contains 5");

        list.SortJK();
        list.PrintJK();
    }

    public static void Initializer()
    {
        MyClass2 myClass2 = new MyClass2(32, "Johann");
        System.out.println(myClass2.myInt);
        System.out.println(myClass2.myString);
    }

    public static void GetterSetter()
    {
        // C# does not require Getters and Setters, Java does not have them, Ruby and VBA require them

        MyClass3 myClass3 = new MyClass3();
        myClass3.setMyInt(1);
        System.out.println(myClass3.getMyInt());
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
    public MyClass2(int myInt, String myString)
    {
        this.myInt = myInt;
        this.myString = myString;
    }

    public int myInt;
    public String myString;
}

class MyClass3
{
    private int _myInt;

    public int getMyInt()
    {
        return _myInt + 5;
    }
    
    public void setMyInt(int myInt)
    {
        _myInt = myInt + 5;
    }
}

class ListJK extends ArrayList<Integer>
{
    public ListJK()
    {
    }

    public ListJK (int[] input)
    {
        for (int singleInt : input)
            super.add(singleInt);
    }

    public void SortJK()
    {
        int maximumNumber = 0;
        int finalCounter = 0;

        for (int i=0;i<super.size();i++)
            if (super.get(i) > maximumNumber)
                maximumNumber = super.get(i);

        int[] finalArray = new int[maximumNumber + 1];

        for (int i=0;i<super.size();i++)
            ++finalArray[super.get(i)];

        for (int i=0;i<finalArray.length;i++)
            for (int j=0;j<finalArray[i];j++)
                super.set(finalCounter++, i);
    }

    public void PrintJK()
    {
        for (int i=0;i<super.size();i++)
            System.out.print(super.get(i) + " ");
        
        System.out.println();
    }
}
