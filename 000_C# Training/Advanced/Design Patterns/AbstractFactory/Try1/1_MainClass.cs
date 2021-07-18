using System;

class MainClass
{
    static void Main()
    {
        ClientMethod(new FactoryOne());
        ClientMethod(new FactoryTwo());
    }

    static void ClientMethod(IFactory factory)
    {
        IClassOne classOne = factory.GetClassOne();

        Console.WriteLine(classOne.Run());
    }
}