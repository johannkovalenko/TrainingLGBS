// What capitals will be printed? Explain the result.

using System;
using System.Collections.Generic;


public class JUN_6M_C
{
    public void Run()
    {
        Dictionary<string, CountryData> countries = Generate();
        var countriesCopy = new Dictionary<string, CountryData> (countries);

        countriesCopy["Austria"].capital = "Graz";

        Console.WriteLine(countries["Austria"].capital);
        Console.WriteLine(countriesCopy["Austria"].capital);

    }

    private Dictionary<string, CountryData> Generate()
    {
        return new Dictionary<string, CountryData>() {
            { "Poland",     new CountryData("Poland", "Warsaw", "Zloty", "Polish") },
            { "Austria",    new CountryData("Austria", "Vienna", "Euro", "German") },
            { "Germany",    new CountryData("Germany", "Berlin", "Euro", "German") }
        };
    }
}

class CountryData
{
    public string name;
    public string capital;
    public string currency;
    public string officialLanguage;

    public CountryData(string name, string capital, string currency, string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.currency = currency;
        this.officialLanguage = officialLanguage;
    }
}
