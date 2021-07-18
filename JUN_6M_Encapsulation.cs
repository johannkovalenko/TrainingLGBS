/* Questions
	True or false?
		a) Encapsulation is one of four (some says three) basic priniples of Object Oriented Programming
		b) Encapsulation and Loose Coupling are unrelated topics
		c) The higher the level of encapsulation, the lower is the potential negative effect of one malfunctioning method on the rest of the code 
		d) When the code has only one method, and we change a variable in it, the change potentially affects 100% of the code. 
		e) In order to achieve encapsulation we need to think only of "private" members, small units are not relevant	
		f) static (especially public static) variables reduce the level of encapsulation
		g) a God Object is the effect of lacking encapsulation
		
*/

// Ex 1)

// Check if the classes, methods and variables have the accurate access level (public/private)
using System;
using System.Collections.Generic;

namespace MainSpace
{
	public class MainClass
	{
		public static void Main()
		{
			Ex1.App.Run();
			Ex2.App.Run();
			
			Console.ReadLine();
		}
	}
}

namespace Ex1
{
	public class App
	{
		public static void Run()
		{
			for (int i=0;i<10;i++)
			{
				int cumulated = 0;

				cumulated += i;
				
				Console.WriteLine(cumulated);
			}
		}
	}
}

namespace Ex2
{
	public class App
	{
		public static List<DB> list = new List<DB>();
		
		public static void Run()
		{
			DB db;
			
			for (int i=0;i<10;i++)
			{
				db = new DB();
				
				db.age = i;
				db.name = i.ToString();
				
				list.Add(db);
			}
		}
	}

	public class DB
	{
		public int age;
		public string name;
	}	
}

// Ex 2)

// When would you use which class?
// Has some class a higher level of encapsulation than others? Is there a class that you would not use at all?

class One
{
	static int MyInt;
	
	public static void Run()
	{
		int MyInt2;
	}
}

class Two
{
	int MyInt;
	
	public void Run()
	{
		int MyInt2;
	}
}

class Three
{
	public static void myInt;
	public static void myInt2;
}

class Four
{
	public void myInt;
	public void myInt2;
}

// Ex 3

// Indicate the badly designed class/es and explain why it is/they are badly designed?
// Explain why the rest of the classes are well designed. When would you use which?

class MainClass
{
	static void Main()
	{
		
	}
	
	class Zero
	{
		void MyMethod()
		{
			int myVar1;
			int myVar2;
		}
	}
	
	class One
	{
		int myVar1;
		
		public void MyMethod()
		{
			int myVar2;
			myVar1 = 2;
		}
		
		public void MyMethod2()
		{
			myVar1 = 1;
		}
	}
	
	class Four
	{
		public void MyMethod()
		{
			int myVar1;
			int myVar2;
		}
	}
	
	class Two
	{
		public int myVar1;
		public int myVar2;
	}
	
	class Three
	{
		public int myVar1;
		
		public void MyMethod()
		{
			int myVar2;
		}
	}
	
	class Five
	{
		public int myVar1;
		
		void MyMethod()
		{
			int myVar2;
		}
	}
	
	class Six
	{
		int myVar1;
		
		void MyMethod()
		{
			int myVar2;
		}
	}
}
