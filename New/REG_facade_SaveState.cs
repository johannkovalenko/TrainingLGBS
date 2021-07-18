//This approach is not ideal. We will improve it.
//An object should not have more than one public method. Single Responsibility principle

// class MainClass
// {
	// static void Main()
	// {
		// Calculator calculator = new Calculator();
		
		// double sum 			= calculator.Add(5, 4);
		// double difference 	= calculator.Subtract(5, 4);
		// double product		= calculator.Multiply(5, 4);
		// double quotient		= calculator.Divide(5, 4);
	// }
// }

// class Calculator
// {
	// public double Add(int a, int b)
	// {
		// return a + b;
	// }
	
	// public double Subtract(int a, int b)
	// {
		// return a - b;
	// }
	
	// public double Multiply(int a, int b)
	// {
		// return a * b;
	// }
	
	// public double Divide(int a, int b)
	// {
		// return a / b;
	// }
// }

//Interim solution.
//Not ideal, because we have lost structure on the mainclass level. The classes are not grouped into a family anymore.

// class MainClass
// {
	// static void Main()
	// {		
		// double sum 			= new Addition().Run(5, 4);
		// double difference 	= new Subtraction().Run(5, 4);
		// double product		= new Multiplication().Run(5, 4);
		// double quotient		= new Division().Run(5, 4);
	// }
// }

// class Addition
// {
	// public double Run(int a, int b)
	// {
		// return a + b;
	// }
// }

// class Subtraction
// {
	// public double Run(int a, int b)
	// {
		// return a - b;
	// }
// }

// class Multiplication
// {
	// public double Run(int a, int b)
	// {
		// return a * b;
	// }
// }
	
// class Division
// {
	// public double Run(int a, int b)
	// {
		// return a / b;
	// }
// }

//Introducing basic version of facade. 
//Almost ideal. Still not ok, that classes are not grouped.

// class MainClass
// {
	// static void Main()
	// {
		// Operations operations = new Operations();
		
		// double sum 			= operations.addition.Run(5, 4);
		// double difference 	= operations.subtraction.Run(5, 4);
		// double product		= operations.multiplication.Run(5, 4);
		// double quotient		= operations.division.Run(5, 4);
	// }
// }

// class Operations // This is the facade in the form of a Data Structure
// {
	// public Addition 		addition 		= new Addition();
	// public Subtraction 		subtraction 	= new Subtraction();
	// public Multiplication 	multiplication 	= new Multiplication();
	// public Division 		division 		= new Division();
// }

// class Addition
// {
	// public double Run(int a, int b)
	// {
		// return a + b;
	// }
// }

// class Subtraction
// {
	// public double Run(int a, int b)
	// {
		// return a - b;
	// }
// }

// class Multiplication
// {
	// public double Run(int a, int b)
	// {
		// return a * b;
	// }
// }
	
// class Division
// {
	// public double Run(int a, int b)
	// {
		// return a / b;
	// }
// }

//Introducing namespace. (in VBA not possible)

// class MainClass
// {
	// static void Main()
	// {
		// Operations.Operations operations = new Operations.Operations();
		
		// double sum 			= operations.addition.Run(5, 4);
		// double difference 	= operations.subtraction.Run(5, 4);
		// double product		= operations.multiplication.Run(5, 4);
		// double quotient		= operations.division.Run(5, 4);
	// }
// }



// namespace Operations
// {
	// public class Operations
	// {
		// public Addition 		addition 		= new Addition();
		// public Subtraction 		subtraction 	= new Subtraction();
		// public Multiplication 	multiplication 	= new Multiplication();
		// public Division 		division 		= new Division();
	// }
// }

// namespace Operations
// {	
	// public class Addition
	// {
		// public double Run(int a, int b)
		// {
			// return a + b;
		// }
	// }

	// public class Subtraction
	// {
		// public double Run(int a, int b)
		// {
			// return a - b;
		// }
	// }

	// public class Multiplication
	// {
		// public double Run(int a, int b)
		// {
			// return a * b;
		// }
	// }
		
	// public class Division
	// {
		// public double Run(int a, int b)
		// {
			// return a / b;
		// }
	// }	
// }

// Encapsulate the state Introducing namespace. (in VBA not possible)

using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		Operations.Operations operations = new Operations.Operations();
		
		double sum 			= operations.addition.Run(5, 4);
		double difference 	= operations.subtraction.Run(5, 4);
		double product		= operations.multiplication.Run(5, 4);
		double quotient		= operations.division.Run(5, 4);
	}
}



namespace Operations
{		
	public class Operations
	{
		private List<double> results = new List<double>();
		
		public Addition 		addition;
		public Subtraction 		subtraction;
		public Multiplication 	multiplication;
		public Division 		division;
		
		public Operations()
		{
			addition 		= new Addition(results);
			subtraction 	= new Subtraction(results);
			multiplication 	= new Multiplication(results);
			division 		= new Division(results);			
		}	
	}
}

namespace Operations
{	
	public class Addition
	{
		List<double> results;
		
		public Addition(List<double> results)
		{
			this.results = results;
		}
		public double Run(int a, int b)
		{
			results.Add(a + b);
			return a + b;
		}
	}

	public class Subtraction
	{
		List<double> results;
		
		public Subtraction(List<double> results)
		{
			this.results = results;
		}
		public double Run(int a, int b)
		{
			results.Add(a - b);
			return a - b;
		}
	}

	public class Multiplication
	{
		List<double> results;
		
		public Multiplication(List<double> results)
		{
			this.results = results;
		}
		public double Run(int a, int b)
		{
			results.Add(a * b);
			return a * b;
		}
	}
		
	public class Division
	{
		List<double> results;
		
		public Division(List<double> results)
		{
			this.results = results;
		}
		public double Run(int a, int b)
		{
			results.Add(a / b);
			return a / b;
		}
	}	
}