using System;

namespace Interface2
{
    class Main
    {
        public void Run()
        {
			IClient[] clients = Factory();
			
			foreach (IClient client in clients)
			{
				string result = client.ReadInvoice();
				
				Console.WriteLine(result);				
			}
        }
		
		private IClient[] Factory()
		{
			return new IClient[] {new Microsoft(), new Apple(), new Oracle()};
		}
    }

	interface IClient
	{
		string ReadInvoice();
	}

	class Microsoft : IClient
	{
		public string ReadInvoice()
		{
			return "Microsoft wants 300 dollars";
		}
	}
	
	class Apple : IClient
	{
		public string ReadInvoice()
		{
			return "Apple wants 1000 dollars";
		}
	}
	
	class Oracle : IClient
	{
		public string ReadInvoice()
		{
			return "Oracle wants 20 dollars";
		}
	}
}