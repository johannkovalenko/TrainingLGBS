using System;
using System.Collections.Generic;

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
 
[assembly: AssemblyTitle("MyProject")]
[assembly: AssemblyProduct("RPA")]
[assembly: AssemblyCopyright("Lufthansa Group Business Services")]
[assembly: AssemblyTrademark("Lufthansa Group Business Services")]
[assembly: AssemblyVersion("1.0.0.9")]
[assembly: AssemblyFileVersion("1.0.0.9")]


class MainClass
{
    static void Main()
    {
        new Task1().Run();
        new Task2().Run();
    }
}

class Task1
{
    private Dictionary<string, int> countries = new Dictionary<string, int>();

    public void Run()
    {
        string[] input = {"Austria", "Poland", "Germany", "Austria", "Poland", "Germany"};
        
        Fill(input);
        Print();
    }

    private void Fill(string[] input)
    {
        foreach (string country in input)
            if (!countries.ContainsKey(country))
                countries.Add(country, 1);
            else
                countries[country]++;
    }

    private void Print()
    {
        foreach (string country in countries.Keys)
            Console.WriteLine(country + " " + countries[country]);
    }
}

class Task2
{
    public void Run()
    {
        Console.WriteLine(ConvertToInt("1234"));
        Console.WriteLine(ConvertToInt("E1234"));
    }

    private int ConvertToInt(string input)
    {
        int result = 0;
        int factor = 1;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int sign = input[i] ^ 48;

            if (sign < 0 || sign > 9)
                continue; // Simplest solution, ignoring illegal signs.
            else
                result += sign * factor;
            
            factor *= 10;
        }

        return result;
    }
}