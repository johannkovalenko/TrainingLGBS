using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        IBuilder builder = new Kia();
        director.Build(builder);
        
        director.BuildOnlyPrice();

        Car car = builder.GetCar();

        Console.WriteLine(car.price + "  " + car.name + "  " + car.horsepower);

        director.BuildAll();

        Console.WriteLine(car.price + "  " + car.name + "  " + car.horsepower);
    }
}

interface IBuilder
{
    void SetPrice();
    void SetName();
    void SetHorsepower();
    Car  GetCar();
}

class Car
{
    public int price = 0;
    public string name = "";
    public int horsepower = 0;
}

class Kia : IBuilder
{
    private Car car = new Car();

    public void SetPrice()
    {
        car.price = 15000;
    }
    
    public void SetName()
    {
        car.name = "Cee'd";
    }
    
    public void SetHorsepower()
    {
        car.horsepower = 110;
    }
    
    public Car GetCar()
    {
        return car;
    }
}

class Director
{
    IBuilder builder;
    
    public void Build (IBuilder builder)
    {
        this.builder = builder;
    }

    public void BuildOnlyPrice()
    {
        builder.SetPrice();
    }
    
    public void BuildAll()
    {
        builder.SetPrice();
        builder.SetName();
        builder.SetHorsepower();
    }
}