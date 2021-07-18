/* Questions
	True or false?
		a) An object is an instance of a class
		b) Usually, "object" does not refer to static classes
		c) We can create an instance of a static class
		d) A non-static variable is accessible on runtime without the creation of an instance
		e) A non-static variable can exist only once (have one instance)
		f) We prefer non-static variables because it is easier to pass data to other methods selectively (increasing hence the overall level of encapsulation)
		g) We prefer static methods as they allow for polymorphism
		h) A Module in VBA is the equivalent of a static class in C#
		i) VBA does not have the concept of non-static classes
		j) VBA does not have constructors
		k) VBA does not have constructors with parameters
		l) The constructor is a normal method
		m) The constructor is a not a normal method, as it is run only once during instantiation, and cannot be run with a method call.

*/


/*
	General recommendation: 
		reduce the use of static classes to a minimum.
	
	public static variables: 
		never use them. 100% of your code will have access to them. -> Lack of encapsulation
	
	public static methods plus private static variables:
		avoid them. Static methods do not allow for polimorphism. 
		
		Additional information for Regulars:
			Polimorphism is needed for the Open/Closed principle and the Dependency Inversion principle
			When you are 100% sure that your method will never be subject to polimorphism then it can be static.
			Those are typically segregated methods for multiple reuse. Put them into a DLL.

	public non-static variables: 
		use them in data structures (only public variables, no methods)
		
		Additional information for Regulars:
			relatively high level of encapsulation, 
				as only the method that instantiates the data structure has access to it.
				this method then decide to which other methods it gives the access via parameters.
	
	public non-static methods plus private non-static variables:
		most preferred constellation
		
		Additional information for Regulars:
			high level of encapsulation.
			if the class grows too big though, there needs to be Segregation of Concern (requiring the use of data structures)
*/

using System;

class App
{
	static void Main()
	{
		
	}
}

namespace Exercise_1
{
	// Will lines will not compile?
	
	public class App
	{
		public static void Main1()
		{
			Class1.myInt = 1;
			Class2.myInt = 1;
			Class3.myInt = 1;
			Class4.myInt = 1;
		}
	}
	static class Class1
	{
		public static int myInt;
	}
	
	class Class2
	{
		public static int myInt;
	}

	static class Class3
	{
		public int myInt;
	}
	
	class Class4
	{
		public int myInt;
	}
}

namespace Exercise_2
{
	// Which class is better?

	static class Class1
	{
		public static int myInt;
	}
	
	class Class2
	{
		public static int myInt;
	}
}

namespace Exercise_2a
{
	// Which class is almost always better?

	static class Class1
	{
		public static int myInt;
	}
	
	class Class2
	{
		public int myInt;
	}
}

namespace Exercise_2b
{
	// Is this good practice?
	
	class Class1
	{
		public static int myInt;
		public int myInt1;
	}
}

namespace Exercise_2c
{
	// What are the names of the classes?
	// What are the names of the instances?
	// What are the names of the class variables?
	// What are the names of the instance variables?
	
	// PS: instance = object
	
	public class App
	{
		public void Main()
		{			
			Class2 class2 = new Class2();
		}
	}

	static class Class1
	{
		public static int myInt;
	}
	
	class Class2
	{
		public int myInt;
	}
}

namespace Exercise_3
{
	public class App
	{
		public static void Main1()
		{
			// How many variables exist at this line?
			
			Class2 a = new Class2();
			
			// How many variables exist at this line?
			
			Class2 b = new Class2();
			
			// How many variables exist at this line?
			
			b = new Class2();
			
			// How many variables exist at this line?
			
			b = null;
			
			// How many variables exist at this line?
		}
	}
	
	static class Class1
	{
		public static int myInt;
		public static int myInt2;
	}
	
	class Class2
	{
		public int myInt;
		public int myint2;
	}
	
}

static class Exercise_4
{
	// is "static" justified?
	
	public static int myInt;
	public static string myString;
}

static class Exercise_5
{
	// is "static" justified?
	
	static int myInt;
	static string myString;
	
	public static void MyMethod()
	{
		myInt++;
		myString += "a";
	}
}

static class Exercise_5a
{
	// is "static" justified?
	
	public static void MyMethod()
	{
		// 20 lines
	}
}

namespace Exercise_6
{
	// Which methods will be able to change the values of db.myInt and db.myInt2?
	
	public class App
	{
		public void Main()
		{
			DB db = new DB();
			db.myInt = 1;
			db.myInt2 = 2;
			
			new Step1().Run();
			new Step2().Run(db);
			new Step3(db).Run();
		}
	}
	
	class Step1
	{
		public void Run()
		{}
		
		void Helper()
		{}
	}

	class Step2
	{
		public void Run(DB db)
		{}
		
		void Helper()
		{}
	}
	
	class Step3
	{
		DB db;
		public Step3(DB db)
		{
			this.db = db;
		}
		
		public void Run()
		{}
		
		void Helper()
		{}
	}
	
	class DB
	{
		public int myInt;
		public int myInt2;
	}
}

namespace Exercise_7
{
	// What will be the results?
	// Is "counter" as a instance variable justified?
	
	public class App
	{
		public void Main()
		{
			for (int i=0; i<5; i++)
				new Step1().Add();
		}
	}
	
	class Step1
	{
		int counter;
		
		public void Add()
		{
			counter++;
			Console.WriteLine(counter);
		}
	}
}

namespace Exercise_7a
{
	// What will be the results?
	// Is "counter" as a instance variable justified?
	
	public class App
	{
		public void Main()
		{
			Step1 step1 = new Step1();
			
			for (int i=0; i<5; i++)	
				step1.Add();
		}
	}
	
	class Step1
	{
		int counter;
		
		public void Add()
		{
			counter++;
			Console.WriteLine(counter);
		}
	}
}

namespace Exercise_7b
{
	// What will be the results?
	// Is "counter" as a instance variable justified?
	
	public class App
	{
		public void Main()
		{
			for (int i=0; i<5; i++)
				new Step1().Add();
		}
	}
	
	class Step1
	{
		int counter;
		
		public void Add()
		{
			counter++;
			Console.WriteLine(counter);
			Helper();
		}
		
		void Helper()
		{
			counter++;
			Console.WriteLine(counter);			
		}
	}
}

namespace Exercise_8
{
	// What will be the results?
	
	public class App
	{
		public void Main()
		{
			for (int i=0; i<3; i++)
				new Step1().Add();
		}
	}
	
	class Step1
	{
		public Step1()
		{
			Console.WriteLine("Constructor");
		}
		
		public void Add()
		{
			Console.WriteLine("Add");
		}
	}
}

namespace Exercise_8a
{
	// What will be the results?
	
	public class App
	{
		public void Main()
		{
			Step1 step1 = new Step1();
			
			for (int i=0; i<3; i++)	
				step1.Add();
		}
	}
	
	class Step1
	{
		public Step1()
		{
			Console.WriteLine("Constructor");
		}
		
		public void Add()
		{
			Console.WriteLine("Add");
		}
	}
}

namespace Exercise_9
{
	// What will be the result?
	// Is this best practice?
	
	public class App
	{
		public void Main()
		{
			int[] myArr = {1, 2};
			
			Step1 step1 = new Step1();
			
			for (int i=0; i<3; i++)
				step1.Add(myArr);
			
			Console.WriteLine(myArr[0]);
		}
	}
	
	class Step1
	{		
		public void Add(int[] myArr)
		{
			myArr[0]++;
			Helper(myArr);
		}
		
		void Helper(int[] myArr)
		{
			myArr[0]++;
		}
	}
}

namespace Exercise_9a
{
	// What will be the result?
	// Is this best practice?
	
	public class App
	{
		public void Main()
		{			
			int[] myArr = null;
			
			Step1 step1 = new Step1();
			
			for (int i=0; i<3; i++)
			{
				myArr = new int[] {i, i};
				step1.Add(myArr);
			}
			
			Console.WriteLine(myArr[0]);
		}
	}
	
	class Step1
	{	
		public void Add(int[] myArr)
		{
			myArr[0]++;
			Helper(myArr);
		}
		
		void Helper(int[] myArr)
		{
			myArr[0]++;
		}
	}
}

namespace Exercise_9b
{
	// What will be the result?
	// Is this best practice?
	
	public class App
	{
		public void Main()
		{
			int[] myArr = {1, 2};
			
			Step1 step1 = new Step1(myArr);
			
			for (int i=0; i<3; i++)
				step1.Add();
			
			Console.WriteLine(myArr[0]);
		}
	}
	
	class Step1
	{	
		int[] myArr;
		
		public Step1(int[] myArr)
		{
			this.myArr = myArr;
		}
		
		public void Add()
		{
			myArr[0]++;
			Helper();
		}
		
		void Helper()
		{
			myArr[0]++;
		}
	}
}

namespace Exercise_9c
{
	// What will be the result?
	// Is this best practice?
	
	public class App
	{
		public void Main()
		{			
			int[] myArr = null;
			
			Step1 step1 = new Step1(myArr);
			
			for (int i=0; i<3; i++)
			{
				myArr = new int[] {i, i};
				step1.Add();
			}
			
			Console.WriteLine(myArr[0]);
		}
	}
	
	class Step1
	{	
		int[] myArr;
		
		public Step1(int[] myArr)
		{
			this.myArr = myArr;
		}
		
		public void Add()
		{
			myArr[0]++;
			Helper();
		}
		
		void Helper()
		{
			myArr[0]++;
		}
	}
}

namespace Exercise_10
{
	// Below code does not compile. Show the conceptual error and repair it.

	using System;
	using System.Collections.Generic;

	class MainClass
	{
		static void Main()
		{
			List<DB> list = new List<DB>();
			
			for (int i=0;i<3;i++)
			{
				string answer = Console.ReadLine();
				DB.iteration 	= i;
				DB.answer 		= answer;
				
				list.Add(DB);
			}
			
			foreach (DB db in list)
				Console.WriteLine(db.iteration + "   " + db.answer);
			
			Console.ReadLine();
		}
	}

	class DB
	{
		public static int iteration;
		public static string answer;
	}	
}

namespace Exercise_11
{
	//Why does this code not compile?
	//Correct the code

	class MainClass
	{
		class Employee
		{
			public string name;
			public int age;
			public int salary;
		}
		
		static void Main
		{
			Employee.name 	= "Michal";
			Employee.age	= 33;
			Employee.salary = 7000;
		}
	}
}
