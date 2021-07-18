//Solutions at the bottom


using System;
using System.IO;

class App
{
	static void Main()
	{
		new Exercise_5().Main();
		Console.ReadLine();
	}
}

class Exercise_1
{
	// Is the use of "string" justified?
	
	public void Main()
	{
		var project = new Project();
		
		SetProject(project);
		DoSomething(project);
		DoSomethingElse(project);
	}
	
	void SetProject(Project project)
	{
		project.status = Console.ReadLine();
	}
	
	void DoSomething(Project project)
	{
		if (project.status == "Active")
		{
			// do something
		}
	}

	void DoSomethingElse(Project project)
	{
		if (project.status == "Closed")
		{
			// do something
		}
	}
	
	class Project
	{
		public string status;
	}
}

class Exercise_2 
{
	// is the use of string justified?
	
	public void Main()
	{
		string rawText = File.ReadAllText("source.txt");
		
		if (rawText.Contains("abc"))
		{
			// do something
		}
	}
}

class Exercise_3
{
	// Is Exercise_3 a better approach than Exercise_1?
	
	enum Status {Active, Closed, OnHold, Undefined}
	
	public void Main()
	{
		var project = new Project();
		
		SetProject(project);
		DoSomething(project);
		DoSomethingElse(project);
	}
	
	void SetProject(Project project)
	{
		string rawStatus = Console.ReadLine();
		
		switch (rawStatus)
		{
			case "Active":
				project.status = Status.Active;
				break;
			case "Closed":
				project.status = Status.Closed;
				break;	
			case "OnHold":
				project.status = Status.OnHold;
				break;
		}
	}
	
	void DoSomething(Project project)
	{
		if (project.status == Status.Active)
		{
			// do something
		}
	}

	void DoSomethingElse(Project project)
	{
		if (project.status == Status.Closed)
		{
			// do something
		}
	}
	
	class Project
	{
		public Status status = Status.Undefined;
	}
}

class Exercise_4
{
	// Will this compile?
	// If yes, what will be the result?
	// Is this good practice?
	
	enum Status {Active, Closed, OnHold}
	
	public void Main()
	{
		Status status = Status.Active;
		
		switch ((int)status)
		{
			case 0:
				Console.WriteLine("Active");
				break;
			case 1:
				Console.WriteLine("Closed");
				break;
			default:
				Console.WriteLine("Default");
				break;
		}
	}
}

class Exercise_5
{
	// Will this compile?
	// If yes, what will be the result?
	// Is this good practice?
	
	enum Status {Active = 1, Closed = 4, OnHold = 6}
	
	public void Main()
	{
		Status status = Status.Active;
		
		switch ((int)status)
		{
			case 0:
				Console.WriteLine("Active");
				break;
			case 1:
				Console.WriteLine("Closed");
				break;
			default:
				Console.WriteLine("Default");
				break;
		}
	}
}

class Exercise_6
{
	// Will this compile?
	// Is this good practice?
	
	int numberOfMonths = Enum.GetNames(typeof(Months)).Length;	
	enum Months 
	{
		Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
	}
	
	public void Main()
	{
		Months months = (Months)int.Parse(Console.ReadLine());
		
		while (true)
		{
			Console.ReadLine();
			
			if ((int)months < 11)
				months++;
			else months = (Months)0;
		}
	}
}

/*
	Exercise_1: no
		hard-coded string values (as well as of all other primitive types) are not safe, this means that the compilator does not check the values of the string during compilation, which means that typos in the string are not captured.
		
		Any change of the string is burdensome and unsafe: imagine that the status changes from "Active" to "Activated". You would have to change every function in the code where you check 'if(project.status == "Active")'. There is a high risk, that you will accidentially forget to change one method. -> Your program will be corrupted.
		Furthermore, this is a breach of the open-closed principle, which states, that we should not touch tested and stable methods. Here we have do change DoSomething()
		
		General rule: avoid strings whenever possible and replace them with enumerations. Very often, this is not possible, but in this case it is. We have a very limited number of states that the string can have. "Active", "Closed", "Onhold". And we check a concrete value. Exercise_3 shows the correct solution.
 
	
	Exercise_2: yes
		Here a enumeration isn't an option, because there is an almost infinite number of possible values that the string can have. Furthermore, we aren't checking a concrete value, only if the string contains the fragment "abc"
		
	Exercise_3: yes
		Whenever possible, prefer an enumeration over a hardcoded string or other primitive type.
		
		The enumeration solves the problem with potential typos insofar, that there is only ONE place where we check the value of a string, namely in the "switch" block.
		
		When the status changes from "Active" to "Activated", we do not breach the open-closed-principle for DoSomething(), the ONLY change of code takes places in SetProject().
		
		We do not run the risk anymore to accidentally miss a method.
		
	Exercise_4: yes, Active, no
		enumeration are integer based. The first label in the enumeration gets the value 0.
		It is bad practice to use the integer value instead of your defined label name, because "Active" is more comprehensible than "0"
		
	Exercise_5: yes, Default, no
		you can actively set the integer values for your labels. But this is still bad practice. (see Exercise_4). 
		
	Exercise_6: yes, no
		Whenever you feel tempted to loop over a enumeration or to increment it, this means that a enumeration is not the right choice. Enumeration are NOT dynamic, they are a fixed concept. 
		Changes of the value of an enumeration have to be hard-coded. Do not try to dynamically change enumeration values.
*/
