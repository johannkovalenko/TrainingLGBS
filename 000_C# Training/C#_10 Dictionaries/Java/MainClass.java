import java.util.Map;
import java.util.HashMap;
import java.util.Scanner;
import java.util.Set;
import java.util.Iterator;

//import java.util.*; (import all methods at once)

class MainClass
{
    public static void main(String[] args)
    {
        CreateAndFillDictionary();

        HashMap<Integer, String> myIntStringDict = CreateAndFillDictionaryAndReturnIt();

        GetValueOfKey();

        OverwriteWhenItemExists();

        LoopThroughAllElementsOfList(myIntStringDict);
        
        HashMap<Integer, Integer[]> myNestedDictionary = CreateAndFillNestedDictionary();

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
        
        new Scanner(System.in).nextLine();
    }

    public static void CreateAndFillDictionary()
    {
        HashMap<Integer, String> myIntStringDict = new HashMap<Integer, String>();
        HashMap<String, Integer> myStringIntDict = new HashMap<String, Integer>();

        //Java and Ruby use hashes instead of dictionaries.
        // the main difference is that an existing hash is automatically overwritten

        myIntStringDict.put(34, "abc");   
        myIntStringDict.put(34, "abc"); 

        for (int i=5;i<7;i++)
            myIntStringDict.put(i, "abc");
 
        myStringIntDict.put("34", 111);  
        myStringIntDict.put("34", 111); 

        for (int i=5;i<7;i++)
            myStringIntDict.put(Integer.toString(i), 111);
    }

    public static HashMap<Integer, String> CreateAndFillDictionaryAndReturnIt()
    {
        HashMap<Integer, String> myIntStringDict = new HashMap<Integer, String>();

        myIntStringDict.put(34, "abc");   
        myIntStringDict.put(34, "abc"); 

        for (int i=5;i<7;i++)
            myIntStringDict.put(i, "abc");
 
        return myIntStringDict;
    }

    public static void GetValueOfKey()
    {
        // Always check if keys exists, if you don't, your program crashes, when trying to get an noexistent key
        
        HashMap<Integer, String> myIntStringDict = new HashMap<Integer, String>();
        String myString;

        myIntStringDict.put(34, "abc"); 

        if (myIntStringDict.containsKey(34))
        {
            myString = myIntStringDict.get(34);
            System.out.println(myString);
        }
    }

    public static void OverwriteWhenItemExists()
    {
        // obsolete in Java, example just to show, how to check if key exists

        HashMap<Integer, Integer> myIntIntDict = new HashMap<Integer, Integer>();

        myIntIntDict.put(45, 1);

        if (myIntIntDict.containsKey(45))
            myIntIntDict.put(45, 2);
        else
            myIntIntDict.put(45, 2);

        System.out.println(myIntIntDict.get(45));
    }

    public static void LoopThroughAllElementsOfList(HashMap<Integer, String> myIntStringDict)
    {
        System.out.println("Approach 1:");

        for (Integer item : myIntStringDict.keySet())
            System.out.println("Key: " + item + "\tValue: " + myIntStringDict.get(item));

        ////////////////////

        System.out.println("\r\nApproach 2:");

        for (Map.Entry<Integer, String> pair : myIntStringDict.entrySet())
            System.out.println("Key: " + pair.getKey() + "\tValue: " + pair.getValue());

        ////////////////////

        System.out.println("\r\nApproach 3:");

        Set set = myIntStringDict.entrySet();
        Iterator iEnumerator = set.iterator();
        Map.Entry pair2;

        while (iEnumerator.hasNext()) 
        {
           pair2 = (Map.Entry)iEnumerator.next();
           System.out.println("Key: " + pair2.getKey() + "\tValue: " + pair2.getValue());
        }
    }

    public static HashMap<Integer, Integer[]> CreateAndFillNestedDictionary()
    {
        HashMap<Integer, Integer[]> myNestedDictionary = new HashMap<Integer, Integer[]>();

        Integer[] tempInt;
        int testCounter = 0;

        for (int i=5;i<7;i++)
        {
            tempInt = new Integer[10];

            for (int j=0;j<10;j++)
            {
                ++testCounter;
                tempInt[j] = testCounter;
            }

            myNestedDictionary.put(i, tempInt);
        }

        return myNestedDictionary;
    }

    public static void LoopThroughAllElementsOfNestedDictionary(HashMap<Integer, Integer[]> myNestedDictionary)
    {
        for (Integer key : myNestedDictionary.keySet())
            for (Integer item : myNestedDictionary.get(key))
                System.out.println(item);
    }

    public static void OverwriteWhenItemExistsNested(HashMap<Integer, Integer[]> myNestedDictionary)
    {
        Integer[] tempInt;

        if (myNestedDictionary.containsKey(5))
        {
            tempInt = new Integer[] {3, 5, 6, 3, 2, 3};
            myNestedDictionary.put(5, tempInt);

            for (Integer testInt : myNestedDictionary.get(5))
                System.out.println(testInt);
        }
    }

    public static void ManipulateValueWhenItemExistsNested(HashMap<Integer, Integer[]> myNestedDictionary)
    {
        Integer[] tempInt;

        if (myNestedDictionary.containsKey(5))
        {
            tempInt = myNestedDictionary.get(5);
            tempInt[4] = 555;
            myNestedDictionary.put(5, tempInt);

            for (Integer testInt : myNestedDictionary.get(5))
                System.out.println(testInt);
        }
    }

    public static void Exercise_CountAppearances()
    {
        String[] inputNames = new String[] {"Pat", "Ann", "Paul", "Paul", "Joe", "Mike", "Pat", "Paul"};
        HashMap<String, Integer> outputDict = new HashMap<String, Integer>();

        for (String name : inputNames)
            if (!outputDict.containsKey(name))
                outputDict.put(name, 1);
            else
                outputDict.put(name, outputDict.get(name) + 1);

        for (String name : outputDict.keySet())
            System.out.println(name + "\t" + outputDict.get(name));

    }

    public static void Pitfall_1()
    {
        //Most problems connected to Dictionaries are due to the fact that dictionaries link by reference 

        HashMap<Integer, Integer[]> myDict = new HashMap<Integer, Integer[]>();
        Integer[] tempInt = new Integer[1];

        for (int i=0;i<3;i++)
        {
            tempInt[0] = i;
            myDict.put(i, tempInt);

            System.out.println();

            for (Integer key:myDict.keySet())
                System.out.println(myDict.get(key)[0]);

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
        HashMap<Integer, Integer[]> myDict = new HashMap<Integer, Integer[]>();
        Integer[] tempInt; 

        for (int i=0;i<3;i++)
        {
            tempInt = new Integer[1];
            tempInt[0] = i;
            myDict.put(i, tempInt);

            System.out.println();

            for (Integer key:myDict.keySet())
                System.out.println(myDict.get(key)[0]);

            //Expected output:  0, 0 1, 0 1 2
            //Real output:      0, 0 1, 0 1 2

            //Explanation: now there are three addresses (three instances) of "tempInt"
            //so any change in one instance of "tempInt" does not affect the rest of instances
        }
    }

    public static void Pitfall_2()
    {
        HashMap<Integer, Integer[]> myDict = new HashMap<Integer, Integer[]>();

        myDict.put(0, new Integer[] {0});
        myDict.put(1, new Integer[] {1});

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.put(1, myDict.get(0));

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.get(0)[0] = 9;       

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.get(1)[0] = 8;

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        //Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        //Real outputs:         0   1   |   0   0   |   9   9   |   8   8

        //When copying one entry to another, suddenly every further change in ANY value affects both entries.
        //Explanation: when copying one entry to another, we ONLY copy the address
        // -> both entries now point to the same address in memory
        // -> any change in the address pointed to affects both entries. 

    }

    public static void Solution_Pitfall_2()
    {
        HashMap<Integer, Integer[]> myDict = new HashMap<Integer, Integer[]>();

        myDict.put(0, new Integer[] {0});
        myDict.put(1, new Integer[] {1});

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.put(1, (Integer[])myDict.get(0).clone());

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.get(0)[0] = 9;       

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        myDict.get(1)[0] = 8;

        System.out.println(myDict.get(0)[0]);
        System.out.println(myDict.get(1)[0]);

        //Expected outputs:     0   1   |   0   0   |   9   0   |   9   8
        //Real outputs:         0   1   |   0   0   |   9   0   |   9   8

        //Explanation: when cloning an array, a copy of the array under a NEW ADDRESS is created
        // -> every entries now points to a different address in memory
        // -> any change in one address does not affect the other address. 

    }

    public static void Pitfall_3()
    {
        HashMap<Integer, Integer[]> myDict = new HashMap<Integer, Integer[]>();

        myDict.put(0, new Integer[] {0});

        System.out.println(myDict.get(0)[0]);
        
        Pitfall_3_Helper(myDict);

        System.out.println(myDict.get(0)[0]);

        //Expected outputs:     0   0
        //Real output:          0   9

        //When calling a function with parameter (which is NOT by reference), we expect no change in the original dictionary
        //But the dictionary calls to the address of the  Integer[]
        //so no matter where we change the  Integer[], it will always affect the whole dictionary
        //(which is actually a very good behavior, nobodys wants to copy dictionaries)

    }

    public static void Solution_Pitfall_3()
    {
        HashMap<Integer, Integer[]> myDict       = new HashMap<Integer, Integer[]>();
        HashMap<Integer, Integer[]> myDictCopy   = new HashMap<Integer, Integer[]>(myDict);

        myDict.put(0, new Integer[] {0});

        System.out.println(myDict.get(0)[0]);
        
        Pitfall_3_Helper(myDictCopy);

        System.out.println(myDict.get(0)[0]);

        //Expected outputs:     0   0
        //Real output:          0   0

        //By copying the whole dictionary, a second address is created
        //a change in one address does not affect the second address
    }

    public static void Pitfall_3_Helper(HashMap<Integer, Integer[]> myDict)
    {
        myDict.put(0, new Integer[] {9});
    }
}