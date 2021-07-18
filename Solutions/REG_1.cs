//Please tell the bad practice and provide a better code

//PS: I don't mean the bad practice, that the data input is hardcoded (this just helps to create a relatively intuitive exercise).

//PS: this practice is so bad that I wasn't even able to compile it :-)

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		List<Employee> myData = new List<Employee>();
		
		myData.Add(Emp1());
		myData.Add(Emp2());
		
		foreach (Employee emp in myData)
			if (emp.salary > 5000)
				Console.WriteLine(emp.name + " earns more than 5000 zl");
			
		Console.ReadLine();
	}
	
	static Employee Emp1()
	{
		Employee output = new Employee();
		
		output.name = "Pawel";
		output.age = 33; 
		output.salary = 7000;
		
		return output;
	}
	
	static Employee Emp2()
	{
		Employee output = new Employee();
		
		output.name = "Michal";
		output.age = 27; 
		output.salary = 5000;
		
		return output;
	}
}

class Employee
{
	public string name;
	public int age;
	public int salary;
}