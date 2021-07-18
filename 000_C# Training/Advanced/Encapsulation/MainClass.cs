using System;
using System.Collections.Generic;

namespace MyProject
{
    class MainClass
    {
        public static void Main()
        {
            List<int> myList = new List<int>();
            DataContainer data = new DataContainer(myList);

            Console.WriteLine(myList.Count);
            Console.WriteLine(data.MyListCount);

            myList.Add(34);

            Console.WriteLine(myList.Count);
            Console.WriteLine(data.MyListCount);            
        }
    }
}