using System;

class MainClass
{
    static void Main()
    {
        Profession[] professions = new Profession[] 
        { 
            new Programmer(), 
            new BusinessAnalyst() 
        };

        foreach (Profession profession in professions)
        {
            Product product = profession.Produce();
            Console.WriteLine(product.GetType().Name);
        }

        Console.ReadLine();
    }
}

interface Profession
{
    Product Produce();
}

abstract class Product
{

}

class Programmer : Profession
{
    public Product Produce()
    {
        return new Code();
    }
}

class BusinessAnalyst : Profession
{
    public Product Produce()
    {
        return new Ideas();
    }
}


class Code : Product
{

}

class Ideas : Product
{

}