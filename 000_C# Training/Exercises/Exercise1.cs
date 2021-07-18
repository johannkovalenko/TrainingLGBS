using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

public class MainClass
{
    public static void Main()
    {        
        while (true)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Run();
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }

    }

    public static void Run()
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        
        string[] lines = File.ReadAllLines("Data_Exercise1.txt");

        string[] split;
        string key;
        List<string> tempList;

        for (int i=1;i<lines.Length;i++)
        {
            split = lines[i].Split(';');

            if (split.Length < 2)
                continue;
            
            key = split[0];

            split = split[1].Split(',');

            if (!dict.ContainsKey(key))
            {
                tempList = new List<string>();

                foreach (string country in split)
                    if (!tempList.Contains(country) && country != key)
                        tempList.Add(country);
                
                dict.Add(key, tempList);
            }
            else
            {
                foreach (string country in split)
                    if (!dict[key].Contains(country) && country != key)
                        dict[key].Add(country);                
            }
        }

        foreach (string key1 in dict.Keys)
            Console.WriteLine(key1 + "  " + dict[key1].Count);
    }
}