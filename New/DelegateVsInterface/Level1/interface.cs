using System;

namespace Interface1
{
    class Main
    {
        public void Run()
        {
			//  1 : n  
			IStep1 step1 = new Step1(); 
			
			string result = step1.Run("Interface1");
			
			Console.WriteLine(result);
        }
    }

	interface IStep1
	{
		string Run(string input);
	}

	class Step1 : IStep1
	{
		public string Run(string input)
		{
			return input + " Step1";
		}
	}
}