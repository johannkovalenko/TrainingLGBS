// Exercise 1

// Please indicate which SOLID principle/s is/are breached in below code
// Indicate how to provide a better solution

// Solution below

using System;
using System.Collections.Generic;
using System.Diagnostics;

class MainClass
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		int iterations = 50000000;
		
		Typy[] typy = {new Lista(), new Tablica()};
		
		foreach (Typy typ in typy)
		{
			List<int> myList = new List<int>();
			int[] myArr	= new int[iterations];
			
			stopwatch.Reset();
			stopwatch.Start();
		
			typ.Add	(iterations, myList, myArr);
			typ.Read(myList, myArr);
			typ.Write(myList, myArr);
		
			stopwatch.Stop();
			Console.WriteLine(stopwatch.Elapsed.Milliseconds);
		}
		Console.ReadLine();
	}
}

interface Typy
{
	void Add	(int iterations, List<int> myList, int[] myArr);
	void Read	(List<int> myList, int[] myArr);
	void Write	(List<int> myList, int[] myArr);
}

class Lista : Typy
{
	public void Add(int iterations, List<int> myList, int[] myArr)
	{
		for (int i=0;i<iterations; i++)
			myList.Add(i);
	}

	public void Read(List<int> myList, int[] myArr)
	{
		int temp;
		int count = myList.Count;
		
		for (int i=0;i<count; i++)
			temp = myList[i];
	}

	public void Write(List<int> myList, int[] myArr)
	{
		int count = myList.Count;
		
		for (int i=0;i<count;i++)
			myList[i] = 1;
	}	
}

class Tablica : Typy
{
	public void Add(int iterations, List<int> myList, int[] myArr)
	{		
		for (int i=0;i<iterations; i++)
			myArr[i] = i;
	}

	public void Read(List<int> myList, int[] myArr)
	{	
		int temp;
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			temp = myArr[i];
	}

	public void Write(List<int> myList, int[] myArr)
	{
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			myArr[i] = 1;
	}	
}

// Solution Exercise 1

// Reduce interface -> make it less strict
// This implies unfortunately often more "IF" of parent function level -> breach of SOLID O


using System;
using System.Collections.Generic;
using System.Diagnostics;

class MainClass
{
	static void Main()
	{
		Stopwatch stopwatch = new Stopwatch();
		int iterations = 50000000;
		
		Typy[] typy = {new Lista(), new Tablica()};
		
		foreach (Typy typ in typy)
		{			
			stopwatch.Reset();
			stopwatch.Start();
		
			typ.Add	(iterations);
			typ.Read();
			typ.Write();
		
			stopwatch.Stop();
			Console.WriteLine(stopwatch.Elapsed.Milliseconds);
		}
		Console.ReadLine();
	}
}

interface Typy
{
	void Add(int iterations);
	void Read();
	void Write();
}

class Lista : Typy
{
	List<int> myList = new List<int>();
	
	public void Add(int iterations)
	{
		for (int i=0;i<iterations; i++)
			myList.Add(i);
	}

	public void Read()
	{
		int temp;
		int count = myList.Count;
		
		for (int i=0;i<count; i++)
			temp = myList[i];
	}

	public void Write()
	{
		int count = myList.Count;
		
		for (int i=0;i<count;i++)
			myList[i] = 1;
	}	
}

class Tablica : Typy
{
	int[] myArr;
	
	public void Add(int iterations)
	{		
		myArr = new int[iterations];
		
		for (int i=0;i<iterations; i++)
			myArr[i] = i;
	}

	public void Read()
	{	
		int temp;
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			temp = myArr[i];
	}

	public void Write()
	{
		int length = myArr.Length;
		
		for (int i=0;i<length; i++)
			myArr[i] = 1;
	}	
}





// Exercise 2

// Indicate the bad practice and how to improve the code

// Solution below


class MainClass
{
	static void Main()
	{
		Bird[] birds = GenerateBirds();
		
		foreach (Bird bird in birds)
		{
			bird.Walk();
			bird.Fly();
		}
	}
	
	Bird[] GenerateBirds()
	{
		return {new Wrobel(), new Szpak(), new Pingwin()};
	}	
}

interface Bird
{
	void Walk();
	void Fly();
}

class Wrobel : Bird
{
	public void Walk()
	{
		Console.WriteLine("Wrobel Walk");
	}
	public void Fly()
	{
		Console.WriteLine("Wrobel Flight");
	}
}

class Szpak : Bird
{
	public void Walk()
	{
		Console.WriteLine("Szpak Walk");
	}
	public void Fly()
	{
		Console.WriteLine("Szpak Flight");
	}
}

class Pingwin : Bird
{
	public void Walk()
	{
		Console.WriteLine("Pingwin Walk");
	}
	public void Fly()
	{
		Console.WriteLine("Oops. I cannot fly");
	}	
}

// Solution Exercise

using System;

class MainClass
{
	static void Main()
	{
		BirdFly[] birdsFly = {new Wrobel(), new Szpak()};
		
		foreach (BirdFly birdFly in birdsFly)
			birdFly.Fly();

		BirdWalk[] birdsWalk = {new Wrobel(), new Szpak(), new Pingwin()};
		
		foreach (BirdWalk birdWalk in birdsWalk)
			birdWalk.Walk();
	}
}

interface BirdFly
{
	void Fly();
}

interface BirdWalk
{
	void Walk();
}

class Wrobel : BirdFly,BirdWalk
{
	public void Walk()
	{
		Console.WriteLine("Wrobel Walk");
	}
	public void Fly()
	{
		Console.WriteLine("Wrobel Flight");
	}
}

class Szpak : BirdFly,BirdWalk
{
	public void Walk()
	{
		Console.WriteLine("Szpak Walk");
	}
	public void Fly()
	{
		Console.WriteLine("Szpak Flight");
	}
}

class Pingwin : BirdWalk
{
	public void Walk()
	{
		Console.WriteLine("Pingwin Walk");
	}
}



// Exercise 3

// Where does the below code breach the Open-Closed Principle? (Hint: think about future code extensions)
// Provide a modified code which does not breach the Open-Closed Principle

using System;

class MainClass
{
	static void Main()
	{
		while (true)
		{
			string answer = Console.ReadLine();
			int rating = 100;
			int revenue = 0;
			string continent = "";
			
			switch (answer)
			{
				case "Kia":
					Console.WriteLine("Kia");
					Kia kia = KiaRawData();
					
					if (kia.koreanSpecialTaxApplies && kia.primeMinisterOfKorea == "Sun")
						rating -= 10;
					
					revenue = kia.revenue;
					continent = kia.continent;
					
					break;
				
				case "Peugeot":
					Console.WriteLine("Peugeot");
					
					Peugeot peugeot = PeugeotReport2019();
					
					if (peugeot.terrorRiskScale > 3 || peugeot.numberOfIncidentsAtBasqueBorder > 50)
						rating -= 10;
					
					revenue = peugeot.revenue;
					continent = peugeot.continent;
					break;
			}
			
			if (revenue > 5000)
				rating += 2;
			
			if (continent == "Europe" || continent == "Asia")
				rating += 5;
		}
	}
	
	static Kia KiaRawData()
	{
		Kia kia = new Kia();
		kia.koreanSpecialTaxApplies = true;
		kia.primeMinisterOfKorea = "Gang";
		kia.continent = "Asia";
		kia.revenue = 50000;
		
		return kia;
	}
	
	static Peugeot PeugeotReport2019()
	{
		Peugeot peugeot = new Peugeot();
		peugeot.terrorRiskScale = 7;
		peugeot.numberOfIncidentsAtBasqueBorder = 43;
		peugeot.continent = "Europe";
		peugeot.revenue = 3000;
		
		return peugeot;
	}
	
	class Kia
	{
		public bool koreanSpecialTaxApplies;
		public string primeMinisterOfKorea;
		public string continent;
		public int revenue;
	}
	
	class Peugeot
	{
		public int terrorRiskScale;
		public int numberOfIncidentsAtBasqueBorder;
		public string continent;
		public int revenue;
	}
}