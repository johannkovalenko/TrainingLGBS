/* Questions
	True or false?
		a) Equality with primitive type is unproblematic.
		b) When we create two instances of class MyClass, and assign the same values to them, the condition myClass1 == myClass2 will return true.
		c) overriding the equals method is irrelevant
		d) overriding the equals method is useful, when we have List<CustomType> and want to check if the instance to be added already exists in the list.
		e) overriding the equals methods is useful to retrieve an specific instance in List<CustomType> and edit it.
		
	You can:
		override the method "Equals"
*/


//Solutions at the bottom

// Exercises 1-3 are Junior level, but essential for the understanding
// Exercise_4 and Exercise_5 are the core topic for a Senior


using System;
using System.Collections.Generic;

class App
{
	static void Main()
	{
		//Exercise_1();
		//Exercise_1a();
		//Exercise_1c();
		//Exercise_2();
		//Exercise_3();
		Exercise_4();
		
		Console.ReadLine();
	}
	
	static void Exercise_1()
	{
		// What is the result: true or false?
		
		string myStr1 = "Paul";
		string myStr2 = "Paul";
		string myStr3 = "John";		
		
		Console.WriteLine(myStr1 == myStr2);
		Console.WriteLine(myStr1.Equals(myStr2));
		Console.WriteLine(myStr1 == myStr3);
		Console.WriteLine(myStr1.Equals(myStr3));
	}

	static void Exercise_1a()
	{
		// What is the result: true or false?
		
		int a = 1;
		int b = 1;
		int c = 2;		
		
		Console.WriteLine(a == b);
		Console.WriteLine(a.Equals(b));
		Console.WriteLine(a == c);
		Console.WriteLine(a.Equals(c));
	}
	
	static void Exercise_1b()
	{
		// What is the result: true or false?
		
		string[] myArr1 = {"Paul", "John"};
		string[] myArr2 = {"Paul", "John"};
		string[] myArr3 = {"John", "Paul"};
		
		
		Console.WriteLine(myArr1 == myArr2);
		Console.WriteLine(myArr1.Equals(myArr2));
		Console.WriteLine(myArr1 == myArr3);
		Console.WriteLine(myArr1.Equals(myArr3));
	}

	static void Exercise_1c()
	{
		// What is the result: true or false?
		
		int[] a = {1, 2};
		int[] b = {1, 2};
		int[] c = {1, 3};		
		
		Console.WriteLine(a == b);
		Console.WriteLine(a.Equals(b));
		Console.WriteLine(a == c);
		Console.WriteLine(a.Equals(c));
	}
	
	class Employee
	{
		public string name;
		public int age;
		public double salary;
		public bool active;
		
		public Employee(string name, int age, double salary, bool active)
		{
			this.name = name;
			this.age = age;
			this.salary = salary;
			this.active = active;
		}
	}
	
	static void Exercise_2()
	{
		// What is the result: true or false?
		
		var emp1 = new Employee("John", 34, 1500.37, true);
		var emp2 = new Employee("John", 34, 1500.37, true);
		var emp3 = new Employee("John", 34, 1500.37, false);
		
		Console.WriteLine(emp1 == emp2);
		Console.WriteLine(emp1 == emp3);
	}

	static void Exercise_3()
	{
		// What is the result: true or false?
		
		var employees = new List<Employee>();
		
		employees.Add(new Employee("John", 34, 1500.37, true));
		
		var emp = new Employee("John", 34, 1500.37, true);

		
		Console.WriteLine(employees.Contains(emp));
	}
	
	static void Exercise_3a()
	{
		// Does this approach make sense?
		
		var employees = new Dictionary<string, Employee>();
		
		employees.Add("John", new Employee("John", 34, 1500.37, true));
		
		var emp = new Employee("John", 34, 1500.37, true);

		if(!employees.ContainsKey(emp.name))
			employees.Add(emp.name, emp);
	}

////////////////////////////////////////////

	class EmployeeNew 
	{
		public string name;
		public int age;
		public double salary;
		public bool active;
		
		public EmployeeNew(string name, int age, double salary, bool active)
		{
			this.name = name;
			this.age = age;
			this.salary = salary;
			this.active = active;
		}
		
		public override bool Equals(object obj)
		{
			EmployeeNew emp = (EmployeeNew) obj;
			
			Console.WriteLine("IN");
			
			return this.name == emp.name && this.age == emp.age;
		}
		
	
		public override int GetHashCode()
		{
			return 1;
		}
	}
	
	static void Exercise_4()
	{
		// How many elements will "employees" have at the end of the method?
		// Look at "public override bool Equals" in above class: How often will the message "IN" appear?
		
		var employees = new List<EmployeeNew>();
		
		employees.Add(new EmployeeNew("John", 34, 1500.37, true));
		employees.Add(new EmployeeNew("Mike", 35, 1500.37, true));
		employees.Add(new EmployeeNew("Pat", 36, 1500.37, true));
		
		
		var emp = new EmployeeNew("John", 34, 1500.37, false);
		
		if (!employees.Contains(emp))
			employees.Add(emp);
		
		Console.WriteLine("----");
		
		var emp1 = new EmployeeNew("Paul", 34, 1500.37, true);
		
		if(!employees.Contains(emp1))
			employees.Add(emp1);
		
		Console.WriteLine(employees.Count);
	}

//////////////

	static void Exercise_5()
	{
		// Is it possible to replace the dictionary by a list?
		
		var employees = new Dictionary<string, Employee>();
		
		employees.Add("John", new Employee("John", 34, 1500.37, true));
		employees.Add("Pat", new Employee("Pat", 35, 1500.37, true));

		employees["John"].age = 58;
		employees["Pat"].active = false;
	}
	
	static void Exercise_6()
	{
		// Is the performance optimal?
		
		var employees = new List<Employee>();
		
		employees.Add(new Employee("John", 34, 1500.37, true));
		employees.Add(new Employee("Pat", 35, 1500.37, true));


		Employee john = employees.Find(delegate(Employee item) { return item.name == "John"; });
		john.age = 58;
		
		Employee pat = employees.Find(delegate(Employee item) { return item.name == "Pat"; });
		pat.active = false;
	}	
}

///////////////////////////////



/*

Exercise_1: true, true, false, false
Exercise_1a: true, true, false, false
Exercise_1b: false, false, false, false 
Exercise_1c: false, false, false, false
	At first Exercise_1 seems trivial, but Exercise_1b makes Exercise_1 more confusing. Step by step:
	1) unless we override Equals as in Exercise_4, "==" and "Equals" produce the same result.
	2) integer is a primitive type, comparing primitive types means comparing their VALUE.
	3) an array is a complex type, comparing complex types means comparing their ADDRESS.
	4) a string is a array of chars, but is not treated as a complex type. That's why Exercise_1 is not trivial.
	
Exercise_2: false, false
	objects (= instance of classes) are Reference types, hence comparing them means comparing their addresses, and not their values.
	
Exercise_3: false
	The List.Contains() method checks every elements of the list if it is equal to the given element. Since the custom class is a complex types, it is compared by reference.
	
Exercise_3a: no
	The List.Contains() method will always return false, as the instances are compared by reference. To achieve a so called "deep comparison", see Exercise_4
	
Exercise_4: 4 elements, 4 times "IN" (1 time for "emp", 3 times for "emp1")
	This is quite unintuive. To understand better please consider the following:
	1) The List.Contains method loops IN THE BACKGROUND through every element in the list and calls the Equals method to check for equality.
	2) Unless we override the Equals method it produces the same result as "==", hence comparing complex types by reference
	3) C# allows us to customize this Equals methods with our own conditions. We decide now, how the so called "deep comparision" looks like. 
	4) Every class in C# (really every) inherits the so called "Object class" which contains the method Equals. One key concept of inheritance is that you can replace this inherited method with our own method. This process is call overriding. 
	
Exercise_5: yes (but not desirable)
	The overriding of Equals is mainly used to create a list of complex types without duplicates (and you decide how the deep comparison looks like).
	The overriding of Equals is not ideal when you want to access a concrete key value pair. Here, the dictionary is still the best solution
	
Exercise_6: no
	Referring to Exercise_5, this is the not desirable solution using a list. Why? A dictionary is faster than List.Find. Please do not use this approach.
*/