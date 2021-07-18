using System.Collections.Generic;
using System;


class MainClass
{
    static void Main(string[] args)
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

class DB
{
    public static string myStr1 = "";
    public static string myStr2 = "";
    public static int myInt1 = 0;
    public static int myInt2 = 0;

    public static List<int> list = new List<int>();
}    

namespace Prod
{
    class Main
    {
        public static void Run()
        {
            Add.Run1();
            Add.Run2();
            Read.Run1();
            Read.Run2();
        }
    }

    class Add
    {
        public static void Run1()
        {
            DB.myStr1 = "aaa";
            DB.myStr2 = "bbb";
            DB.myInt1 = 10;
            DB.myInt2 = 11;
        }

        public static void Run2()
        {
            for (int i = 0; i<10; i++)
                DB.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            Console.WriteLine(DB.myStr1 + DB.myStr2 + DB.myInt1 + DB.myInt2);
        }

        public static void Run2()
        {
            foreach (int val in DB.list)
                Console.WriteLine(val);
        }
    }
}

namespace Test
{
    class Main
    {
        public static void Run()
        {
            Add.Run1();
            Add.Run2();
            Read.Run1();
            Read.Run2();
        }
    }

    class Add
    {
        public static void Run1()
        {
            DB.myStr1 = "aaa";
        }

        public static void Run2()
        {
            DB.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            Console.WriteLine(DB.myStr1);
        }

        public static void Run2()
        {
            if (DB.list.Count > 0)
                Console.WriteLine(DB.list[0]);
        }
    }
}