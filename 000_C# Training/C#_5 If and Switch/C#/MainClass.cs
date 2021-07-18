using System;

class MainClass
{
    public static void Main()
    {
        IfInstruction();
        IfInstruction2();
        IfShort_OnlyWhenOneLiners();
        IfAndOr();
        NotEqual();
        Not_Instruction();
        Not_Instruction2();
        Not_Instruction3();
        Switch_Instruction();


        Console.ReadLine();
    }

    public static void IfInstruction()
    {
        string x = "abc";
        string y = "";

        if (x == "abc")
        {
            y = "Good";
        }
        else if (x == "def")
        {
            y = "Not Good";
        }
        else
        {
            y = "Indifferent";
        }

        Console.WriteLine(y);
    }

    public static void IfInstruction2()
    {
        int x = 23;
        int y = 0;

        if (x <= 30)
        {
            y = x * 2;
        }
        else if (x <= 50)
        {
            y = x * 3;
        }
        else
        {
            y = x * 4;
        }

        Console.WriteLine(y);
    }

    public static void IfShort_OnlyWhenOneLiners()
    {
        string x = "abc";
        string y = "";

        if (x == "abc")
            y = "Good";
        else if (x == "def")
            y = "Not Good";
        else if (x == "ghi")
        {
            x = x + "jkl";
            y = x;
        }
        else
            y = "Indifferent";

        Console.WriteLine(y);
    }

    public static void IfAndOr()
    {
        int x = 20;
        int y = 30;

        if (x == 20 && y == 40)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");

        if (x == 20 || y == 40)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");
    }

    public static void NotEqual()
    {
        int x = 20;

        if (x != 20)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");
    }

    public static void Not_Instruction()
    {
        bool x = true;

        if (x == true)
            Console.WriteLine("a");

        if (x)
            Console.WriteLine("a");

        if (x == false)
            Console.WriteLine("b");
        
        if (!x)
            Console.WriteLine("b");
    }

    public static void Not_Instruction2()
    {
        string x = "abc";

        if (x.Contains("b"))
            Console.WriteLine("a");

        if (!x.Contains("f"))
            Console.WriteLine("b");

    }

    public static void Not_Instruction3()
    {
        string x = "abc";

        bool trueFalse = x == "abc";

        if (trueFalse)
            Console.WriteLine("a");

        if (!trueFalse)
            Console.WriteLine("b");
    }

    public static void Switch_Instruction()
    {
        int y = 30;

        switch (y)
        {
            case 24:
                Console.WriteLine("Is 24");
                break;
            case 30:
                Console.WriteLine("Is 30");
                break;
            case 35:
            case 36:
                Console.WriteLine("Is 35 or 36");
                break;
            default:
                Console.WriteLine("Is something else");
                break;
        }
    }

}