using System.Collections.Generic;
using System;

namespace Procedural
{
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
                    Prod();
                    break;
                case "test":
                    Test();
                    break;
            }
        }

        // Prod

        public static void Prod()
        {
            Add1();
            Add2();
            Read1();
            Read2();
        }

        public static void Add1()
        {
            myStr1 = "aaa";
            myStr2 = "bbb";
            myInt1 = 10;
            myInt2 = 11;
        }

        public static void Add2()
        {
            for (int i = 0; i<10; i++)
                list.Add(0);
        }

        public static void Read1()
        {
            Console.WriteLine(myStr1 + myStr2 + myInt1 + myInt2);
        }

        public static void Read2()
        {
            foreach (int val in list)
                Console.WriteLine(val);
        }

        //Test 

        public static void Test()
        {
            Add1Test();
            Add2Test();
            Read1Test();
            Read2Test();
        }

        public static void Add1Test()
        {
            myStr1 = "aaa";
        }

        public static void Read1Test()
        {
            Console.WriteLine(myStr1);
        }

        public static void Add2Test()
        {
            list.Add(0);
        }

        public static void Read2Test()
        {
            if (list.Count > 0)
                Console.WriteLine(list[0]);
        }
    }
}