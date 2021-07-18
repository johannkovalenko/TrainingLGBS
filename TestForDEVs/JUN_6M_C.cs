// Find the bad practice and proposes a technique to improve the code
// Not all is black and white. This same bad practice can sometimes be justified. Can you tell such cases?


using System;
using System.Collections.Generic;

class JUN_6M_C
{
    private Dictionary<string, int> ages = new Dictionary<string, int>();
    private Dictionary<string, double> salaries = new Dictionary<string, double>();
    private Dictionary<string, bool> married = new Dictionary<string, bool>();

    public void Run()
    {
        Read();
        Print("Mike");
    }

    private void Read()
    {
        foreach (string[] employee in rawData) {
            ages[employee[0]]       = int.Parse(employee[1]);
            salaries[employee[0]]   = double.Parse(employee[2]);
            married[employee[0]]    = bool.Parse(employee[3]);
        }
    }

    private void Print(string name)
    {
        if (ages.ContainsKey(name))
            Console.WriteLine(ages[name]);

        if (salaries.ContainsKey(name))
            Console.WriteLine(salaries[name]);
        
        if (married.ContainsKey(name))
            Console.WriteLine(married[name]);
    }

    private string[][] rawData = 
    {
        new string[] { "Paul", "30", "1200,00", "false" }, 
        new string[] { "Mike", "20", "433,33", "true" },
        new string[] { "Joe", "59", "3332,12", "false" }
    };
}