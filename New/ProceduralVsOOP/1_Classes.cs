using System.Collections.Generic;
using System;

class MainClass
{
    public static string myStr1 = "";
    public static string myStr2 = "";
    public static int myInt1 = 0;
    public static int myInt2 = 0;

    public static List<int> list = new List<int>();

    public static void Main1(string[] args)
    {
        switch (args[0])
        {
            case "prod":
                Prod.Main.Run();
                break;
            case "test":
                Test.Main.Run();
                break;
        }
    }
}


namespace Prod
{
    public class Main
    {
        public static void Run()
        {
            Add.Run1();
            Add.Run2();
            Read.Run1();
            Read.Run2();
        }
    }

    public class Add
    {
        public static void Run1()
        {
            MainClass.myStr1 = "aaa";
            MainClass.myStr2 = "bbb";
            MainClass.myInt1 = 10;
            MainClass.myInt2 = 11;
        }

        public static void Run2()
        {
            for (int i = 0; i<10; i++)
                MainClass.list.Add(0);
        }
    }

    public class Read
    {
        public static void Run1()
        {
            Console.WriteLine(MainClass.myStr1 + MainClass.myStr2 + MainClass.myInt1 + MainClass.myInt2);
        }

        public static void Run2()
        {
            foreach (int val in MainClass.list)
                Console.WriteLine(val);
        }
    }
}

namespace Test
{
    public class Main
    {
        public static void Run()
        {
            Add.Run1();
            Add.Run2();
            Read.Run1();
            Read.Run2();
        }
    }

    public class Add
    {
        public static void Run1()
        {
            MainClass.myStr1 = "aaa";
        }

        public static void Run2()
        {
            MainClass.list.Add(0);
        }
    }

    public class Read
    {
        public static void Run1()
        {
            Console.WriteLine(MainClass.myStr1);
        }

        public static void Run2()
        {
            if (MainClass.list.Count > 0)
                Console.WriteLine(MainClass.list[0]);
        }
    }
}