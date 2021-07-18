using System;

namespace Exercise_0
{
	// Input: this is the Facade Pattern
	// Explain what problem it solves.
	
	class MainClass
	{
		static void Main()
		{
			Facade facade = new Facade();
			int revenue = facade.Revenue();
			Console.WriteLine(revenue);
		}
	}

	class Facade
	{
		Kia     kia     = new Kia();
		Hyundai hyundai = new Hyundai();

		public int Revenue()
		{
			int revenue = 0;

			revenue += kia.Revenue();
			revenue += hyundai.Revenue();

			return revenue;
		} 
	}

	class Kia
	{
		public int Revenue()
		{
			return 400;
		}
	}

	class Hyundai
	{
		public int Revenue()
		{
			return 300;
		}
	}
}



using System;

class App
{
	static void Main()
	{
		
	}
}

namespace Exercise_1
{
	//Approach: data structure
	//Plus: Dependency injection (passing instance as parameters)
	//Minus: my data is available on a high level ("Main")
	
	public class App
	{
		public void Main()
		{
			var db = new DB();
			new Step1().Run(db);
		}
	}
	
	class Step1
	{
		public void Run(DB db)
		{
			
		}
	}
	
	class DB
	{
		public int[] myInt = new int[4];
	}
}

namespace Exercise_2
{
	//Approach: object 
	//Creating objects is a good start
	//Plus: myInt is moved to a lower level and private (not on Main level anymore)
	//Minus: But then class "Step1" will grow too big (indicator: class with more than two public methods)
	
	public class App
	{
		public void Main()
		{

			var step1 = new Step1();
			
			step1.Do();
			step1.Next();
			step1.Next2();
		}
	}
	
	class Step1
	{
		int[] myInt = new int[4];
		public void Do()
		{
			// 25 lines
		}

		public void Next()
		{
			// 25 lines
		}
		
		public void Next2()
		{
			// 25 lines
		}
	}
}

namespace Exercise_3
{
	//Facade:
	// Plus: myInt not on high level "Main", class "Step1" still small.
	// Minus: more code to write
	
	public class App
	{
		public void Main()
		{
			var step1 = new Step1();
			
			step1.doo.Run();
			step1.next.Run();
			step1.next2.Run();
		}
	}
	
	class Step1
	{
		int[] myInt = new int[4];

		public Do 		doo;
		public Next 	next;
		public Next2 	next2;
		
		public Step1()
		{
			doo 	= new Do(myInt);
			next 	= new Next(myInt);
			next2 	= new Next2(myInt);			
		}
	}
	
	class Do
	{
		int[] myInt;
		
		public Do(int[] myInt)
		{
			this.myInt = myInt;
		}
		
		public void Run()
		{
			// 25 lines
		}	
	}
	
	class Next
	{
		int[] myInt;
		
		public Next(int[] myInt)
		{
			this.myInt = myInt;
		}
		
		public void Run()
		{
			// 25 lines
		}	
	}

	class Next2
	{
		int[] myInt;
		
		public Next2(int[] myInt)
		{
			this.myInt = myInt;
		}
		
		public void Run()
		{
			// 25 lines
		}		
	}
}

