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
            TypeListDB.Add();
            TypeList.Add();
            TypeListDB.Read();
            TypeList.Read();
        }
    }

    class TypeListDB
    {
        static List<DB> listDB = new List<DB>();

        public static void Add()
        {
            DB db = new DB();
            db.myStr = "aaa";
            db.myInt = 10;
            listDB.Add(db);

            db = new DB();
            db.myStr = "bbb";
            db.myInt = 11;
            listDB.Add(db);
        }

        public static void Read()
        {
            foreach (DB db in listDB)
                Console.WriteLine(db.myStr + db.myInt);
        }
    }

    class TypeList
    {
        static List<int> list = new List<int>();
        
        public static void Add()
        {
            for (int i = 0; i<10; i++)
                list.Add(0);
        }

        public static void Read()
        {
            foreach (int val in list)
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
            TypeListDB.Add();
            TypeList.Add();
            TypeListDB.Read();
            TypeList.Read();
        }
    }

    class TypeListDB
    {
        static List<DB> listDB = new List<DB>();
        
        public static void Add()
        {
            DB db = new DB();
            db.myStr = "aaa";
            listDB.Add(db);
        }

        public static void Read()
        {
            Console.WriteLine(listDB[0].myStr);
        }
    }

    class TypeList
    {
        static List<int> list = new List<int>();
        
        public static void Add()
        {
            list.Add(0);
        }

        public static void Read()
        {
            if (list.Count > 0)
                Console.WriteLine(list[0]);
        }
    }
}