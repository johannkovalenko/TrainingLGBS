using System;

class MainClass
{
    static void Main()
    {
        ClientMethod(new ItalianVehicles());
        ClientMethod(new JapaneseVehicles());
    }

    static void ClientMethod(IVehicles country)
    {
        ICar car = country.BuildCar();
        IMotocycle motocycle = country.BuildMotocycle();
        
        Console.WriteLine(car.Assemble4Wheels());
        Console.WriteLine(motocycle.Assemble2Wheels());
    }
}