using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		Operations.Operations operations = new Operations.Operations();
		
		double sum 			= operations.Addition(5, 4);
		double difference 	= operations.Subtraction(5, 4);
		double product		= operations.Multiplication(5, 4);
		double quotient		= operations.Division(5, 4);
		
		//This is quasi encapsulation. Avoid.
		List<double> result = operations.GetResults();
		result.Add(1.38);
	}
}



namespace Operations
{		
	public class Operations
	{
		private List<double> results = new List<double>();
				
		private Addition			addition 		= new Addition();
		private Subtraction 		subtraction 	= new Subtraction();
		private Multiplication	multiplication 	= new Multiplication();
		private Division 		division 		= new Division();				
		
		public double Addition(int a, int b)
		{
			return addition.Run(results, a, b);
		}
		
		public double Subtraction(int a, int b)
		{
			return subtraction.Run(results, a, b);
		}
		
		public double Multiplication(int a, int b)
		{
			return multiplication.Run(results, a, b);
		}
		
		public double Division(int a, int b)
		{
			return division.Run(results, a, b);
		}
		
		//This is quasi encapsulation. Avoid it!
		public List<double> GetResults()
		{
			return results;
		}
		
		// Hard to say, if this is still quasi encapsulation.
		// Rather yes.
		public double GetResultFromIndex(int i)
		{
			if (i >= 0 && i < results.Length) 
				return results[i];
			else return 0.00;
		}
		
		//Still allowed, ideal to group
		public void DoPlusMinus(int a, int b)
		{
			addition.Run(results, a, b);
			subtraction.Run(results, a, b);
		}
	}
}

namespace Operations
{	
	public class Addition
	{
		public double Run(List<double> results, int a, int b)
		{
			results.Add(a + b);
			return a + b;
		}
	}

	public class Subtraction
	{
		public double Run(List<double> results, int a, int b)
		{
			results.Add(a - b);
			return a - b;
		}
	}

	public class Multiplication
	{
		public double Run(List<double> results, int a, int b)
		{
			results.Add(a * b);
			return a * b;
		}
	}
		
	public class Division
	{
		public double Run(List<double> results, int a, int b)
		{
			results.Add(a / b);
			return a / b;
		}
	}	
}