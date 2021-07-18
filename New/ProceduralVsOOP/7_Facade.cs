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
        public static void Run()
        {
            Prod.TypeListDB.Facade.Start();
            Prod.TypeList.Facade.Start();
        }
    }
}

namespace Prod.TypeListDB
{
    class Facade
    {
        public static List<DB> listDB = new List<DB>();

        public static void Start()
        {
            Add.Run();
            Read.Run();
        }
    }

    class Add
    {
        public static void Run()
        {
            DB db = new DB();
            db.myStr = "aaa";
            db.myInt = 10;
            Facade.listDB.Add(db);

            db = new DB();
            db.myStr = "bbb";
            db.myInt = 11;
            Facade.listDB.Add(db);
        }
    }

    class Read
    {
        public static void Run()
        {
            foreach (DB db in Facade.listDB)
                Console.WriteLine(db.myStr + db.myInt);
        }
    }
}

namespace Prod.TypeList
{
    class Facade
    {
        public static List<int> list = new List<int>();

        public static void Start()
        {
            Add.Run();
            Read.Run();
        }
    }

    class Add
    {
        public static void Run()
        {
            for (int i = 0; i<10; i++)
                Facade.list.Add(0);
        }
    }

    class Read
    {
        public static void Run()
        {
            foreach (int val in Facade.list)
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
            Prod.TypeListDB.Facade.Start();
            Prod.TypeList.Facade.Start();
        }
    }
}

namespace Test.TypeListDB
{
    class Facade
    {
        public static List<DB> listDB = new List<DB>();

        public static void Start()
        {
            Add.Run();
            Read.Run();
        }
    }

    class Add
    {
        public static void Run()
        {
            DB db = new DB();
            db.myStr = "aaa";
            Facade.listDB.Add(db);
        }
    }

    class Read
    {
        public static void Run()
        {
            Console.WriteLine(Facade.listDB[0].myStr);
        }
    }
}

namespace Test.TypeList
{
    class Facade
    {
        public static List<int> list = new List<int>();

        public static void Start()
        {
            Add.Run();
            Read.Run();
        }
    }

    class Add
    {
        public static void Run()
        {
            Facade.list.Add(0);
        }
    }

    class Read
    {
        public static void Run()
        {
            if (Facade.list.Count > 0)
                Console.WriteLine(Facade.list[0]);
        }
    }
}