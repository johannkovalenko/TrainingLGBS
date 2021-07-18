//Indicate the bad practice and repair the code

using System;

class MainClass
{
	static void Main()
	{
		Car[] cars = {new Kia(), new Peugeot(), new Hyundai(), new Citroen(), new Renault()};
		
		foreach (Car car in cars)
		{						
			int addedTax = car.TaxForAllCars();
			addedTax += car.TaxForConcreteCar();
			
			Console.WriteLine(addedTax);
		}

		Console.ReadLine();
	}
}

abstract class Car
{
	public virtual int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Same logic");
		return 20 + 20;
	}
	
	public abstract int TaxForConcreteCar();
}

class Kia : Car
{
	public override int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Kia. Different logic");
		return 10;
	}
}

class Hyundai : Car
{	
	public override int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Hyundai. Different logic");
		return 9;
	}
}

class Peugeot : Car
{
	public override int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Peugeot. Different logic");
		return 15;
	}
}

class Citroen : Car
{
	public override int TaxForAllCars()
	{
		int tax = base.TaxForAllCars();
		Console.WriteLine("But two more logical steps at the end.");
		return tax + 19;
	}
	
	public override int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Citroen. Different logic");
		return 15;
	}
}

class Renault : Car
{
	public override int TaxForAllCars()
	{
		Console.WriteLine("Common for all cars. Completely different logic");
		return 4;
	}
	
	public override int TaxForConcreteCar()
	{
		Console.WriteLine("Tax for Renault. Different logic");
		return 15;
	}
}