// Question 1: Which SOLID principle is breached here?
// Question 2: Is this rather a Factory or rather a Strategy?
// Task 3: Assess how well the Open-Closed principle is fulfilled?

using System;
using System.Collections.Generic;

public class SEN_NEW_A
{
    public void Run()
    {
        List<Bird> birds = Generate();

        foreach (Bird bird in birds)
        {
            bird.Walk();
            bird.Fly();
        }
    }

    private List<Bird> Generate()
    {
        return new List<Bird> ()
        {
            new Sparrow(),
            new Mockingbird(),
            new Sparrow(),
            new Penguin(),
            new Penguin(),
            new Mockingbird()
        };
    }
}

interface Bird
{
    void Walk();
    void Fly();
}

class Sparrow : Bird
{
    public void Walk()
    {
        Console.WriteLine("Sparrow walks");
    }

    public void Fly()
    {
        Console.WriteLine("Sparrow flies");
    }
}

class Mockingbird : Bird
{
    public void Walk()
    {
        Console.WriteLine("Mockingbird walks");
    }

    public void Fly()
    {
        Console.WriteLine("Mockingbird flies");
    }
}

class Penguin : Bird
{
    public void Walk()
    {
        Console.WriteLine("Penguin walks");
    }

    public void Fly()
    {
        Console.WriteLine("Penguin can't fly");
    }
}

