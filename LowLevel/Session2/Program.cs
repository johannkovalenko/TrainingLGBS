using System;
using System.Collections;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do();

            int x; // Definicja, Deklaracja (Initialization?)
            x = 0; //
            //x = null; -> Cofanie deklaracji nie możliwe w stosie

            int y = 1; // Definicja, Deklarcja, Initialization
            y = 5; // przypisanie assignment

            MyClass myClass; // Definicja, Deklarcja

            myClass = new MyClass(); // new = instancjcja (funkcja, która zwraca adres na stercie); assignment

            // 0 vs null
            Console.WriteLine(x);
            Console.WriteLine(myClass == null);

            //new MyClass().Change();
        }

        static void Do()
        {
            int x = 0;

            Do();
        }
    }

    class MyClass
    {
        private readonly int x = 0; // Initialization

        public MyClass()
        {
            x = 3; // wygląda jak assignment, jest to jednak intializacja
        }
        public void Change()
        {
            //x = 3; // Assignment
        }
    }


}
