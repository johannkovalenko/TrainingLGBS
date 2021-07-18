/* Questions
	1) What would you use? An array or a list?
		a) 50 states of the USA
		b) check, if employee X works in LGBS
		c) add new employees at runtime
		d) remove employees at runtime
		e) we do not want to check the existence of an element, nor do we want to add or remove elements
		f) we know at design time, how many elements exist
		
	2) True or false?
		a) every element of an array can be accessed by its numeric index
		b) every element of a list can be accessed by its numeric index
		c) we can create an array of our custom class
		d) we can create a list of our custom class
		e) Array is a reference type
		f) List is a reference type
		g) A 2D array requires an instance for the whole class, and additionally an instance for every line
		g) A jagged array requires an instance for the whole class, and additionally an instance for every line
*/


// Exercise 0

	//Which data type would you use?

	// 1) Count the number of the every name in LGBS
	// 2) have a list of LGBS employees without duplicates
		// {"Paulina", "Paweł", "Michał", "Johann", "Paulina"}

	// 3) Group the employees of LGBS:
		// a) by tower
		// b) by tower and teams
	// 4) having a list of employees of LGBS, with every employee having 10 information:
			// a) of type string
			// b) of different types
			// c) of different types. Later on, the program will need a quick access to the information 4 via the employee name
			// d) big data, too slow processor and little RAM: take the quickest datatype, not being concerned about readability of the code
				// aa) the number of employees is UNKNOWN at the beginning of run-time
				// bb) the number of employees is KNOWN at the beginning of run-time
	// 5) 

// Exercise 0.1

	// Find the minimum value of a given array.

	//Example: int[] arr = {5, 6, 3, 4, 5, 4, 0, 8};
	//Correct solution: 0
	
// Exercise 0.2

	// Write two sorting algorithms
	// I guess everybody knows bubble sort. Replicated it, but also think of another algorithm.

	// Example: int[] arr = {4, 2, 5, 6, 5};
	// Expected result: 2 4 5 5 6 


///Solutions at the bottom


using System.Collections.Generic;
using System.Collections;
using System.IO;
using System;

class App
{
	static void Main()
	{
		//Exercise_7();
		//Exercise_17();
		//Exercise_18();
		Exercise_19();
		
		Console.ReadLine();
	}
	
	static void Exercise_1()
	{
		// Is the use of the list justified?
		
		List<string> states = new List<string> {"New York", "California", "Texas", "Alabama", "and 46 more"};
		
		foreach (string state in states)
			Console.WriteLine(state);
	}
	
	static void Exercise_2()
	{
		// Is the use of the list justified?
		
		string[] employees_arr = File.ReadAllLines("emp.txt");
		List<string> employees = new List<string>(employees_arr);
		
		foreach (string employee in employees)
			Console.WriteLine(employee);
	}

	static void Exercise_3()
	{
		// Is the use of the list justified?
		
		string[] employees_arr = File.ReadAllLines("emp.txt");
		List<string> employees = new List<string>(employees_arr);
		
		for (int i=0; i<10; i++)
			employees.Add(Console.ReadLine());
	}

	static void Exercise_4()
	{
		// Is the use of the list justified?
		
		string[] employees_arr = File.ReadAllLines("emp.txt");
		List<string> employees = new List<string>(employees_arr);
		
		for (int i=0; i<10; i++)
			if(employees.Contains(Console.ReadLine()))
				Console.WriteLine("Our employee");
	}
	static void Exercise_5()
	{
		// Is the use of the list justified?
		List<string> employees = new List<string>();
		
		string[] employees_arr = File.ReadAllLines("emp.txt");
		
		foreach (string employee in employees_arr)
			if (!employees.Contains(employee))
				employees.Add(employee);
	}
	
	static void Exercise_6()
	{
		// Will a runtime error appear?
		List<int> myList = new List<int>();
		
		int[] myNumbers = {1, 2, 3, 4, 4, 5, 5, 5};
		
		foreach (int number in myNumbers)
			myList.Add(number);
	}
	
	static void Exercise_7()
	{
		//What will be the output?
		
		List<int> myList = new List<int> {1, 2, 3, 3, 4, 4};
		
		myList.Remove(3);
		myList.RemoveAt(3);
		
		foreach (int number in myList)
			Console.WriteLine(number);
	}
	
	static void Exercise_8()
	{
		// Is this a good approach to save different types in a collection
		ArrayList myList = new ArrayList();
		
		dynamic[] one = {3, "3", true, 3.3};
		dynamic[] two = {4, "4", false, 4.4};
		
		myList.Add(one);
		myList.Add(two);
	}
	
	static void Exercise_9()
	{
		// Is this a good approach to save different types in a collection
		
		List<DB> myList = new List<DB>();
		
		DB one = new DB();
		DB two = new DB();
		
		one.myInt = 3;
		one.myString = "3";
		one.myBool = true;
		one.myDouble = 3.3;

		two.myInt = 4;
		two.myString = "4";
		two.myBool = false;
		two.myDouble = 4.4;		
		
		myList.Add(one);
		myList.Add(two);		
	}
	
	static void Exercise_10()
	{
		// Is this a good approach to save different types in a collection
		
		var myList = new List<DB>();
		
		var one = new DB();
		var two = new DB();
		
		one.myInt = 3;
		one.myString = "3";
		one.myBool = true;
		one.myDouble = 3.3;

		two.myInt = 4;
		two.myString = "4";
		two.myBool = false;
		two.myDouble = 4.4;		
		
		myList.Add(one);
		myList.Add(two);		
	}
	
	class DB
	{
		public int myInt;
		public string myString;
		public bool myBool;
		public double myDouble;
	}
	
	static void Exercise_11()
	{
		// Is this a good approach to save different types in a collection
		
		var myList = new List<DB1>();
		
		var one = new DB1(3, "3", true, 3.3);
		var two = new DB1(4, "4", false, 4.4);	
		
		myList.Add(one);
		myList.Add(two);		
	}
	
	class DB1
	{
		public int myInt;
		public string myString;
		public bool myBool;
		public double myDouble;
		
		public DB1(int myInt, string myString, bool myBool, double myDouble)
		{
			this.myInt = myInt;
			this.myString = myString;
			this.myBool = myBool;
			this.myDouble = myDouble;
		}
	}
	
	static void Exercise_12()
	{
		// Is this a good approach to handle two-dimensional data?
		
		int[,] myArr = new int[10, 10];
		
		for (int i=0; i<myArr.GetLength(0); i++)
			for (int j=0; j<myArr.GetLength(0); j++)
				myArr[i, j] = i * j;
	}
	
	static void Exercise_13()
	{
		// Is this a good approach to handle two-dimensional data?
		string[] employees = File.ReadAllLines("input.txt");
		
		string[,] myArr = new string[employees.Length, 10];
		
		for (int i=0; i<employees.Length; i++)
		{
			string[] split = employees[i].Split(';');
			
			for (int j=0; j<10; j++)
				myArr[i, j] = split[j];			
		}
		
		for (int i=0; i<myArr.GetLength(0); i++)
			Console.WriteLine("Salary: " + myArr[i, 2]);
		
	}
	
	static void Exercise_14()
	{
		// Is this a good approach to handle two-dimensional data?
		string[] employees = File.ReadAllLines("input.txt");
		
		string[][] myArr = new string[employees.Length][];
		
		for (int i=0; i<employees.Length; i++)
			myArr[i] = employees[i].Split(';');
		
		foreach (string[] employee in myArr)
			Console.WriteLine("Salary: " + employee[2]);
	}
	
	static void Exercise_15()
	{
		// Is this a good approach to handle two-dimensional data?
		string[] employees = File.ReadAllLines("input.txt");
		
		List<string[]> myList = new List<string[]>();
		
		foreach (string employee in employees)
			myList.Add(employee.Split(';'));

		foreach (string[] employee in myList)
			Console.WriteLine("Salary: " + employee[2]);
	}
	
	static void Exercise_16()
	{
		// Is this a good approach to handle two-dimensional data?
		string[] employees = File.ReadAllLines("input.txt");
		
		List<Employee> myList = new List<Employee>();
		
		foreach (string employee in employees)
			myList.Add(new Employee(employee));

		foreach (Employee employee in myList)
			Console.WriteLine("Salary: " + employee.salary);
	}
	
	class Employee
	{
		public string name = "";
		public bool active = false;
		public double salary = 0.00;
		
		public Employee (string rawLine)
		{
			string[] temp = rawLine.Split(';');
			
			if (temp.Length < 3)
				return;
			
			name = temp[0];
			active = bool.Parse(temp[1]);
			salary = double.Parse(temp[2]);
		}
	}
	
//////////////////////////////

	class Temperature
	{
		public string season 	= "";
		public double average 	= 0.00;
		public double min 		= 0.00;
		public double max 		= 0.00;
		
		public Temperature(string season)
		{
			this.season = season;
		}
	}
	
	static void Exercise_17()
	{
		// Will a runtime error appear?
		var temperatures = new Temperature[4];
		
		temperatures[0].season = "Spring";
		temperatures[1].average = 15.3;
	}

	static void Exercise_18()
	{
		// Is the approach ideal?
		
		Temperature[] temperatures = 
		{
			new Temperature("Spring"),
			new Temperature("Summer"),
			new Temperature("Autumn"),
			new Temperature("Winter")
		};
		
		temperatures[1].average = 15.3;		
	}
	
	static void Exercise_18a()
	{
		// Is the approach ideal?
		Temperature[,] temperatures = 
		{
			{
				new Temperature("Spring"),
				new Temperature("Summer"),
				new Temperature("Autumn"),
				new Temperature("Winter")
			},
			{
				new Temperature("Spring"),
				new Temperature("Summer"),
				new Temperature("Autumn"),
				new Temperature("Winter")
			}			
		};
		
		//Spring 2019
		temperatures[0, 0].average = 15.3;
		//Winter 2020
		temperatures[1, 3].average = 0.8;
	}
	
/////////////////////////////	

	class Season
	{
		public Temperature1 spring = new Temperature1();
		public Temperature1 summer = new Temperature1();
		public Temperature1 autumn = new Temperature1();
		public Temperature1 winter = new Temperature1();
	}
	
	class Temperature1
	{
		public double average 	= 0.00;
		public double min 		= 0.00;
		public double max 		= 0.00;
	}
	
	static void Exercise_19()
	{
		// Is the approach ideal?
		
		var season = new Season();
		
		season.spring.average = 15.3;		
	}
	
	static void Exercise_19a()
	{
		// Is the approach ideal?
		var temperature = new Dictionary<int, Season>();
		
		foreach (int year in new int[]{2019,2020})
			temperature.Add(year, new Season());
			
		temperature[2019].spring.average = 15.3;
		temperature[2020].winter.average = 0.8;
		
		
	}

	static void Exercise_20()
	{
		//Which value does the variable "exist" have?
		//Which elements does the list have after the remove operation?
		
		int[] input = new int[]{4, 3, 2, 1, 6};
		List<int> myList = new List<int>(input);
		
		bool exist = myList.Contains(6);
		myList.Remove(4);
	}

	class Exercise_21()
	{
		//Which function/s will produce a run-time error and why?
		//In case ex2 will not produce an error: will the method check every element?
		
		static void Main
		{
			int[] input = {4, 5, 3, 4, 9};
			List<int> myList = new List<int>(input);
			
			
			Ex1(myList);
			Ex2(myList);
			
			Console.ReadLine();
		}
		
		static void Ex1(List<int> myList)
		{
			foreach (int myInt in myList)
				if (myInt >= 4)
					myList.Remove(myInt);
		}
		
		static void Ex2(List<int> myList)
		{
			for (int i=0; i<myList.Length; i++)
				if (myList[i] >= 4)
					myList.RemoveAt(i);
		}
	}
}


/*
Exercise_1: no 
because the number of US states is known at design time. There will be no need to add a US state at runtime, neither will we need to check if a certain state exists.

Exercise_2: no
although we do not know the number of employees at design time, the split functions creates us a fitted array, which we then do not extend neither do we want to check the existence of a certain element.

Exercise_3: yes
we get a fitted array from the split function, which we then want to extend  

Exercise_4: yes
because we want to check the existence of a certain element

Exercise_5: yes
because we want to create a list without double entries

Exercise_6: no
a list can have doubled entries, because it is an indexed collection (meaning that the index is unique)

Exercise_7: 1 2 3 4
Remove(3) removes only the first appearing 3.
RemoveAt(3) removes the element at the index 3 (hence the fourth element)

Exercise_8: no
when you want to put several types into a collection, use a custom class as in Exercise_11.
Do not use dynamic types. C# is a strongly typed language. Types bring security, do not undermine one of the key principles C#.

Exercise_9: yes
but Exercise_11 is better, because it delegates the work of assigning to the constructor = abstraction = hiding of details

Exercise_10: yes
but Exercise_11 is better. Var is syntactic sugar of Microsoft, so that you don't have to repeat two times the class name in one line (won't work in Java, C++ has "auto")

Exercise_11: yes
the ideal approach how to save several types into one collection. Furthermore, the process of assigning is delegated to the constructor, which is in line with one key principle of Object-Oriented Programming, namely abstraction.

PS: for those who are wondering if this is a "hybrid" because of public variables and a public method. No, it is not, because a constructur is not a method. It is executed only once. So, this is still a neat data structure.

Exercise_12: yes
there are few cases where a two-dimensional array is the optimal choice. I has to be a situation where both dimensions are fixed.

Exercise_13: no
the two-dimensional array [,] requires an additional loop to add the data from the split array. The jagged array in Exercise_14 solves that problem.
lacking exception handling in case that the split array has less than 10 elements
presumably, employee data is of several types, so better use a custom type as in Exercise_16

Exercise_14: no
better than Exercise_13, because the jagged array makes one loop obsolete.
still no exception handling in the case that the index 2 does not exist.
still employee data not strongly typed. Exercise_16 is the preferred solution

Exercise_15: no
slightly more readable the Exercise_14 thanks to the foreach loop, but still the same short comings than Exercise_14

Exercise_16: yes
the ideal approach how to deal with two-dimensional data, where one dimension is dynamic and one is fixed. (number of employees -> dynamic; categories per elmployee -> fixed)
exception handling introduce. 
custom type allows for several types and is more readable. (employee.salary is way more comprehensible than employee[2])

Exercise_17: yes
because only the array of "Temperature" was instantiated, but not the single "Temperature" instances. See Exercise_18.

Exercise_18: no
too little abstraction, and index reduces readability. Exercise_19 is the ideal approach

Exercise_18a: no
too little abstraction, and index reduces readability. Exercise_19a is the ideal approach

Exercise_19: yes
Exercise_19a: yes

*/