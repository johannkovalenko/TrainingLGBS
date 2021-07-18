class MainClass
{
	static void Main(string[] args)
	{
		Factory factory = Creator.Run(args[0]);
		
		factory.step1.Run();
		factory.step2.Run();
	}
}

//Robert Martin (Uncle Bob) - Clean Code Czysty Kod

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

abstract class Factory
{
	public Step1 step1;
	public Step2 step2;
}

class Factory_Prod : Factory
{
	public Factory_Prod()
	{
		step1 = new Step1Prod();
		step2 = new Step2Prod();		
	}
}

class Factory_Test : Factory
{
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
