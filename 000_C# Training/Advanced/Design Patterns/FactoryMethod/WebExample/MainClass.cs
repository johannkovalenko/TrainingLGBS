using System;

class MainClass
{
    static void Main()
    {
        // IFactory[] factories = new IFactory[]
        // {
        //     new ConcreteCreatorA(),
        //     new ConcreteCreatorB()
        // };

        // foreach (IFactory factory in factories)
        // {
        //     IClass concreteClass = factory.BuildClass();
        //     Console.WriteLine(concreteClass.Run());
        // }

        IClass concreteClass = new ConcreteCreatorA().BuildClass();
        Console.WriteLine(concreteClass.Run());
    }
}