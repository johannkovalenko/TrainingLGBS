using System;

namespace Delegate4
{
    class Main
    {
		
		private delegate void ClientAdd(int val);
		
        public void Run()
        {
			ClientAdd[] clients = Factory();
			
			foreach (ClientAdd client in clients)
			{
				client(100);
				client(50);			
			}
        }
		
		private ClientAdd[] Factory()
		{
			return new ClientAdd[] {new Microsoft().Add, new Apple().Add, new Oracle().Add};
		}
    }

	abstract class IClient
	{
		protected int toBePayed = 0;
		
		public abstract void Add(int val);
		
		protected void Warning()
		{
			if (toBePayed > 1000)
				Console.WriteLine("Warning");			
		}
	}

	class Microsoft : IClient
	{
		public override void Add(int val)
		{
			base.toBePayed += val * 5;
			
			base.Warning();
		}
	}
	
	class Apple : IClient
	{
		public override void Add(int val)
		{
			base.toBePayed += val * 10;
			
			base.Warning();
		}
	}
	
	class Oracle : IClient
	{
		public override void Add(int val)
		{
			base.toBePayed += val;
			
			base.Warning();
		}
	}
}


// Processor has 1 core -> multithreading 
// Processor has 4 cores -> multithreading 8 threads