using System;

public class MainClass
{
    public static void Main()
    {
        ICars[] cars = new ICars[] {new Hyundai(), new Kia()};

        foreach (ICars car in cars)
        {
            car.vin = 45;
            car.CheckVIN();
        }

        Console.ReadLine();
    }
}

public interface ICars
{
    int vin {get; set;}
    void CheckVIN();
}

public class Hyundai : ICars
{
    public int vin {get; set;}
    public void CheckVIN()
    {
        vin = (vin + 78) * 15; 
        Console.WriteLine("Hyundai: " + vin); 
    }
}

public class Kia : ICars
{
    public int vin {get; set;}
    public void CheckVIN()
    {
        vin = (vin + 46) * 9; 
        Console.WriteLine("Kia:     " + vin); 
    }
}

