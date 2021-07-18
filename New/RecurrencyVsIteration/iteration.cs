using System;
using System.IO;

class app
{
	static void Main()
	{
		Walkthrough(@"C:\Users\u540929\OneDrive - Lufthansa Group\johann\TL\Exercises per role and work experience\New");
		
		Console.ReadLine();
	}
	
	static void Walkthrough(string directory)
	{
		string[] subDirectories = Directory.GetDirectories(directory);
		
		foreach (string subDirectory in subDirectories)
		{
			Walkthrough(subDirectory);
			
			AllFiles(subDirectory);
		}
	}
	
	static void AllFiles(string subDirectory)
	{
		string[] files = Directory.GetFiles(subDirectory);
		
		Console.WriteLine(subDirectory);
		
		foreach (string file in files)
			Console.WriteLine("\t" + Path.GetFileName(file));		
	}
}

