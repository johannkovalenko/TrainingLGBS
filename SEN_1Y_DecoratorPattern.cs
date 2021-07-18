using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        Company company = new Carsed(new Skoda(new Volkswagen(new Plain())));
        company.Sell();

        Console.WriteLine("---");

        Company company2 = new Skoda(new Plichta(new Audi(new Plain())));
        company2.Sell();

        Console.ReadLine();
    }
}

class Plain : Company
{
    public override void Sell()
    {
    }
}

class Decorator : Company
{
    Company company;

    public Decorator(Company company)
    {
        this.company = company;
    }

    public override void Sell()
    {
        company.Sell();
    }
}


class Volkswagen : Decorator
{
    public Volkswagen(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Volkswagen sells");
    }
}

class Skoda : Decorator
{
    public Skoda(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Skoda sells");
    }
}

class Carsed : Decorator
{
    public Carsed(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Carsed sells");
    }
}

abstract class Company
{
    public abstract void Sell();
}

class Seat : Decorator
{
    public Seat(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Seat sells");
    }
}

class Audi : Decorator
{
    public Audi(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Audi sells");
    }
}

class GrupaKrotoski : Decorator
{
    public GrupaKrotoski(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("GrupaKrotoski sells");
    }
}

class Plichta : Decorator
{
    public Plichta(Company company) : base(company){}

    public override void Sell()
    {
        base.Sell();
        Console.WriteLine("Plichta sells");
    }
}