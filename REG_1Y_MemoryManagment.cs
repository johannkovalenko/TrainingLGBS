//Exercise 1

// What do you except? Is any function faster than the other? If yes, then explain why.

using System;
using System.Diagnostics;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		
		List<int> list = new List<int>();
		
		for (int i=0;i<50000000;i++)
			list.Add(i);
		
		stopwatch.Start();
		
		Ex1(list);
		
		stopwatch.Stop();
		Console.WriteLine("Ex1: " + stopwatch.Elapsed.Milliseconds);
		
		stopwatch.Reset();
		stopwatch.Start();
		
		Ex2(list);
		
		stopwatch.Stop();
		Console.WriteLine("Ex2: " + stopwatch.Elapsed.Milliseconds);

		Console.ReadLine();
	}
	
	static void Ex1(List<int> list)
	{
		int temp;
		
		for (int i=0;i<list.Count;i++)
			temp = list[i];
	}
	
	static void Ex2(List<int> list)
	{
		int temp;
		
		int count = list.Count;
		
		for (int i=0;i<count;i++)
			temp = list[i];
	}
}

// Exercise 2


//Which method is faster and why?


using System;
using System.Collections.Generic;
using System.Diagnostics;

class MainClass
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		
		stopwatch.Start();
		Ex1();
		stopwatch.Stop();
		
		Console.WriteLine("Ex1: " + stopwatch.Elapsed.Milliseconds);
		
		stopwatch.Reset();
		
		
		stopwatch.Start();
		Ex2();
		stopwatch.Stop();
		
		Console.WriteLine("Ex2: " + stopwatch.Elapsed.Milliseconds);
		
		Console.ReadLine();
	}
	
	static void Ex1()
	{
		List<int> myList = new List<int>();
		
		for (int i=0; i<50000; i++)
			myList.Add(i);
		
		for (int i=0; i<myList.Count; i++)
		{
			myList.RemoveAt(i);
			--i;
		}
		
	}
	
	static void Ex2()
	{
		List<int> myList = new List<int>();
		
		for (int i=0; i<50000; i++)
			myList.Add(i);
		
		List<int> filteredList = new List<int>();
		
		for (int i=0; i<myList.Count; i++)
			filteredList.Add(myList[i]);
		
		myList.Clear();
	}
}

// Exercise 3

//Please explain why 
// 	a) arrays are faster than lists.
//  b) reading is faster than writing is faster than adding

// timeAddToList    389 ms
// timeReadList      47 ms
// timeWriteList    103 ms

// timeAddToArray   161 ms
// timeReadArray     37 ms
// timeWriteArray    46 ms


using System;
using System.Collections.Generic;
using System.Diagnostics;

class MainClass
{
	static Stopwatch stopwatch = new Stopwatch();
	static int iterations = 50000000;
	
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		List<int> myList = new List<int>();
		int[] myArr	= new int[iterations];
		
		int timeAddToList 	= AddToList		(stopwatch, myList);
		int timeReadList 	= ReadList		(stopwatch, myList);
		int timeWriteList 	= WriteList		(stopwatch, myList);
		int timeAddToArray 	= AddToArray	(stopwatch, myArr);
		int timeReadArray	= ReadArray		(stopwatch, myArr);	
		int timeWriteArray	= WriteArray	(stopwatch, myArr);		
		
		Console.WriteLine("timeAddToList    " + timeAddToList);
		Console.WriteLine("timeReadList     " + timeReadList);
		Console.WriteLine("timeWriteList    " + timeWriteList);
		
		Console.WriteLine("timeAddToArray   " + timeAddToArray);
		Console.WriteLine("timeReadArray    " + timeReadArray);
		Console.WriteLine("timeWriteArray   " + timeWriteArray);
		
		Console.ReadLine();
	}
	
	static int AddToList(Stopwatch stopwatch, List<int> myList)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		for (int i=0;i<iterations; i++)
			myList.Add(i);
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}

	static int ReadList(Stopwatch stopwatch, List<int> myList)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		int temp;
		int count = myList.Count;
		
		for (int i=0;i<count; i++)
			temp = myList[i];
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}

	static int WriteList(Stopwatch stopwatch, List<int> myList)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		int count = myList.Count;
		
		for (int i=0;i<count;i++)
			myList[i] = 1;
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}
	
	static int AddToArray(Stopwatch stopwatch, int[] myArr)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		for (int i=0;i<iterations; i++)
			myArr[i] = i;
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}

	static int ReadArray(Stopwatch stopwatch, int[] myArr)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		int temp;
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			temp = myArr[i];
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}

	static int WriteArray(Stopwatch stopwatch, int[] myArr)
	{
		stopwatch.Reset();
		stopwatch.Start();
		
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			myArr[i] = 1;
		
		stopwatch.Stop();
		return stopwatch.Elapsed.Milliseconds;
	}
}

// Exercise 4

	//Draw how an array looks like in the memory.
	//How does the machine know when the array ends?
	
// Exercise 5

// You have below data types. Draw a picture how (in your opinion) the data is saved into the memory.
// and how we read the data

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		bool[] 		myBools 	= {false, false, true, false, true};
		int[] 		myInts 		= {3, 4, 3, 2, 7, 5};
		string[]	myStrings	= {"Pawel", "Michal", "Paulina"};
		
		List<int[]> myList = new List<int[]>();
		myList.Add(new int[] {3, 4, 3, 2});
		myList.Add(new int[] {3, 2, 7, 4});
		
		foreach (bool myBool in myBools)
			Console.WriteLine(myBool);
			
		for (int i=0;i<myBools.Length;i++)
			Console.WriteLine(myBools[i]);
		
		foreach (int myInt in myInts)
			Console.WriteLine(myInts);
			
		foreach (int myString in myStrings)
			Console.WriteLine(myString);
			
		for (int i=0;i<myList.Count;i++)
			for (int j=0;j<myList[i].Length;j++)
				Console.WriteLine(i + " " + j + " " + myList[i][j]);
	}
}

// Exercise 6

// You have below complex data types. Draw a picture how (in your opinion) the data is created in the memory.
// and how we read/write the data

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		List<Employee> employees = new List<Employee>();
		
		employees.Add(Emp1());
		employees.Add(Emp2());
		
		foreach (Employee employee in employees)
		{
			Console.Write(employee.name);
			Console.Write(employee.age);
			Console.Write(employee.isActive);
			Console.Write(employee.salary);
			Console.Write(employee.hired);
			Console.WriteLine();
		}
		
		Console.ReadLine();
	}
	
	static Employee Emp1()
	{
		Employee employee = new Employee();
		employee.name 		= "Patryk";
		employee.age 		= 30;
		employee.isActive 	= true;
		employee.salary		= 7549.30;
		employee.hired		= new DateTime(2018, 7, 1);
		
		return employee;
	}

	static Employee Emp2()
	{
		Employee employee = new Employee();
		employee.name 		= "Pawel";
		employee.age 		= 25;
		employee.isActive 	= true;
		employee.salary		= 5030.24;
		employee.hired		= new DateTime(2016, 5, 1);
		
		return employee;
	}
	
	class Employee
	{
		public string 	name;
		public int		age;
		public bool		isActive;
		public double	salary;
		public DateTime hired;
	}
}

// Exercise_7

//Show on the example, why it is essential for the machine to know the type of the variable. (for the single instance and for collections
//Show what would happen, if you did an incorrect cast

//Remember: types are essential, when your preferred language (VBA or Python) does not require them, it does not mean that they do not exist. VBA and Python find the type for you on runtime -> slower

using System;
using System.Collections;

class MainClass
{
	static void Main()
	{
		ArrayList employees = new ArrayList();
		
		employees.Add(Emp1());
		employees.Add(Emp2());
		
		foreach (object employee in employees)
		{
			Console.Write(employee.name);
			Console.Write(employee.age);
			Console.Write(employee.isActive);
			Console.Write(employee.salary);
			Console.Write(employee.hired);
			Console.WriteLine();
		}
	}
	
	static object Emp1()
	{
		object employee = new Employee();
		employee.name 		= "Patryk";
		employee.age 		= 30;
		employee.isActive 	= true;
		employee.salary		= 7549.30;
		employee.hired		= new DateTime(2018, 7, 1);
		
		return employee;
	}

	static object Emp2()
	{
		object employee = new Employee();
		employee.name 		= "Pawel";
		employee.age 		= 25;
		employee.isActive 	= true;
		employee.salary		= 5030.24;
		employee.hired		= new DateTime(2016, 5, 1);
		
		return employee;
	}
	
	class Employee
	{
		object name;
		object age;
		object isActive;
		object salary;
		object hired;
	}
}