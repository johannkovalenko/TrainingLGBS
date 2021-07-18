// Exercise 1

// Below examples show three abstract classes. Where would you use an interface instead? Please explain.
// What is the relation between Interface and Abstract Class? Is one of them more general? if so, then which?

using System;

class MainClass
{
	static void Main()
	{
		
	}
}

namespace Ex1
{
	public abstract class Car
	{
		public abstract void Plan();
		public abstract void Build();
		public abstract void Sell();
	}
	
	public class Kia : Car
	{
		public override void Plan()
		{
			Console.WriteLine("Plan Kia");
		}

		public override void Build()
		{
			Console.WriteLine("Build Kia");
		}

		public override void Sell()
		{
			Console.WriteLine("Sell Kia");
		}
	}
}

namespace Ex2
{
	public abstract class Car
	{
		public abstract void Plan();
		public virtual void Build()
		{
			Console.WriteLine("Build General");
		}
		
		public virtual void Sell()
		{
			Console.WriteLine("Sell General");
		}
	}
	
	public class Kia : Car
	{
		public override void Plan()
		{
			Console.WriteLine("Plan Kia");
		}
	}
}	

namespace Ex3
{
	public abstract class Car
	{
		public abstract void Plan();
		public virtual void Build()
		{
			Console.WriteLine("Build General");
		}
		
		public virtual void Sell()
		{
			Console.WriteLine("Sell General");
		}
	}
	
	public class Kia : Car
	{
		public override void Plan()
		{
			Console.WriteLine("Plan Kia");
		}

		public override void Build()
		{
			base.Build();
			Console.WriteLine("Build Kia");
		}
	}
}

// Exercise 2

// Which Ex should be refactored into:
	// 1) a function with parameters 
	// 2) an interface
	// 3) an abstract class
	
//Please explain your choice

using System;

class MainClass
{
	static void Main()
	{
		Ex1();
		Ex2();
		Ex3();
	}
	
	static void Ex1()
	{
		string answer = Console.ReadLine();
		
		int tax = 0;
		int multiplier = 0;
		
		switch (answer)
		{
			case "Kia":
				multiplier = 5;
				tax = 30 * multiplier;
				break;
			
			case "Peugeot":
				multiplier = 6;
				tax = 47 * multiplier;			
				break;
			
			case "Citroen":
				multiplier = 23;
				tax = 5 * multiplier;			
				break;			
		}		
	}
	
	static void Ex2()
	{
		string answer = Console.ReadLine();
		
		int tax = 0;
		int multiplier = 0;
		
		switch (answer)
		{
			case "Kia":
				multiplier = 5;
				tax = 30 * multiplier;
				
				int gdp = 45000; //This data comes from a database 
				string rulingParty = "Ruling Party"; //This data comes from a database
				
				if (gdp >= 10000 && rulingParty == "SocialistParty")
					tax += 50;
				break;
			
			case "Peugeot":
				multiplier = 6;
				tax = 47 * multiplier;	

				int numberOfTerrorAttacks = 50; //from database
				
				if (numberOfTerrorAttacks > 30)
					tax += 10;
				break;
			
			case "Citroen":
				multiplier = 23;
				tax = 5 * multiplier;			
				break;			
		}			
	}
	
	static void Ex3()
	{
		string answer = Console.ReadLine();
		
		int tax = 0;
		
		switch (answer)
		{
			case "Kia":
				int gdp = 45000; //This data comes from a database 
				string rulingParty = "Ruling Party"; //This data comes from a database
				
				if (gdp >= 10000 && rulingParty == "SocialistParty")
					tax += 50;
				break;
			
			case "Peugeot":
				int numberOfTerrorAttacks = 50; //from database
				
				if (numberOfTerrorAttacks > 30)
					tax += 10;
				break;
			
			case "Citroen":
				tax = 4000;
				break;			
		}			
	}
}

// Exercise 3

//Indicate the bad practice and repair the code

using System;

class MainClass
{
	static void Main()
	{
		Car[] cars = {new Kia(), new Peugeot(), new Hyundai(), new Citroen(), new Renault()};
		
		foreach (Car car in cars)
		{			
			int addedTax = 20;
			
			addedTax += car.TaxForAllCars();
			addedTax += car.TaxForConcreteCar();
			
			Console.WriteLine(addedTax);
		}

		Console.ReadLine();
	}
}

interface Car
{
	int TaxForAllCars();
	int TaxForConcreteCar();
}

class Kia : Car
{
	public int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Same logic");
		return 20;
	}
	
	public int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Kia. Different logic");
		return 10;
	}
}

class Hyundai : Car
{
	public int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Same logic");
		return 20;
	}
	
	public int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Hyundai. Different logic");
		return 9;
	}
}

class Peugeot : Car
{
	public int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Same logic");
		return 20;
	}
	
	public int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Peugeot. Different logic");
		return 15;
	}
}

class Citroen : Car
{
	public int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Same logic. But two more logical steps at the end.");
		return 19;
	}
	
	public int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Citroen. Different logic");
		return 15;
	}
}

class Renault : Car
{
	public int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Completely different logic");
		return 4;
	}
	
	public int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Renault. Different logic");
		return 15;
	}
}

// Exercise 4

//Tell if the methods and variables marked by XXX:
// 	1) must 
//  2) can
//  3) must not
//have the keyword static


// Explain your answer

using System;
using System.Collections.Generic;

class MainClass
{
	XXX void Main()
	{
		XXX List<DB> list = new List<DB>();
		
		for (int i=0;i<5;i++)
		{
			XXX string answer = Console.ReadLine();
			
			XXX DB db = new DB();
			db.iteration = i;
			db.answer = answer;
			
			list.Add(db);
			
			XXX Car car = new GetCar().Run(answer);
			
			car.Run();
		}
	}
}

class GetCar
{
	public XXX Car Run(string answer)
	{
		switch (answer)
		{
			case "Suzuki":
				return new Suzuki();	
			case "asia":
				return new BMW();
			default:
				return null;
		}		
	}
}

class DB
{
	public XXX int iteration;
	public XXX string answer;
}

interface Car
{
	XXX void Run();
}

class Suzuki : Car
{
	public XXX void Run()
	{
		Console.WriteLine("Suzuki");
	}
}

class BMW : Car
{
	public XXX void Run()
	{
		Console.WriteLine("BMW");
	}
}

// Exercise 5

// is the choice of static and non-static class members adequate? please explain

using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		
	}
}

namespace Ex1
{
	class App
	{
		public static void Run()
		{
			bool[] choices = {true, true, false, false, true}; // from external source
			
			foreach (bool choice in choices)
				switch (choice)
				{
					case true:
						One one = new One();
						one.Run();
						break;
					case false:
						Two two = new Two();
						two.Run();
						break;
				}
		}
	}
	
	class One
	{
		public void Run()
		{
			
		}
	}
	
	class Two
	{
		public void Run()
		{
			
		}
	}
}

namespace Ex2
{
	class App
	{
		public static void Run()
		{
			bool[] choices = {true, true, false, false, true}; // from external source
			
			foreach (bool choice in choices)
			{
				Number number = Factory(choice);
				number.Run();
			}

		}
		
		static Number Factory(bool choice)
		{
			switch (choice)
			{
				case true:
					return new One();
				default:
					return new Two();
			}			
		}
	}
	
	interface Number
	{
		void Run();
	}
	
	class One : Number
	{
		public void Run()
		{
			
		}
	}
	
	class Two : Number
	{
		public void Run()
		{
			
		}
	}
}

namespace Ex3
{
	class App
	{
		public static void Run()
		{
			bool[] choices = {true, true, false, false, true}; // from external source
			
			List<DB> list = new List<DB>();
			
			foreach (bool choice in choices)
			{
				DB db = new DB();
				
				switch (choice)
				{
					case true:
						db.age = 30;
						db.name = "AAA";
						break;
					case false:
						db.age = 25;
						db.name = "BBB";
						break;
				}
				
				list.Add(db);
			}
		}
	}
	
	class DB
	{
		public int age;
		public string name;
	}
}