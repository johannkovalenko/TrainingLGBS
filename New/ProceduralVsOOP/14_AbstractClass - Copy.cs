using System.Collections.Generic;
using System;


class MainClass
{
    static void Main(string[] args)
    {
        IFactory factory = GetFactory(args[0]);

        Carsection.Bodywork.Start(factory.bodyworkDesign, factory.bodyworkInstall);
        Carsection.Chassis.Start(factory.chassisDesign, factory.chassisInstall);
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

abstract class IFactory
{
    protected IBodywork.IDesign bodyworkDesign;
    protected IBodywork.IInstall bodyworkInstall;
    protected IChassis.IDesign chassisDesign;
    protected IChassis.IInstall chassisInstall;
}

class FactoryProd : IFactory
{
    public FactoryProd()
    {
        base.bodyworkDesign  = new Prod.Bodywork.Design();
        base.bodyworkInstall = new Prod.Bodywork.Install();
        base.chassisDesign    = new Prod.Chassis.Design();
        base.chassisInstall   = new Prod.Chassis.Install();
    }
}

class FactoryTest : IFactory
{
    public FactoryTest()
    {
        base.bodyworkDesign       = new Test.Bodywork.Design();
        base.bodyworkInstall      = new Test.Bodywork.Install();
        base.chassisDesign         = new Test.Chassis.Design();
        base.chassisInstall        = new Test.Chassis.Install();
    }
}

class DB
{
    public string myStr = "";
    public int myInt = 0;
}

namespace Carsection
{
    class Bodywork
    {
        static List<DB> listDB = new List<DB>();

        public static void Start(IBodywork.IDesign design, IBodywork.IInstall install)
        {
            design.Run(listDB);
            install.Run(listDB);
        }
    }

    class Chassis
    {
        static List<int> list = new List<int>();

        public static void Start(IChassis.IDesign design, IChassis.IInstall install)
        {
            design.Run(list);
            install.Run(list);
        }
    }
}

namespace IBodywork
{
    interface IDesign
    {
        void Run(List<DB> listDB);
    }

    interface IInstall
    {
        void Run(List<DB> listDB);
    }
}

namespace IChassis
{
    public interface IDesign
    {
        void Run(List<int> list);
    }

    public interface IInstall
    {
        void Run(List<int> list);
    }
}

namespace Prod.Bodywork
{
    class Design : IBodywork.IDesign
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

    class Install : IBodywork.IInstall
    {
        public void Run(List<DB> listDB)
        {
            foreach (DB db in listDB)
                Console.WriteLine(db.myStr + db.myInt);
        }
    }
}

namespace Prod.Chassis
{
    class Design : IChassis.IDesign
    {
        public void Run(List<int> list)
        {
            for (int i = 0; i<10; i++)
                list.Add(0);
        }
    }

    class Install : IChassis.IInstall
    {
        public void Run(List<int> list)
        {
            foreach (int val in list)
                Console.WriteLine(val);
        }
    }
}

namespace Test.Bodywork
{
    class Design : IBodywork.IDesign
    {
        public void Run(List<DB> listDB)
        {
            DB db = new DB();
            db.myStr = "aaa";
            listDB.Add(db);
        }
    }

    class Install : IBodywork.IInstall
    {
        public void Run(List<DB> listDB)
        {
            Console.WriteLine(listDB[0].myStr);
        }
    }
}

namespace Test.Chassis
{
    class Design : IChassis.IDesign
    {
        public void Run(List<int> list)
        {
            list.Design(0);
        }
    }

    class Install : IChassis.IInstall
    {
        public void Run(List<int> list)
        {
            if (list.Count > 0)
                Console.WriteLine(list[0]);
        }
    }
}