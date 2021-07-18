// Polymorphism for testing purposes (launch time based, Factory). 
//(Polymorphism for runtime Strategy will be presented in next training)


// methods do not comply with the Open Closed principle
// Count how many changes we have to make when we want to replace Step1 by Step1Testing -> Too many
// Polymorphism solves this problem

class MainClass
{
	static void Main()
	{
		Step1 step1 = new Step1();
		
		step1.Run();
		
		OtherClass otherClass = new OtherClass(step1);
		otherClass.Run();
	}
}

class OtherClass
{
	public void Run(Step1 step1)
	{
		step1.Run();
	}
}

class Step1
{
	public void Run()
	{
		// do the whole thing
	}
}

class Step1Testing
{
	public void Run()
	{
		// do only a small part
	}
}


// Introducing polymorphism
// Count the number of changes now
// Still one problem: the very high main-method is still object to change.

class MainClass
{
	static void Main()
	{
		Step1 step1 = new Step1Prod();
		//Step1 step1 = new Step1Testing();
		
		step1.Run();
		
		OtherClass otherClass = new OtherClass(step1);
		otherClass.Run();
	}
}

class OtherClass
{
	public void Run(Step1 step1)
	{
		step1.Run();
	}
}

interface Step1
{
	void Run();
}

class Step1Prod : Step1
{
	public void Run()
	{
		// do the whole thing
	}
}

class Step1Testing : Step1
{
	public void Run()
	{
		// do only a small part
	}
}

// Introducing Factory Method. 
// Now the creation of the instance is delegated to a class which is lower in the hierarchy
// The high level main-method will not be subject to changes anymore -> That's what we wanted to achieve

class MainClass
{
	static void Main(string[] args)
	{
		Step1 step1 = new Step1Creator().Run(args[]);
		
		step1.Run();
		
		OtherClass otherClass = new OtherClass(step1);
		otherClass.Run();
	}
}

class Step1Creator
{
	public Step1 Run(string mode)
	{
		switch (mode)
		{
			case "DEV":
				return new Step1Testing();
			case "PROD":
				return new Step1Prod();
			case "UAT":
				return new Step1UAT();
			default:
				return new Step1Testing();
			
		}
	}
}

class OtherClass
{
	public void Run(Step1 step1)
	{
		step1.Run();
	}
}

interface Step1
{
	void Run();
}

class Step1Prod : Step1
{
	public void Run()
	{
		// do the whole thing
	}
}

class Step1Testing : Step1
{
	public void Run()
	{
		// do only a small part
	}
}

class Step1UAT : Step1
{
	public void Run()
	{
		// do something else
	}
}