// Imagine the follow company structure
// There is one LGBS. 
// One LGBS has n Towers
// Every Tower has n Teams
// Every Team has n Employees
// Every Employee has 2 properties (name and age)

// We want a data structure that allows us:
// To display the name and age of all employees of team x in tower y (x and y are chosen by the user)

// Task: declare this data structure
// Hints: nesting, dictionary, list, custom class

public class REG_NEW_B
{
    public void Run()
    {

    }
}

static class Input
{
    public static string[][] rawData = 
    {
        new string[] {"OE", "Team1", "Paul", "38"},
        new string[] {"OE", "Team2", "Mike", "29"},
        new string[] {"PTP", "Team2", "Paul", "27"},
        new string[] {"RTR", "Team1", "Sue", "52"},
        new string[] {"OE", "Team1", "Joe", "27"},
        new string[] {"PTP", "Team2", "Mike", "19"},
        new string[] {"PTP", "Team2", "Mike", "29"},
        new string[] {"OE", "Team1", "Bill", "53"}         
    };
}