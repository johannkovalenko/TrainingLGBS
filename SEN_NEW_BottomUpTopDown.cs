// Solutions at the bottom

using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        // new Exercise_1.App().Main();
        new Exercise_7c.App().Main();
    }
}

namespace Exercise_1
{
    // What will be the results of kia.Print() and hyundai.Print()?
    // Is Inheritance a bottom-up approach or a top-down approach?


    public class App
    {
        public void Main()
        {
            var kia     = new Kia();
            var hyundai = new Hyundai();

            for (int i=0; i<5; i++)
            {
                kia.Run();
                hyundai.Run();
            }

            kia.Print();
            Console.WriteLine("---");
            hyundai.Print();
        }
    }

    class BasicObject
    {
        List<string> counter = new List<string>();

        protected void Add(string sender)
        {
            counter.Add(sender);
        } 

        protected void BasePrint()
        {
            foreach (string item in counter)
                Console.WriteLine(item);
        }
    }

    class Kia : BasicObject
    {
        public void Run()
        {
            // 10 lines Kia logic
            base.Add("Kia");
        }

        public void Print()
        {
            base.BasePrint();
        }
    }

    class Hyundai : BasicObject
    {
        public void Run()
        {
            // 10 lines Hyundai logic
            Add("Hyundai");
        }
    
        public void Print()
        {
            BasePrint();
        }
    }
}

namespace Exercise_2
{
    // What will be the results of kia.Print() and hyundai.Print()?
    // Is this a bottom-up approach or a top-down approach?

    public class App
    {
        public void Main()
        {
            var basicObject = new BasicObject();

            var kia     = new Kia(basicObject);
            var hyundai = new Hyundai(basicObject);

            for (int i=0; i<5; i++)
            {
                kia.Run();
                hyundai.Run();
            }

            kia.Print();
            Console.WriteLine("---");
            hyundai.Print();
        }
    }

    class BasicObject
    {
        List<string> counter = new List<string>();

        public void Add(string sender)
        {
            counter.Add(sender);
        } 

        public void BasePrint()
        {
            foreach (string item in counter)
                Console.WriteLine(item);
        }
    }

    class Kia
    {
        BasicObject basicObject;

        public Kia(BasicObject basicObject)
        {
            this.basicObject = basicObject;
        }

        public void Run()
        {
            // 10 lines Kia logic
            basicObject.Add("Kia");
        }

        public void Print()
        {
            basicObject.BasePrint();
        }
    }

    class Hyundai : BasicObject
    {
        BasicObject basicObject;

        public Hyundai(BasicObject basicObject)
        {
            this.basicObject = basicObject;
        }

        public void Run()
        {
            // 10 lines Hyundai logic
            basicObject.Add("Hyundai");
        }
    
        public void Print()
        {
            basicObject.BasePrint();
        }
    }
}