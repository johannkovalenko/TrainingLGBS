// This code compiles and executes correctly.
// There is a bad coding practice, though. Please propose a technique to get rid of the bad practice

using System;
using System.IO;
using System.Collections.Generic;

public class JUN_6M_A
{
    private string rawData = "Paul;30;1200,00;false|Mike;20;433,33;true|Joe;59;3332,12;false"; 
    
    private List<string[]> employees = new List<string[]>();
    
    public void Run()
    {
        Read();
        Add();
        Print();           
    }

    private void Read()
    {
        string[] lines = rawData.Split('|');

        foreach (string line in lines)
        {
            string[] split = line.Split(';');
            employees.Add(split);
        }
    }

    private void Add()
    {
        string[] employee = new string[4];

        employee[0] = "Liz";    // Name
        employee[1] = "39";     // Age
        employee[2] = "1234,56";// Salary;
        employee[3] = "TRUE";   // Married

        employees.Add(employee);
    }

    private void Print()
    {
        foreach (string[] employee in employees)
        {
            double salary;

            if (double.TryParse(employee[2], out salary))
            {
                Console.WriteLine(salary);
                if (salary > 600.00)
                    Console.WriteLine("Name: " + employee[0]);
            }

        }
    }
}