using System.Threading;
using System;
using System.Collections.Generic;

class App
{
	static void Main()
	{
		//StartThreadWithoutParameter();
		//StartThreadWithParameter_1();
		//StartThreadWithParameter_2();
		//StartThreadWithParameter_3();
		//StopThreadAndThreadStatus();
		ThreadsChangingExternalVariable();
		
		Console.ReadLine();
	}
	
	static void StartThreadWithoutParameter()
	{
		var threadLoop = new ThreadLoop();
		
		Thread thread = new Thread(threadLoop.RunThread);
		thread.Start();
		
		for (int i=0;i<20;i++)
			Console.WriteLine("Main " + i);			
	}

	static void StartThreadWithParameter_1() // somehow dirty, but ok
	{
		var threadLoop = new ThreadLoop();
		
		Thread thread = new Thread(threadLoop.RunThread_1);
		thread.Start("Example2");
		
		for (int i=0;i<20;i++)
			Console.WriteLine("Main " + i);			
	}
	
	static void StartThreadWithParameter_2() // not always possible
	{
		var threadLoop = new ThreadLoop_2("Example3");
		
		Thread thread = new Thread(threadLoop.RunThread);
		thread.Start();
		
		for (int i=0;i<20;i++)
			Console.WriteLine("Main " + i);			
	}

	static void StartThreadWithParameter_3() // allows more than one parameter
	{
		var threadLoop = new ThreadLoop();
		
		var myList = new List<int>();
		string myText = "Thread";
		
		ThreadStart threadStart = delegate 
		{
			threadLoop.RunThread_3(myList, myText);	
		};
		
		Thread thread = new Thread(threadStart);
		thread.Start();
		
		for (int i=0;i<20;i++)
			Console.WriteLine("Main " + i);			
	}
	
	static void StopThreadAndThreadStatus()
	{
		var threadLoop = new ThreadLoop();
		
		Thread thread = new Thread(threadLoop.RunThread_2);
		thread.Start();
		
		Thread.Sleep(1000);
		Console.WriteLine("Thread state: " + thread.ThreadState);
		
		Thread.Sleep(5000);
		thread.Abort();
		
		Console.WriteLine("Thread state: " + thread.ThreadState);
	}
	
	static void ThreadsChangingExternalVariable()
	{
		List<int> myList = new List<int>();
		
		var threadLoop = new ThreadLoop();
		
		ThreadStart starter1 = delegate {threadLoop.RunThread_3(myList, "Thread1");};
		ThreadStart starter2 = delegate {threadLoop.RunThread_3(myList, "Thread2");};
		
		new Thread(starter1).Start();
		new Thread(starter2).Start();
	}
}

class ThreadLoop
{
	public void RunThread()
	{
		for (int i=0;i<20;i++)
			Console.WriteLine("Thread " + i);
	}
	
	public void RunThread_1(object rawParameter)
	{
		string myText = (string) rawParameter;
		
		for (int i=0;i<20;i++)
			Console.WriteLine(myText + " " + i);
	}
	
	public void RunThread_2()
	{
		for (int i=0;i<20;i++)
		{
			Thread.Sleep(500);
			Console.WriteLine("Thread " + " " + i);
		}
	}
	
	public void RunThread_3(List<int> myList, string myText)
	{	
		for (int i=0;i<20;i++)
		{
			myList.Add(myList.Count);
			Console.WriteLine(myText + " " + myList.Count);		
		}
	}
}

class ThreadLoop_2
{
	string myText;
	
	public ThreadLoop_2(string myText)
	{
		this.myText = myText;
	}
	
	public void RunThread()
	{
		for (int i=0;i<20;i++)
			Console.WriteLine(myText + " " + i);
	}
}