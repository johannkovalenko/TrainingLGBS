using System;

class MainClass
{
    static void Main()
    {
        Client(new ConcreteFactory1());
        Client(new ConcreteFactory2());
    }

    static void Client(IFactory factory)
    {
        IClassOne classOne = factory.BuildClassOne();

        Console.WriteLine(classOne.Run());
    }
}