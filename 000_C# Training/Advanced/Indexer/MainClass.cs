using System;

class MainClass
{
    static void Main()
    {
        var myArrayClass = new MyArrayClass();

        myArrayClass[0] = "AAA";
        Console.WriteLine(myArrayClass[0]);
    }
}