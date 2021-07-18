class MainClass
{
	static void Main(string[] args)
	{
		Factory factory = Creator.Run(args[0]);
		
		factory.step1.Run();
		factory.step2.Run();
	}
}

class Creator
{
	public static Factory Run(string mode)
	{
		switch (mode)
		{
			case "DEV":
				return new Factory_Test();
			case "PROD":
				return new Factory_Prod();
			default:
				return new Factory_Test();
			
		}
	}
}

interface Factory
{
	Step1 step1 {get; set;}
	Step2 step2 {get; set;}
}

class Factory_Prod : Factory
{
	public Step1 step1 {get; set;}
	public Step2 step2 {get; set;}
	
	public Factory_Prod()
	{
		step1 = new Step1Prod();
		step2 = new Step2Prod();		
	}
}

class Factory_Test : Factory
{
	public Step1 step1 {get; set;}
	public Step2 step2 {get; set;}
	
	public Factory_Test()
	{
		step1 = new Step1Testing();
		step2 = new Step2Testing();		
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

interface Step2
{
	void Run();
}


// Production Family
class Step1Prod : Step1
{
	public void Run()
	{
		// do the whole thing
	}
}

class Step2Prod : Step2
{
	public void Run()
	{
		// do the whole thing
	}
}

//Testing family

class Step1Testing : Step1
{
	public void Run()
	{
		// do only a small part
	}
}

class Step2Testing : Step2
{
	public void Run()
	{
		// do only a small part
	}
}
