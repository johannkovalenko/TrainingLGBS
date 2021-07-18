



class MainClass_Bad
{
	// Problem: the three methods are granted access to data, that is none of their business.
	// The Employee method should not have the possibility to change the country data.
	// This is a breach of the principle of encapsulation
	// Solution: create separate data containers (see class MainClass_Improvement1)
	
	
	static void Main()
	{
		DB db = new DB();
		
		FillEmployeeData(db);
		FillCountryData(db);
		FillWeatherData(db);
		PrintEmployeeData(db);
		
	}
	
	static void FillEmployeeData(DB db)
	{
		// ...
	}
	
	static void FillCountryData(DB db)
	{
		// ...
	}
	
	static void FillWeatherData(DB db)
	{
		// ...
	}
	
	static void PrintEmployeeData(DB db)
	{
		// ...
	}

	class DB
	{
		public string name;
		public string surname;
		public double salary;
		public string countryName;
		public string capital;
		public string weatherTomorrow;
	}
}


class MainClass_Improvement1
{
	// One encapsulation problem is resolved
	// But we can still increase encapsulation. 
	//		There is no need that Main() has access to the Country and Weather instance as the data is only used inside the methods.
	// Solution: move the data container inside the methods (See MainClass_Improvement2)

	static void Main()
	{
		Employee employee = new Employee();
		Country country = new Country();
		Weather weather = new Weather();
		
		FillEmployeeData(employee);
		FillCountryData(country);
		FillWeatherData(weather);
		PrintEmployeeData(employee);	
	}
	
	static void FillEmployeeData(Employee employee)
	{
		// ...
	}
	
	static void FillCountryData(Country country)
	{
		// ...
	}
	
	static void FillWeatherData(Weather weather)
	{
		// ...
	}
	
	static void PrintEmployeeData(Employee employee)
	{
		// ...
	}

	class Employee
	{
		public string name;
		public string surname;
		public double salary;
	}
	
	class Country
	{
		public string countryName;
		public string capital;
	}
	
	class Weather
	{
		public string weatherTomorrow;
	}
}

class MainClass_Improvement2
{
	// Now Main does not have access to the instances of weather and employee
	// We can further increase encapsulation by disallow MainClass to create an instance of weather and employee
	// (see MainClass_Improvement3)
	static void Main()
	{
		Employee employee = new Employee();
		
		FillEmployeeData(employee);
		FillCountryData();
		FillWeatherData();
		PrintEmployeeData(employee);	
	}
	
	static void FillEmployeeData(Employee employee)
	{
		// ...
	}
	
	static void FillCountryData()
	{
		Country country = new Country();
		// ...
	}
	
	static void FillWeatherData()
	{
		Weather weather = new Weather();
		// ...
	}
	
	static void PrintEmployeeData(Employee employee)
	{
		// ...
	}

	class Employee
	{
		public string name;
		public string surname;
		public double salary;
	}
	
	class Country
	{
		public string countryName;
		public string capital;
	}
	
	class Weather
	{
		public string weatherTomorrow;
	}
}

class MainClass_Improvement3
{
	//Weather and Country are now nicely encapsulated.
	// Remains the issue with the employee. 
	// 	On the one hand it is legitimate to have the data structure,
	// 	because we want to achieve segregation of concerns.
	//  on the other hand Main has become a high level method that should not have access to any data anymore
	// 	Solution: move to subclass (MainClass_Improvement4a and MainClass_Improvement4b)
	static void Main()
	{
		Employee employee = new Employee();
		
		FillEmployeeData(employee);
		
		new Country().Fill();
		new Weather().Fill();
		
		PrintEmployeeData(employee);	
	}
	
	static void FillEmployeeData(Employee employee)
	{
		// ...
	}
	
	static void PrintEmployeeData(Employee employee)
	{
		// ...
	}

	class Employee
	{
		public string name;
		public string surname;
		public double salary;
	}
	
	class Country
	{
		string countryName;
		string capital;
		
		public void Fill()
		{
			//...
		}
	}
	
	class Weather
	{
		string weatherTomorrow;
		
		public void Fill()
		{
			
		}
	}
}

class MainClass_Improvement4a
{	
	// Data structures disappeared. OK when class Employee doesn't have to be segregated anymore.
	// If class Employee turns out to grow too much, this solution is not ideal. -> MainClass_Improvement4b
	static void Main()
	{
		Employee employee = new Employee();
		
		employee.Fill();
		employee.Print();
		
		new Country().Fill();
		new Weather().Fill();	
	}
	
	class Employee
	{
		string name;
		string surname;
		double salary;
		
		public void Fill()
		{
			// ...
		}
		
		public void Print()
		{
			
		}
	}
	
	class Country
	{
		string countryName;
		string capital;
		
		public void Fill()
		{
			//...
		}
	}
	
	class Weather
	{
		string weatherTomorrow;
		
		public void Fill()
		{
			
		}
	}
}

class MainClass_Improvement4b
{
	static void Main()
	{
		new Employee().Run();
		new Country().Fill();
		new Weather().Fill();
	}

	partial class Employee
	{
		public void Run()
		{
			DB db = new DB();
			
			new Fill().Run(db);
			new Print().Run(db);
		}
		class DB
		{
			public string name;
			public string surname;
			public double salary;			
		}
		
		class Fill
		{
			public void Run(DB db)
			{
				// ...
			}
		}
		
		class Print
		{
			public void Run(DB db)
			{
				// ...
			}
		}
	}
	
	class Country
	{
		string countryName;
		string capital;
		
		public void Fill()
		{
			//...
		}
	}
	
	class Weather
	{
		string weatherTomorrow;
		
		public void Fill()
		{
			
		}
	}
}