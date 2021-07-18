using System;

namespace Interface4
{
    class Main
    {
        public void Run()
        {
			IClient[] clients = Factory();
			
			foreach (IClient client in clients)
			{
				client.Add(100);
				client.Add(50);				
			}
        }
		
		private IClient[] Factory()
		{
			return new IClient[] {new Microsoft(), new Apple(), new Oracle()};
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