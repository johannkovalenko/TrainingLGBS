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

namespace ITypeListDB
{
    interface IAdd
    {
        void Run(List<DB> listDB);
    }

    interface IRead
    {
        void Run(List<DB> listDB);
    }
}

namespace ITypeList
{
    public interface IAdd
    {
        void Run(List<int> list);
    }

    public interface IRead
    {
        void Run(List<int> list);
    }
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
        static List<DB> listDB = new List<DB>();

        public static void Start()
        {
            ITypeListDB.IAdd add = new Add();
            ITypeListDB.IRead read = new Read();

            add.Run(listDB);
            read.Run(listDB);
        }
    }

    class Add : ITypeListDB.IAdd
    {
        public void Run(List<DB> listDB)
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
    }

    class Read : ITypeListDB.IRead
    {
        public void Run(List<DB> listDB)
        {
            foreach (DB db in listDB)
                Console.WriteLine(db.myStr + db.myInt);
        }
    }
}

namespace Prod.TypeList
{
    class Facade
    {
        static List<int> list = new List<int>();

        public static void Start()
        {
            ITypeList.IAdd add = new Add();
            ITypeList.IRead read = new Read();

            add.Run(list);
            read.Run(list);
        }
    }

    class Add : ITypeList.IAdd
    {
        public void Run(List<int> list)
        {
            for (int i = 0; i<10; i++)
                list.Add(0);
        }
    }

    class Read : ITypeList.IRead
    {
        public void Run(List<int> list)
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
            Prod.TypeListDB.Facade.Start();
            Prod.TypeList.Facade.Start();
        }
    }
}

namespace Test.TypeListDB
{
    class Facade
    {
        static List<DB> listDB = new List<DB>();

        public static void Start()
        {
            ITypeListDB.IAdd add = new Add();
            ITypeListDB.IRead read = new Read();

            add.Run(listDB);
            read.Run(listDB);
        }
    }

    class Add : ITypeListDB.IAdd
    {
        public void Run(List<DB> listDB)
        {
            DB db = new DB();
            db.myStr = "aaa";
            listDB.Add(db);
        }
    }

    class Read : ITypeListDB.IRead
    {
        public void Run(List<DB> listDB)
        {
            Console.WriteLine(listDB[0].myStr);
        }
    }
}

namespace Test.TypeList
{
    class Facade
    {
        static List<int> list = new List<int>();

        public static void Start()
        {
            ITypeList.IAdd add = new Add();
            ITypeList.IRead read = new Read();

            add.Run(list);
            read.Run(list);
        }
    }

    class Add : ITypeList.IAdd
    {
        public void Run(List<int> list)
        {
            list.Add(0);
        }
    }

    class Read : ITypeList.IRead
    {
        public void Run(List<int> list)
        {
            if (list.Count > 0)
                Console.WriteLine(list[0]);
        }
    }
}