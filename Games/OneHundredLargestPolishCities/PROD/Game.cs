using System;
using System.IO;
using System.Collections.Generic;

class Game
{
    Dictionary<string, Dictionary<string, bool>> cities = new Dictionary<string, Dictionary<string, bool>>();

    public Game()
    {
        Dictionary<string, string> countries = new Dictionary<string, string>() 
        {
            {"Poland", "database.txt"},
            {"France", "france.txt"},
            {"UK", "uk.txt"},
            {"Germany", "germany.txt"}
        };

        foreach (string country in countries.Keys)
        {
            var perCountry = new Dictionary<string, bool>();

            string[] rawCities = File.ReadAllLines(countries[country]);

            foreach (string rawCity in rawCities)
                perCountry.Add(Clean(rawCity), false);

            cities.Add(country, perCountry);
        }
    }   

    public void Run()
    {
        Console.WriteLine("Enter country:");
        
        foreach (string choice in cities.Keys)
            Console.WriteLine(choice);

        string country = Console.ReadLine();

        if (!cities.ContainsKey(country))
        {
            Console.WriteLine("Country does not exist");
            return;
        }

        int counter = 0;
        int numberOfCities = cities[country].Count;

        Console.WriteLine("Enter city:");
        while(counter < numberOfCities)
        {
            string answer = Clean(Console.ReadLine());

            if (answer.ToLower() == "exit")
                break;
            else if (answer.ToLower() == "print")
            {
                PrintMissing(country);
                break;
            }

            if (!cities[country].ContainsKey(answer))
                Console.WriteLine("City not in database.");
            else if (cities[country][answer] == true)
                Console.WriteLine("City already entered");
            else
            {
                cities[country][answer] = true;
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
        .Replace("ą", "a").Replace("ę", "e")
        .Replace("É", "E").Replace("é", "e")
        .Replace("è", "e").Replace("î", "i");
    }

    public void PrintMissing(string country)
    {
        int counter = 0;

        foreach (string city in cities[country].Keys)
        {
            counter++;

            if (!cities[country][city])
                Console.WriteLine(counter + "\t" + city);
        }
    }
}


// 100 Polish cities in a list
// Program that runs until all 100 cities will be entered.
// Programme in command line
// Replace polish signs and case, but leave original to print it
// Exit condition
// Print missing and exit programme (city and position)
// Rerun game without exiting the programme
// Refactoring: database to be loaded only once
// Accept also 
// Help mode: add Wojevodeship Information (m of n in woj. O)

// Extend: cities of other countries
// Extend: statistics: country, who many, highest position of not known
// Extend: add population, count how many percent guess was off actual population