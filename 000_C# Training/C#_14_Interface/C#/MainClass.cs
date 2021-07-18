using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        Dictionary<string, Vendor> vendors = new Dictionary<string, Vendor>();

        vendors.Add("Klockmann", new Klockmann());
        vendors.Add("Bundespolizei", new Bundespolizei());
        
        foreach (string vendor in vendors.Keys)
            vendors[vendor].ReadPdf();

        Console.ReadLine();
    }
}

public interface Vendor
{
    void ReadPdf();
    //void NextFunction();
}

public class Klockmann : Vendor
{
    public void ReadPdf()
    {
        Console.WriteLine("Clock gun");
        HelperFunction();
    }

    public void HelperFunction()
    {
    }
}

public class Bundespolizei : Vendor
{
    public void ReadPdf()
    {
        Console.WriteLine("Haende hoch");
    }
}