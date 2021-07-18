//Solutions at the bottom

using System;
using System.Collections.Generic;

class App
{
	static void Main()
	{
		Exercise_3();
		Exercise_4();
		//Exercise_6();
		//Exercise_7();
		Exercise_9();
		
		Console.ReadLine();
	}
	
	static void Exercise_1a()
	{
		// What is the result: true or false?
		
		int a = 1;
		int b = 1;
		int c = 2;		
		
		Console.WriteLine(a == b);
		Console.WriteLine(a == c);
	}
	
	static void Exercise_1b()
	{
		// What is the result: true or false?
		
		string[] myArr1 = {"Paul", "John"};
		string[] myArr2 = {"Paul", "John"};
		string[] myArr3 = {"John", "Paul"};
		
		
		Console.WriteLine(myArr1 == myArr2);
		Console.WriteLine(myArr1 == myArr3);
	}

	static void Exercise_1c()
	{
		// What is the result: true or false?
		
		int[] a = {1, 2};
		int[] b = {1, 2};
		int[] c = {1, 3};		
		
		Console.WriteLine(a == b);
		Console.WriteLine(a == c);
	}
	
	static void Exercise_1d()
	{
		// What is the result: true or false?
		
		string myStr1 = "Paul";
		string myStr2 = "Paul";
		string myStr3 = "John";		
		
		Console.WriteLine(myStr1 == myStr2);
		Console.WriteLine(myStr1 == myStr3);
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
		//What are the results?
		
		string 		myStr 	= "Paul";
		int 		myInt 	= 1;
		string[] 	myStrs 	= {"Paul", "John"};
		int[] 		myInts 	= {1, 2};
		var 		emp 	= new Employee("John", 34, 1500.37, true);
		
		Exercise_3_Helper(myStr, myInt, myStrs, myInts, emp);
		
		Console.WriteLine(myStr + " " + myInt + " " + myStrs[1] + " " + myInts[1] + " " + emp.name);
	}
	
	static void Exercise_3_Helper(string myStr, int myInt, string[] myStrs, int[] myInts, Employee emp)
	{
		myStr = "Pat";
		myInt = 2;
		myStrs[1] = "Mike";
		myInts[1] = 3;
		emp.name = "Paul";
	}
	
	static void Exercise_4()
	{
		// What are the results?
		//Is the use of "ref" justified?
		
		string 		myStr 	= "Paul";
		int 		myInt 	= 1;
		
		Exercise_4_Helper(ref myStr, ref myInt);
		
		Console.WriteLine(myStr + " " + myInt);
	}
	
	static void Exercise_4_Helper(ref string myStr, ref int myInt)
	{
		myStr = "Pat";
		myInt = 2;
	}

	static void Exercise_5()
	{
		//What are the results?
		//Is the use of ref justified?
		
		string[] 	myStrs 	= new string[] {"Paul", "John"};
		int[] 		myInts 	= new int[] {1, 2};
		var 		emp 	= new Employee("John", 34, 1500.37, true);
		
		Exercise_5_Helper(ref myStrs, ref myInts, ref emp);
		
		Console.WriteLine(myStrs[1] + " " + myInts[1] + " " + emp.name);
	}
	
	static void Exercise_5_Helper(ref string[] myStrs, ref int[] myInts, ref Employee emp)
	{
		myStrs[1] = "Mike";
		myInts[1] = 3;
		emp.name = "Paul";
	}
	
	static void Exercise_6()
	{
		//What is the result?

		var 		emp 	= new Employee("John", 34, 1500.37, true);
		
		Exercise_6_Helper(emp);
		
		Console.WriteLine(emp.name);
	}
	
	static void Exercise_6_Helper(Employee empX)
	{
		empX = new Employee("Paul", 34, 1500.37, true);
	}
	
	static void Exercise_7()
	{
		//What is the result?
		//Is the use of "ref" justfied?
		//Is this good practice?

		var 		emp 	= new Employee("John", 34, 1500.37, true);
		
		Exercise_7_Helper(ref emp);
		
		Console.WriteLine(emp.name);
	}
	
	static void Exercise_7_Helper(ref Employee empX)
	{
		empX = new Employee("Paul", 34, 1500.37, true);
	}
	
	static void Exercise_8()
	{
		//What are the results?
		
		var a = new List<int>();
		var b = new List<int[]>();
		
		var arr = new int[1];
		
		for (int i=0; i<5; i++)
		{
			a.Add(i);
			arr[0] = i;
			b.Add(arr);
		}
		
		foreach (int myInt in a)
			Console.WriteLine(myInt);
		
		foreach (int[] myArr in b)
			Console.WriteLine(myArr[0]);
	}
	
	static void Exercise_9()
	{
		//What are the results?
		
		var a = new List<int>();
		var b = new List<int[]>();
		
		for (int i=0; i<5; i++)
		{
			a.Add(i);
			
			var arr = new int[1];
			arr[0] = i;
			b.Add(arr);
		}
		
		foreach (int myInt in a)
			Console.WriteLine(myInt);
		
		foreach (int[] myArr in b)
			Console.WriteLine(myArr[0]);
	}
	
	static void Exercise_10()
	{
		// What are the results?
		// Is this good practice?
		int output1;
		int output2;
		
		Exercise_10_Helper(20, out output1, out output2);
		
		Console.WriteLine(output1 + " " + output2);
	}
	
	static void Exercise_10_Helper(int input, out int output1, out int output2)
	{
		output1 = input + 5;
		output2 = input + 7;
	}
	
	static void Exercise_10a()
	{
		// Is this good practice?
		
		var container = new Exercise_10a_Class();
		
		Exercise_10a_Helper(20, container);
		
		Console.WriteLine(container.output1 + " " + container.output2);
	}
	
	static void Exercise_10a_Helper(int input, Exercise_10a_Class container)
	{
		container.output1 = input + 5;
		container.output2 = input + 7;
	}
	
	class Exercise_10a_Class
	{
		public int output1;
		public int output2;
	}
	
	static void Exercise_11()
	{
		// Show the conceptual error and repair it.
		
		List<int[]> list = new List<int[]>();
		
		int[] db = new int[2];
		
		for (int i=0;i<3;i++)
		{
			db[0] = i;
			db[1] = i * 2;
			
			list.Add(db);
		}
		
		foreach (int[] instance in list)
			Console.WriteLine(instance[0] + "   " + instance[1]);
		
		Console.ReadLine();
		// 0 0
		// 1 2
		// 2 4
	}
	
	class Exercise_12
	{
		//Which value will myInt, myArr[0] and myGlobalArr[0] have at the end of Main()?
		static int[] myGlobalArr = {34, 35, 36};
		
		static void Main()
		{
			int 	myInt = 30;
			int[]	myArr = {100, 150, 200};
			
			Change(myInt, myArr);
			
			Console.WriteLine("Int " + myInt);
			Console.WriteLine("MyArr[0] " + myArr[0]);
			Console.WriteLine("MyGlobalArr[0] " + myGlobalArr[0]);
			
			Console.ReadLine();
		}
		
		static void Change(int myInt, int[] myArr)
		{
			myInt 		= 50;
			myArr[0]	= 45;
			myGlobalArr[0] = 70;
		}
	}	
}

/*


Exercise_1a: true, false
	integer is a primitive type, comparing primitive types means comparing their VALUE.
	
Exercise_1b: false, false 
	an array is a complex type, comparing complex types means comparing their ADDRESS.
	
Exercise_1c: false, false
	an array is a complex type, comparing complex types means comparing their ADDRESS.
	
Exercise_1d: true, false
	This isn't as trivial as it seems. A string is a array of chars, but is not treated as a complex type. It is a immutable type. (The language C for example )
	
Exercise_2: false, false
	objects (= instance of classes) are Reference types, hence comparing them means comparing their addresses, and not their values.

Exercise_3: Paul 1 Mike 3 Paul
	primitive types are pased per value, whereas complex types are passing per reference. When we transfer per reference we are operating the whole time on the same address in the memory.
	
Exercise_4: Pat 2, rather no
	The effect of "ref" is that a variable is passed by reference.
	I, personally see no sense in passing a primitive type by reference

Exercise_5: Mike 3 Paul, no
	No, but it is not the reason that comes to our minds first, namely that complex types are by default passed per reference, so "ref" is a redundancy.
	Reference type is not the same as passing per "ref". See Exercise_6 and Exercise_7, which show the difference.
	No, because we are not creating a new instance of our variables in the Exercise_5_Helper method.
	
Exercise_6: John 
	(compare to Exercise_7)
	This one is tricky. Let's draw map how it might look it in the memory:
	Main Method:
		var emp: 			address 40	value null
		new Employee: 		address 100	
		emp = new Employee: address 40	value 100
	Helper Method:
		var empX:			address 50	value 100
		new Employee:		address 200
		empX = new Employee	address 50	value 200
		
	The precious info is the Employee instance. It is first at "100", the new instance is at "200". But the container of the address is first 40 and then 50.
	
Exercise_7: Paul, yes, no
	(compare to Exercise_6)

	Main Method:
		var emp: 			address 40	value null
		new Employee: 		address 100	
		emp = new Employee: address 40	value 100
	Helper Method:
		var empX:			address 40	value 100
		new Employee:		address 200
		empX = new Employee	address 40	value 200
		
	The precious info is the Employee instance. It is first at "100", the new instance is at "200". The effect of "ref" is, the also the address of the ocntainer is passed. So now it is all the time "40" (vs. "40" and "50" in Exercise_6).

	This is the only use case of "ref", so it is justified.
	But this is not good practice. Avoid situations where the receiving method creates a new instance of the passed variable. Think of the abstraction hierarchy/pyramid. 
	
Exercise_8: a: 0 1 2 3 4, b: 4 4 4 4 4
	(compare to Exercise_9)
	
	most likely not what we wanted to achieve. What went wrong? "a" is a list of integers. Integers are primitive types, so the list contains the VALUE of the integer. "b" is a list of integer arrays. Arrays are complex types, so the list contains the ADDRESS of the integer arrays. The mistake in this example is that there exists only one address of the array. That programm hence overwrites five times the same address in memory. The list contains five elements, five times the same address.
	
Exercise_9: a: 0 1 2 3 4, b: 0 1 2 3 4
	(compare to Exercise_8)
	most likely what we wanted to achieve. We needed to put the instance creation of "arr" within the loop so that we get five addresses of the array.
	
Exercise_10: 25, 27, rather no
	"out" is a feature of C# when we want to return more than one value. Java and C++ do not have it. I try to avoid "out", though it is not completely bad practice. Compare to Exercise_10a for my preferred solution.
	
Exercise_10a: yes
	My preferred solution of Exercise_10. Using a data structure.
*/