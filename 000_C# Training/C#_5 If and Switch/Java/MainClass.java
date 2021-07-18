import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
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

        new Scanner(System.in).nextLine();
    }

    public static void IfInstruction()
    {
        String x = "abc";
        String y = "";

        if (x.equals("abc")) //Attention: x == "abc" does something else, always use equals
        {
            y = "Good";
        }
        else if (x.equals("def"))
        {
            y = "Not Good";
        }
        else
        {
            y = "Indifferent";
        }

        System.out.println(y);
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

        System.out.println(y);
    }

    public static void IfShort_OnlyWhenOneLiners()
    {
        String x = "abc";
        String y = "";

        if (x.equals("abc"))
            y = "Good";
        else if (x.equals("def"))
            y = "Not Good";
        else if (x.equals("ghi"))
        {
            x = x + "jkl";
            y = x;
        }
        else
            y = "Indifferent";

        System.out.println(y);
    }

    public static void IfAndOr()
    {
        int x = 20;
        int y = 30;

        if (x == 20 && y == 40)
            System.out.println("TRUE");
        else
            System.out.println("FALSE");

        if (x == 20 || y == 40)
            System.out.println("TRUE");
        else
            System.out.println("FALSE");
    }

    public static void NotEqual()
    {
        int x = 20;

        if (x != 20)
            System.out.println("TRUE");
        else
            System.out.println("FALSE");
    }

    public static void Not_Instruction()
    {
        boolean x = true;

        if (x == true)
            System.out.println("a");

        if (x)
            System.out.println("a");

        if (x == false)
            System.out.println("b");
        
        if (!x)
            System.out.println("b");
    }

    public static void Not_Instruction2()
    {
        String x = "abc";

        if (x.contains("b"))
            System.out.println("a");

        if (!x.contains("f"))
            System.out.println("b");

    }

    public static void Not_Instruction3()
    {
        String x = "abc";

        boolean trueFalse = x == "abc";

        if (trueFalse)
            System.out.println("a");

        if (!trueFalse)
            System.out.println("b");
    }

    public static void Switch_Instruction()
    {
        int y = 30;

        switch (y)
        {
            case 24:
                System.out.println("Is 24");
                break;
            case 30:
                System.out.println("Is 30");
                break;
            case 35:
            case 36:
                System.out.println("Is 35 or 36");
                break;
            default:
                System.out.println("Is something else");
                break;
        }
    }

}