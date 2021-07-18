using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        ListActions();
        DictionaryActions();
    }

    private static void ListActions()
    {
        var list = new List<Employee>();

        list.Add(new Employee("Mike", 25));
        list.Add(new Employee("Sue", 45));

        foreach(Employee employee in list)
            Console.WriteLine(employee.name + employee.age);

        for (int i=0; i<list.Count; i++)
            Console.WriteLine(list[i].name + list[i].age);
    }

    private static void DictionaryActions()
    {
        var dict = new Dictionary<int, Employee>();

        var emp1 = new Employee("Mike", 25);
        var emp2 = new Employee("Sue", 45);

        if (!dict.ContainsKey(0))
            dict.Add(0, emp1);
        else dict[0] = emp1;

        if (!dict.ContainsKey(1))
            dict.Add(1, emp2);
        else dict[1] = emp2;

        dict.Add(10, null); // will compile

        foreach (KeyValuePair<int, Employee> pair in dict)
            if (pair.Value != null)
                Console.WriteLine(pair.Key + pair.Value.name + pair.Value.age);

        Dictionary<int, Employee>.KeyCollection keys = dict.Keys;
        Dictionary<int, Employee>.ValueCollection values = dict.Values;

        var emp3 = new Employee("Joe", 32);

        if (!dict.ContainsKey(0))
            dict.Add(0, emp3);
        else dict[0] = emp3;

        if (dict.ContainsKey(0)) 
        {
            dict[0].name = "Mike";
            Console.WriteLine(dict[0].name);
        } 
    }

    private class Employee
    {
        public string name;
        public int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}