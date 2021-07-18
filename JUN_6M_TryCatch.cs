/* Questions

	True or false?
		a) We use try-catch only, when we cannot predict when the error will appear, and when there is no possibility to react to it, when it appears
		b) We use try-catch as often as possible in order to avoid the usage of built-in functions and/or own algorithms that react to the error. This shows that we are good programmers.
		c) Try-catch in VBA is technically more advanced than in C#.
		d) Try-catch is often misused to achieve quick fixes, but introduces long-term technical debt.
		e) in languages, that not do not have unhandled errors (for example C++), every mistake by the programmer can have fatal consequences.
		f) Unhandled errors are annoying but are better than no errors together with potential erratic behaviour of the program.
		g) Method A calls method B within the try-catch block. Method B has no try-catch block. An error appears in method B. The error will be caught.
		h) When we catch an error, the "catch" block is executed. Then the "finally" will not be executed anymore.
		i) After the catch block is executed, the program continues with the next line in the try-block.
		
*/


// Please tell, in which of the below cases the use of Try-Catch is justified?
// For those cases, where Try-Catch is not justified, provide an improved code.

using System;
using System.Collections.Generic;
using System.IO;

class MainClass
{
	static void Main()
	{
		Ex1.App.Run();
		Ex2.App.Run();
		Ex3.App.Run();
		Ex4.App.Run();
		Ex5.App.Run();
		Ex6.App.Run();
	}
}

namespace Ex1
{
	public class App
	{
		public static void Run()
		{
			int[] myArr = new int[10];
			
			try
			{
				for (int i=0;i<30;i++)
					myArr[i] = i;
			}
			catch (Exception)
			{
				
			}
		}
	}
}

namespace Ex2
{
	public class App
	{
		public static void Run()
		{
			string answer = Console.ReadLine();
			
			try
			{
				int number = int.Parse(answer);
			}
			catch (Exception)
			{
				
			}
		}
	}
}

namespace Ex3
{
	public class App
	{
		public static void Run()
		{
			Dictionary <int, int> dict = new Dictionary<int, int>();
			
			int[] myArr = {3, 4, 3, 2, 3, 4};
			
			foreach (int myInt in myArr)
				try
				{
					dict.Add(myInt, myInt);
				}
				catch (Exception)
				{
					dict[myInt] += myInt;
				}
		}
	}
}

namespace Ex4
{
	public class App
	{
		public static void Run()
		{
			string answer = Console.ReadLine();
			
			List<int> list = Create(answer);
			
			try
			{
				list.Add(1);
			}
			catch (Exception)
			{

			}
		}
		
		static List<int> Create(string answer)
		{
			switch (answer)
			{
				case "a":
					return new List<int>();
				default:
					return null;
			}
		}
	}
}

namespace Ex5
{
	public class App
	{
		public static void Run()
		{
			try
			{
				using (StreamWriter sw = File.AppendText("input.txt"))
				{
					sw.WriteLine("abc");
				}
			}
			catch (Exception)
			{

			}
		}
	}
}

namespace Ex6
{
	public class App
	{
		public static void Run()
		{
			string text = Console.ReadLine();
			string substring = "";
			
			try
			{
				substring = text.Substring(0, 53);
			}
			catch (Exception)
			{

			}
		}
	}
}