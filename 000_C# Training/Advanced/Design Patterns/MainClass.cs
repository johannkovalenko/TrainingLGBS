using System;

class MainClass
{
    public static void Main()
    {
        Profession[] professions = new Profession[] 
        {
            new Programmer(), 
            new BusinessAnalyst()
        };

        foreach (Profession profession in professions)
        {
            Product[] products = profession.Produce();

            foreach (Product product in products)  
                Console.WriteLine(product.GetType().Name);
        }

        Console.ReadLine();
    }
}

interface Profession
{
    Product[] Produce();
}

interface Product
{
}

class Programmer : Profession
{
    public Product[] Produce()
    {
        return new Product[] {new Code(), new Tests()};
    }
}

class BusinessAnalyst : Profession
{
    public Product[] Produce()
    {
        return new Product[] {new Ideas(), new Plans()};
    }
}

class Code : Product
{
}

class Ideas : Product
{
}

class Tests : Product
{
}

class Plans : Product
{

}
