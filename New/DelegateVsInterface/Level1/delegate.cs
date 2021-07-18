using System;

namespace Delegate1
{
    class Main
    {
        delegate string RunStep1(string input);
		
		public void Run()
        {
			// 1 : n
			RunStep1 runStep1 = Step1.Run;
			
			string result = runStep1("Delegate1");
			
			Console.WriteLine(result);
        }
    }

	static class Step1
	{
		public static string Run(string input)
		{
			return input + " Step1";
		}
	}
}