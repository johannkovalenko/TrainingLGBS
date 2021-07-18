// This code compiles and executes correctly. There is a bad coding practice, though. 
// Name the bad practice and explain why "CarDataNew" is better then "CarData", but still not ideal 

using System.Collections.Generic;

public class REG_NEW_A
{
    public void Run()
    {
        var carData = new CarData();
        carData.vins.Add("ABC123");
        carData.Register("DEF456");

        var carDataNew = new CarDataNew();
        carDataNew.Vins.Add("ABC123");
        carDataNew.Register("DEF456");
    }
}

public class CarData
{
    public List<string> vins = new List<string>();

    public void Register(string vin)
    {
        if (!vins.Contains(vin))
            vins.Add(vin);
    }
}

public class CarDataNew
{
    private List<string> vins = new List<string>();

    public List<string> Vins
    {
        get { return vins; }
    }

    public void Register(string vin)
    {
        if (!vins.Contains(vin))
            vins.Add(vin);
    }
}
