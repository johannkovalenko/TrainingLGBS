// What design pattern is shown below?
// Why did the author use an Abstract Class for the class "Factory" and not an Interface?
// What is the sense of using this design pattern?
// Please explain the difference in the abstract layer between "abstract class Factory" and "interface Step1/Step2"


using System;

class SEN_NEW_A
{
    public void Run()
    {
        bool mode = false;
        Factory factory = GetFactory(mode);
        
        factory.step1.Run();
        factory.step2.Run();
    }
    
    private Factory GetFactory(bool mode)
    {
        switch (mode)
        {
            case true:
                return new FactoryProd();
            default:
                return new FactoryTest();
        }
    }
}

abstract class Factory
{
    public Step1 step1;
    public Step2 step2;
}

interface Step1
{
    void Run();
}

interface Step2
{
    void Run();
}

class FactoryProd : Factory
{
    public FactoryProd()
    {
        base.step1 = new Step1Prod();
        base.step2 = new Step2Prod();
    }
}

class FactoryTest : Factory
{
    public FactoryTest()
    {
        base.step1 = new Step1Test2();
        base.step2 = new Step2Prod();
    }
}

class Step1Prod : Step1
{
    public void Run()
    {
        Console.WriteLine("Step1Prod");
    }
}

class Step2Prod : Step2
{
    public void Run()
    {
        Console.WriteLine("Step2Prod");
    }
}



class Step1Test : Step1
{
    public void Run()
    {
        Console.WriteLine("Step1Test");
    }
}

class Step1Test2 : Step1
{
    public void Run()
    {
        Console.WriteLine("Step1Test2");
    }
}

class Step2Test : Step2
{
    public void Run()
    {
        Console.WriteLine("Step2Test");
    }
}