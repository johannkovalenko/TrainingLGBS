import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
    {
        ForLoop_ZeroToNine();
        ForLoop_OneToTen();
        ForLoop_NineToZero();
        ForLoop_JumpTwo();
        LoopWhile();
        LoopWhile_AtLeastOneIteration();
        EndlessLoopWithEmergencyExit();
        ForEach();
        DeFactoForEach();
        ForEachCharInString();
        DefactoForEachCharInString();

        new Scanner(System.in).nextLine();
    }

    public static void ForLoop_ZeroToNine()
    {
        for (int i=0; i<10; i++)
        {
            System.out.println(i);
        }
    }

    public static void ForLoop_OneToTen()
    {
        for (int i=1; i<11; i++)
        {
            System.out.println(i);
        }
    }

    public static void ForLoop_NineToZero()
    {
        for (int i = 9;i>=0;i--)
            System.out.println(i);
    }

    public static void ForLoop_JumpTwo()
    {
        for (int i=0;i<10;i+=2)
            System.out.println(i);
    }


    public static void LoopWhile()
    {
        int i = 0;

        while (i < 10)
        {
            System.out.println(i);
            i++;  
        }
    }

    public static void LoopWhile_AtLeastOneIteration()
    {
        int i = 10;

        do
        {
            System.out.println(i);
            i++;  
        }
        while (i < 10);
    }

    public static void EndlessLoopWithEmergencyExit()
    {
        int i = 0;

        while (true)
        {
            i++;
            System.out.println(i);
            
            if (i > 100)
                break;
        }
    }

    public static void ForEach()
    {
        String[] myArray = new String[] {"abc", "def", "ghi", "jkl"};

        for (String mySingleString : myArray)
        {
            System.out.println(mySingleString);
        }

        //Short version when only one-liner
        for (String mySingleString : myArray)
            System.out.println(mySingleString);       
    }

    public static void DeFactoForEach()
    {
        String[] myArray = new String[] {"abc", "def", "ghi", "jkl"};

        for (int i=0;i<myArray.length;i++)
            System.out.println(myArray[i]);
    }

    public static void ForEachCharInString()
    {
        String myString = "LGBSMNLKRK";

        for (char singleChar : myString.toCharArray())
            System.out.println(singleChar);
    }

    public static void DefactoForEachCharInString()
    {
        String myString = "LGBSMNLKRK";

        for (int i=0;i<myString.length();i++)
            System.out.println(myString.charAt(i));
    }
}