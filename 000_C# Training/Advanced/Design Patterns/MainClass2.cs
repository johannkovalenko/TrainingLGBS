using System;
using System.Collections.Generic;

public class MainClass2
{
    public static void Main()
    {
        Director director = new Director();

        Builder[] builders = new Builder[] 
        {
            new ConcreteBuilder1(),
            new ConcreteBuilder2()
        };

        foreach (Builder builder in builders)
        {
            director.Construct(builder);

            builder.product.Show();
        }

        Console.ReadLine();
    }
}

class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}

interface Builder
{
    Product product {get; set;}
    void BuildPartA();
    void BuildPartB();
}

class ConcreteBuilder1 : Builder
{
    public Product product {get; set;}

    public ConcreteBuilder1()
    {
        product = new Product();
    }

    public void BuildPartA()
    {
        product.Add("PartA");
    }

    public void BuildPartB()
    {
        product.Add("PartB");
    }
}

class ConcreteBuilder2 : Builder
{
    public Product product {get; set;}
    
    public ConcreteBuilder2()
    {
        product = new Product();
    }

    public void BuildPartA()
    {
        product.Add("PartX");
    }

    public void BuildPartB()
    {
        product.Add("PartY");
    }
}

class Product : List<string>
{
    public void Show()
    {
        Console.WriteLine("\nProduct Parts -------");

        for (int i=0; i<base.Count;i++)
            Console.WriteLine(base[i]);
    }
}
