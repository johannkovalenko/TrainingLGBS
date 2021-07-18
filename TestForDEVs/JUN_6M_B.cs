// What values will be displayed?

using System;
using System.Collections.Generic;

public class JUN_6M_B
{
    public void Run()
    {
        int     age             = 30;
        int[]   ages           = {30};

        string  name            = "Paul";

        var     agesDict        = new Dictionary<string, int> ();
        agesDict["Mike"]        = 30;
        
        var     agesDictCopy    = new Dictionary<string, int> (agesDict);
        agesDict["Bill"]        = 50;

        var     mike            = new Employee(30);

        var employees           = new Dictionary<string, Employee>();
        employees["Mike"]       = mike;

        var employeesCopy       = new Dictionary<string, Employee>(employees);

        employees["Bill"]       = new Employee(50);

        var     point           = new Point(30, 30);

        Change(name, age, ages, agesDict, mike, point);

        Console.WriteLine("Int:        " + age);
        Console.WriteLine("String:     " + name);
        Console.WriteLine("Array:      " + ages[0]);
        Console.WriteLine("CustomClass " + mike.age);
        Console.WriteLine("Dict1:      " + agesDict["Mike"]);
        Console.WriteLine("Dict1 Copy: " + agesDictCopy["Mike"]);
        Console.WriteLine("Count1:     " + agesDict.Count);
        Console.WriteLine("Count1Copy: " + agesDictCopy.Count);
        Console.WriteLine("Dict2:      " + employees["Mike"].age);
        Console.WriteLine("Dict2Copy:  " + employeesCopy["Mike"].age);
        Console.WriteLine("Count2:     " + employees.Count);
        Console.WriteLine("Count2Copy: " + employeesCopy.Count);
        Console.WriteLine("Struct:     " + point.x);
    }

    private void Change(string name, int age, int[] ages, Dictionary<string, int> agesDict, Employee mike, Point point)
    {
        age = 40;
        name = "Mike";
        ages[0] = 40;
        agesDict["Mike"] = 40;
        mike.age = 40;
        point.x = 40;
    }

    private class Employee
    {
        public int age;
        
        public Employee(int age)
        {
            this.age = age;
        }
    }
    
    private struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}


