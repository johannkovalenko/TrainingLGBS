import java.util.ArrayList;
import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
    {
        CreateAndFillList();

        ArrayList<Integer> myIntList = CreateAndFillListAndReturnIt();

        CheckIfItemExists();

        LoopThroughAllElementsOfList(myIntList);
        
        ArrayList<Integer[]> myNestedIntList = CreateAndFillNestedList();

        LoopThroughAllElementsOfNestedList(myNestedIntList);

        Exercise_EliminateDoubleAppearances();

        Pitfall_1();
        
        new Scanner(System.in).nextLine();
    }

    public static void CreateAndFillList()
    {
        ArrayList<Integer> myIntList = new ArrayList<Integer>();
        ArrayList<String> myStringList = new ArrayList<String>();

        myIntList.add(34);
        myIntList.add(34);

        for (int i=5;i<8;i++)
            myIntList.add(i);

        myStringList.add("34");
        myStringList.add("34");

        for (int i=5;i<8;i++)
            myStringList.add(Integer.toString(i));
    }

    public static ArrayList<Integer> CreateAndFillListAndReturnIt()
    {
        ArrayList<Integer> myIntList = new ArrayList<Integer>();

        myIntList.add(34);
        myIntList.add(34);

        for (int i=5;i<8;i++)
            myIntList.add(i);

        return myIntList;
    }

    public static void CheckIfItemExists()
    {
        ArrayList<Integer> myIntList = new ArrayList<Integer>();

        if (!myIntList.contains(45))
            myIntList.add(45);
    }

    public static void LoopThroughAllElementsOfList(ArrayList<Integer> myIntList)
    {
        for (int item : myIntList)
            System.out.println(item);

        for (int i=0;i<myIntList.size();i++)
            System.out.println(myIntList.get(i));
    }

    public static ArrayList<Integer[]> CreateAndFillNestedList()
    {
        ArrayList<Integer[]> myIntList = new ArrayList<Integer[]>();

        Integer[] tempInt;
        int testCounter = 0;

        for (int i=5;i<8;i++)
        {
            tempInt = new Integer[10];

            for (int j=0;j<10;j++)
            {
                ++testCounter;
                tempInt[j] = testCounter;
            }

            myIntList.add(tempInt);
        }

        return myIntList;
    }

    public static void LoopThroughAllElementsOfNestedList(ArrayList<Integer[]> myNestedIntList)
    {
        for (Integer[] itemArray : myNestedIntList)
            for (int item : itemArray)
                System.out.println(item);

        for (int j=0;j<myNestedIntList.size();j++)
            for (int i=0;i<myNestedIntList.get(j).length;i++)
                System.out.println(myNestedIntList.get(j)[i]);
    }

    public static void Exercise_EliminateDoubleAppearances()
    {
        Integer[] inputNumbers = new Integer[] {3, 7, 5, 5, 4, 3, 2, 7};
        ArrayList<Integer> outputList = new ArrayList<Integer>();

        for (int number : inputNumbers)
            if (!outputList.contains(number))
                outputList.add(number);

        for (int number : outputList)
            System.out.println(number);

    }

    public static void Pitfall_1()
    {
        ArrayList<Integer> myList = new ArrayList<Integer>();

        myList.add(100);
        myList.add(200);

        //OK
        System.out.println(myList.get(0));
        System.out.println(myList.get(1));

        //This will cause an error
        System.out.println(myList.get(100));
        System.out.println(myList.get(200));
    }

}