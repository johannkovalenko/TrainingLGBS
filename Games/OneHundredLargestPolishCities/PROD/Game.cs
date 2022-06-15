using System;
using System.IO;
using System.Collections.Generic;

class Game
{
    Dictionary<string, bool> cities = new Dictionary<string, bool>();
    public void Run()
    {
        
        string[] rawCities = File.ReadAllLines("database.txt");

        foreach (string rawCity in rawCities)
            cities.Add(Clean(rawCity), false);

        int counter = 0;
        int numberOfCities = cities.Count;

        while(counter < numberOfCities)
        {
            Console.WriteLine("Enter City:");
            string answer = Clean(Console.ReadLine());

            if (answer.ToLower() == "exit")
                break;
            else if (answer.ToLower() == "print")
            {
                PrintMissing();
                break;
            }

            if (!cities.ContainsKey(answer))
                Console.WriteLine("City not in database.");
            else if (cities[answer] == true)
                Console.WriteLine("City already entered");
            else
            {
                cities[answer] = true;
                counter++;
                Console.Write(counter + " of " + numberOfCities + " correctly guessed.\t");
            }
        }

        Console.WriteLine("End of game");
    }

    public string Clean(string input)
    {
        return input.Replace("ó", "o").Replace("ń", "n")
        .Replace("ż", "z").Replace("Ż", "Z")
        .Replace("ś", "s").Replace("Ś", "S")
        .Replace("ź", "z").Replace("Ź", "Z")
        .Replace("ć", "c").Replace("Ć", "C")
        .Replace("ł", "l").Replace("Ł", "L")
        .Replace("ą", "a").Replace("ę", "e");
    }

    public void PrintMissing()
    {
        int counter = 0;

        foreach (string city in cities.Keys)
        {
            counter++;

            if (!cities[city])
                Console.WriteLine(counter + "\t" + city);
        }
    }
}


// 100 Polish cities in a list
// Program that runs until all 100 cities will be entered.
// Programme in command line
// Replace polish signs and case
// Exit condition
// Print missing and exit programme (city and position)
// Rerun game without exiting the programme
// Refactoring: database to be loaded only once
// Accept also 
// Help mode: add Wojevodeship Information (m of n in woj. O)