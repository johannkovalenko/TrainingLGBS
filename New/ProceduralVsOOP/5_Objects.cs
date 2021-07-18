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
    public string myStr = "";
    public int myInt = 0;
}    

namespace Prod
{
    class Main
    {
        public static List<int> list = new List<int>();
        public static List<DB> listDB = new List<DB>();

        public static void Run()
        {
            listDB.Add(new DB());
            listDB.Add(new DB());

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
            Main.listDB[0].myStr = "aaa";
            Main.listDB[1].myStr = "bbb";
            Main.listDB[0].myInt = 10;
            Main.listDB[1].myInt = 11;
        }

        public static void Run2()
        {
            for (int i = 0; i<10; i++)
                Main.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            foreach (DB db in Main.listDB)
                Console.WriteLine(db.myStr + db.myInt);
        }

        public static void Run2()
        {
            foreach (int val in Main.list)
                Console.WriteLine(val);
        }
    }
}

namespace Test
{
    class Main
    {
        public static List<int> list = new List<int>();
        public static List<DB> listDB = new List<DB>();   

        public static void Run()
        {
            listDB.Add(new DB());
            listDB.Add(new DB());

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
            Main.listDB[0].myStr = "aaa";
        }

        public static void Run2()
        {
            Main.list.Add(0);
        }
    }

    class Read
    {
        public static void Run1()
        {
            Console.WriteLine(Main.listDB[0].myStr);
        }

        public static void Run2()
        {
            if (Main.list.Count > 0)
                Console.WriteLine(Main.list[0]);
        }
    }
}