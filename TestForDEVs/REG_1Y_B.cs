// Look at below approaches.
// Which one is closer to Functional Programming and which one closer to Object Oriented Programming.
// What are the advantages and disadvantages of each approach.
// Which bad practices are usually connected to the given approach
// Can you connect the topic to Uncle Bob's rule: Data Structure ok, Object ok, Hybrid not ok.

using System;
using System.Collections.Generic;

class REG_1Y_B
{
    public void Run()
    {
        new Approach1.Main().Run();
        new Approach2.Main().Run();
    }
}

namespace Approach1
{
    class Main
    {
        public void Run()
        {
            var data = new Dictionary<string, Employee>();
        
            int ageOfMike;

            if (data.ContainsKey("Mike"))
                ageOfMike = data["Mike"].age;
            else
                ageOfMike = -1;
        }
    }

    class Employee
    {
        public string name = "";
        public int age = 0;
    }
}

namespace Approach2
{
    class Main
    {
        public void Run()
        {
            var team = new Team();

            int ageOfMike = team.GetEmployeeAge("Mike"); 
        }
    }

    class Team
    {
        private Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

        public int GetEmployeeAge(string name)
        {
            if (employees.ContainsKey(name))
                return employees[name].GetAge();
            else return -1;
        }
    }

    class Employee
    {
        private string name = "";
        private int age = 0;

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }
    }
}