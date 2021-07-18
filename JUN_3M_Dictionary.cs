/* Questions
	True or false?
		a) as a general rule: whenever the task is to group data, we use a dictionary
		b) every element of a dictionary can be accessed by its numeric index
*/


// Exercise 1

	// Count how often every element of a given array appears

	// Example: string[] countries = {"Poland", "Germany", "Germany", "Austria", "Poland"};

	// Correct solution: Poland 2, Germany 2, Austria 1
	
	
// Exercise 2

	// You are given a list of all employees in LGBS. Every line contains two information, Employee Name and Tower.
	// Write a program that lists all employees per Tower

	// Example: Michal OTC, Paweł OTC, Paulina HRS, Marek RTR, Sandra RTR

	// Expected Result: OTC: Michał, Paweł; RTR: Marek, Sandra; HRS: Paulina
	
	
// Exercise 3

	// You are given a list of all employees in LGBS. Every line contains three information, Employee Name, Team and Tower.
	// Write a program that lists all employees per Team and Tower

	// Example: Michal OC1 OTC, Paweł OC2 OTC, Paulina H1 HRS, Marek R1 RTR, Sandra R2 RTR, Grzesiek OC1 OTC, Filip OC2 OTC

	// Expected Result: 
		// OTC: 
			// OC1 
				// Michał, Grzesiek
			// OC2
				// Paweł, Filip
		// RTR:
			// R1
				// Marek
			// R2
				// Sandra
		// HRS
			// H1
				// Paulina
				
				
// Exercise 4

//Will a runtime-error appear? If yes, tell in which function/s and provide a more robust code

using System.Collections.Generic;

class MainClass
{
	static void Main
	{
		Ex1();
		Ex2();
	}
	
	void Ex1()
	{
		Dictionary<string, int> groups = new Dictionary<string, int>();
		
		string[] countries = {"Polska", "Niemcy", "Austria", "Szwarcarja", "Polska", "Polska"};
		
		foreach (string country in countries)
			groups.Add(country, 1);		
	}

	void Ex2()
	{
		Dictionary<string, int> groups = new Dictionary<string, int>();
		
		string[] countries = {"Polska", "Niemcy", "Austria", "Szwarcarja", "Nigeria", "Uganda"};
		
		foreach (string country in countries)
			groups.Add(country, 1);		
	}
}