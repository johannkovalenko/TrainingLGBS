// Print all numbers of "initialList" which are larger than 4

//Condition1: the initial list has to remain unchanged
	//Why?	we will need the initial list in a later step
	
//Condition2: no IF's in parent function
	//Why?  abstraction = hide details = better code readability
	
//Condition3: the print and further actions for each number have to be done in the parent function
	//Why?	the further steps are still very abstract and need to be in the parent function
	
//Condition4: do not create a temporary list
	//Why?	performance reasons

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		new Approach1().Run();			// breach of condition 2
		new Approach2().Run();			// breach of condition 2
		new Approach3().Run();			// breach of condition 4
		new Approach4().Run();			// breach of condition 3
		new Approach5().Run();			// breach of condition 1
		
		new YieldApproach().Run();		// Solution
		
		Console.ReadLine();
	}	

}

class Approach1
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		
		foreach (int number in initialList)
			if (number > 4)
				Console.WriteLine("1   " + number);	
	}
}

class Approach2
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		
		foreach (int number in initialList)
			if (Check(number))
				Console.WriteLine("2   " + number);	
	}
	
	bool Check(int number)
	{
		return number > 4;
	}
}

class Approach3
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		List<int> temporaryList = GetFilteredList(initialList);
		
		foreach (int number in temporaryList)
			Console.WriteLine("3   " + number);
	}

	List<int> GetFilteredList(List<int> initialList)
	{
		List<int> temporaryList = new List<int>();
		
		foreach (int number in initialList)
			if (number > 4)
				temporaryList.Add(number);
			
		return temporaryList;
	}
}

class Approach4
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		
		foreach (int number in initialList)
			CheckAndFurtherActions(number);	
	}
	
	void CheckAndFurtherActions(int number)
	{
		if (number > 4)
			Console.WriteLine("4   " + number);
	}
}

class Approach5
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		
		FilterList(initialList);
		
		
		foreach (int number in initialList)
			Console.WriteLine("5   " + number);	
	}
	
	void FilterList(List<int> initialList)
	{
		for (int i=0;i<initialList.Count;i++)
			if (initialList[i] <= 4)
			{
				initialList.RemoveAt(i);
				--i;
			}
	}
}

class YieldApproach
{
	public void Run()
	{
		List<int> initialList = new List<int> {3, 7, 9, 1, 2, 4, 5};
		
		foreach (int number in Check(initialList))
			Console.WriteLine("1   " + number);	
	}
	
	IEnumerable<int> Check(List<int> initialList)
	{
		foreach (int number in initialList)
			if (number > 4)
				yield return number;
	}
}