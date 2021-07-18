using System;

class MainClass
{
    public static void Main()
    {
        string myString = "Hello World";
        string myString2 = myString;

        Console.WriteLine(object.ReferenceEquals(myString, myString2));

        myString2 += "New World";

        Console.WriteLine(object.ReferenceEquals(myString, myString2));

    }
}
