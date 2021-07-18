using System.Collections.Generic;
using System;


class MainClass
{
    public static List<int> list = new List<int>();
    public static List<DB> listDB = new List<DB>();

    static void Main(string[] args)
    {
        listDB.Add(new DB());
        listDB.Add(new DB());

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
    public string myStr = "";
    public int myInt = 0;
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
            MainClass.listDB[0].myStr = "aaa";
            MainClass.listDB[1].myStr = "bbb";
            MainClass.listDB[0].myInt = 10;
            MainClass.listDB[1].myInt = 11;
        }

        public static void Run2()
        {
            for (int i = 0; i<10; i++)
                MainClass.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            foreach (DB db in MainClass.listDB)
                Console.WriteLine(db.myStr + db.myInt);
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
            MainClass.listDB[0].myStr = "aaa";
        }

        public static void Run2()
        {
            MainClass.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            Console.WriteLine(MainClass.listDB[0].myStr);
        }

        public static void Run2()
        {
            if (MainClass.list.Count > 0)
                Console.WriteLine(MainClass.list[0]);
        }
    }
}