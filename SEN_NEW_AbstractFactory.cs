// Questions:

	// 1) What is the difference between an Abstract Factory and a Factory Method
	// 2) Describe the essence of the Abstract Factory
	// 3) Does the Abstract Factory help us with Unit and/or Integration test? If yes, explain why.
	// 3) Does the Abstract Factory help us with Unit and/or Integration test? If yes, explain why.



// Exercises:

// This is already a very nice factory. Although, there is one bad practice.
// Show the bad practice and provide a better code
// Does "Main()" comply with the Open-Closed principle?
// Does "BuildFactory.Run()" comply with the Open-Closed principle?

// Solution below

using System;

class MainClass
{
	static void Main()
	{
		string answer = Console.ReadLine();
		
		Factory factory = new BuildFactory().Run(answer);
		
		factory.car.Run();
		factory.motocycle.Run();
		
		Console.ReadLine();
	}
}

class BuildFactory
{
	public Factory Run(string answer)
	{
		switch (answer)
		{
			case "europe":
				return new FactoryEurope();	
			case "asia":
				return new FactoryAsia();
			default:
				return null;
		}		
	}
}

interface Factory
{
	Car 		car 		{get; set;}
	Motocycle 	motocycle 	{get; set;}
}

class FactoryEurope : Factory
{
	public Car 			car 		{get; set;}
	public Motocycle 	motocycle 	{get; set;}
	
	public FactoryEurope()
	{
		car 		= new CarBMW();
		motocycle	= new MotocycleBMW();		
	}
}

class FactoryAsia : Factory
{
	public Car 			car 		{get; set;}
	public Motocycle 	motocycle 	{get; set;}

	public FactoryAsia()
	{
		car 		= new CarSuzuki();
		motocycle	= new MotocycleSuzuki();		
	}
}

interface Car
{
	void Run();
}

interface Motocycle
{
	void Run();
}

class CarSuzuki : Car
{
	public void Run()
	{
		Console.WriteLine("Suzuki Escudo Pikes Peak");
	}
}

class CarBMW : Car
{
	public void Run()
	{
		Console.WriteLine("BMW 750i");
	}
}

class MotocycleSuzuki : Motocycle
{
	public void Run()
	{
		Console.WriteLine("Suzuki Hayabusa");
	}
}

class MotocycleBMW : Motocycle
{
	public void Run()
	{
		Console.WriteLine("BMW RS1200");
	}
}


// Solution

using System;

class MainClass
{
	static void Main()
	{
		string answer = Console.ReadLine();
		
		Factory factory = new BuildFactory().Run(answer);
		
		factory.car.Run();
		factory.motocycle.Run();
		
		Console.ReadLine();
	}
}

class BuildFactory
{
	public Factory Run(string answer)
	{
		switch (answer)
		{
			case "europe":
				return new Factories.Europe();	
			case "asia":
				return new Factories.Asia();
			default:
				return null;
		}		
	}
}

interface Factory
{
	Car 		car 		{get; set;}
	Motocycle 	motocycle 	{get; set;}
}

interface Car
{
	void Run();
}

interface Motocycle
{
	void Run();
}

namespace Factories
{
	class Europe : Factory
	{
		public Car			car 		{get; set;}
		public Motocycle 	motocycle 	{get; set;}
		
		public Europe()
		{
			car 		= new Cars.BMW();
			motocycle	= new Motocycles.BMW();		
		}
	}

	class Asia : Factory
	{
		public Car			car 		{get; set;}
		public Motocycle 	motocycle 	{get; set;}

		public Asia()
		{
			car 		= new Cars.Suzuki();
			motocycle	= new Motocycles.Suzuki();		
		}
	}
}



namespace Cars
{
	class Suzuki : Car
	{
		public void Run()
		{
			Console.WriteLine("Suzuki Escudo Pikes Peak");
		}
	}

	class BMW : Car
	{
		public void Run()
		{
			Console.WriteLine("BMW 750i");
		}
	}
}

namespace Motocycles
{	
	class Suzuki : Motocycle
	{
		public void Run()
		{
			Console.WriteLine("Suzuki Hayabusa");
		}
	}

	class BMW : Motocycle
	{
		public void Run()
		{
			Console.WriteLine("BMW RS1200");
		}
	}
}