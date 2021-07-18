using System.Collections.Generic;
using System;


class MainClass
{
    static void Main(string[] args)
    {
        IFactory factory = GetFactory(args[0]);

        Facade.TypeListDB.Start(factory.typeListDBAdd, factory.typeListDBRead);
        Facade.TypeList.Start(factory.typeListAdd, factory.typeListRead);
    }

    static IFactory GetFactory(string mode)
    {
        switch (mode)
        {
            case "prod":
                return new FactoryProd();
            default:
                return new FactoryTest();
        }
    }
}

interface IFactory
{
    ITypeListDB.IAdd typeListDBAdd      {get; set;}
    ITypeListDB.IRead typeListDBRead    {get; set;}
    ITypeList.IAdd typeListAdd          {get; set;}
    ITypeList.IRead typeListRead        {get; set;}
}

class FactoryProd : IFactory
{
    public ITypeListDB.IAdd typeListDBAdd   {get; set;}
    public ITypeListDB.IRead typeListDBRead {get; set;}
    public ITypeList.IAdd typeListAdd       {get; set;}
    public ITypeList.IRead typeListRead     {get; set;}

    public FactoryProd()
    {
        typeListDBAdd  = new Prod.TypeListDB.Add();
        typeListDBRead = new Prod.TypeListDB.Read();
        typeListAdd    = new Prod.TypeList.Add();
        typeListRead   = new Prod.TypeList.Read();
    }
}

class FactoryTest : IFactory
{
    public ITypeListDB.IAdd typeListDBAdd   {get; set;}
    public ITypeListDB.IRead typeListDBRead {get; set;}
    public ITypeList.IAdd typeListAdd       {get; set;}
    public ITypeList.IRead typeListRead     {get; set;}

    public FactoryTest()
    {
        typeListDBAdd       = new Test.TypeListDB.Add();
        typeListDBRead      = new Test.TypeListDB.Read();
        typeListAdd         = new Test.TypeList.Add();
        typeListRead        = new Test.TypeList.Read();
    }
}

class DB
{
    public string myStr = "";
    public int myInt = 0;
}

namespace Facade
{
    class TypeListDB
    {
        static List<DB> listDB = new List<DB>();

        public static void Start(ITypeListDB.IAdd add, ITypeListDB.IRead read)
        {
            add.Run(listDB);
            read.Run(listDB);
        }
    }

    class TypeList
    {
        static List<int> list = new List<int>();

        public static void Start(ITypeList.IAdd add, ITypeList.IRead read)
        {
            add.Run(list);
            read.Run(list);
        }
    }
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

namespace Prod.TypeListDB
{
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



namespace Test.TypeListDB
{
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