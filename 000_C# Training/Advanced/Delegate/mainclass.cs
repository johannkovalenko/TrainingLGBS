using System;
using OtherSpace;
using System.Windows.Forms;

public class MainClass
{
    public static void Main()
    {
        Application.Run(new MainForm());

        MyClass myClass = new MyClass();
        myClass.AddCallback(Hyundai);
        myClass.Exe(35);
    }

    public static void Hyundai(int vin)
    {
        vin = (vin + 78) * 15; 
        Console.WriteLine("Hyundai: " + vin); 
    }

    public static void Kia(int vin)
    {
        vin = (vin + 46) * 9; 
        Console.WriteLine("Kia:     " + vin); 
    }
}

