/* Questions
	True or false? Johann says:
		a) a more general class can have access to the methods and the variables of a concrete class
		b) a more concrete class can call a method of a more general class
		c) a more general class can create an instance of a more concrete class and (in case of objects) call its method, but it must not have access to the variables
*/

// Exercise 1

// indicate the bad practice and provide a better solution

class MainClass
{
	static void Main()
	{
		MainStep1 mainStep1 = new MainStep1();
		mainStep1.Run();
	}
	
	class MainStep1
	{
		public int myInt;
		
		public void Run()
		{
			new SubStep1().Run(this);
			new SubStep2().Run();
		}
	}
	
	class SubStep1
	{
		public void Run(MainStep1 mainStep1)
		{
			mainStep1.myInt = 30;
		}
	}
	
	class SubStep2
	{
		public void Run()
		{
			//...
		}
	}
}

// Exercise 2

// Show the bad practice/s and repair the code
// Plus: there is also one technical error, find it. Is there maybe a bad practice that incrases the possibility of such errors?

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		Dictionary<string, DB> kia = new Dictionary<string, DB>();
		
		for (int i=0; i<3; i++)
		{
			FactorySeoul factorySeoul = new FactorySeoul();
			
			DB db = new DB();
			
			factorySeoul.Calculate(i);
			
			if (factorySeoul.productionCost > 30000 && factorySeoul.productionTime > 200)
				factorySeoul.economical = false;
			else
				factorySeoul.economical = true;
			
			db.cost = factorySeoul.productionCost;
			db.time = factorySeoul.productionTime;
			db.economical = factorySeoul.economical;
			
			kia.Add("Factory Seoul", db);
		}	
		
		DB db1 = new DB();
		db1.cost = 30;
		db1.time = 50;
		db1.economical = true;
		
		kia.Add("Headquarters", db1);
		
		db1.cost = 20;
		db1.time = 80;
		db1.economical = false;
		
		kia.Add("Factory India", db1);
	}
	
	class DB
	{
		public int cost;
		public int time;
		public bool economical;
	}
		
	class FactorySeoul
	{
		public int productionCost;
		public int productionTime;
		public bool economical;
		
		public void Calculate(int i)
		{
			productionCost = i * 20000 + 500;
			productionTime = i * 20 + 150;
		}
	}
}

// Exercise 3
// Show the bad practices and provide a better code

class MainClass
{
	static void Main()
	{
		Kia kia = new Kia();
		Automobile automobile = kia.Run();
	}
}

class Automobile
{
	public int totalProductionCost;
}

class PeugeotTotal
{
	public int Cost()
	{
		return 5000;
	}	
}

class Kia
{
	public Automobile Run()
	{
		int kiaCost = Cost();
		int peugeotCost = new PeugeotTotal().Cost();
		peugeotCost += new PeugeotEngine().Cost();
	
		Automobile automobile = new Automobile();
		automobile.totalProductionCost = kiaCost + peugeotCost;
		
		return automobile;
	}
	
	public int Cost()
	{
		return new KiaDoor().Cost();
	}
}

class KiaDoor
{
	public int Cost()
	{
		return 2000;
	}	
}

class PeugeotEngine
{
	public int Cost()
	{
		return 10000;
	}	
}