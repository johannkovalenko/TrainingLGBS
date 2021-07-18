using System;

namespace Interface3
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

				client.SendConfirmation();
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
		void SendConfirmation();
	}

	class Microsoft : IClient
	{
		public string ReadInvoice()
		{
			return "Microsoft wants 300 dollars";
		}
		
		public void SendConfirmation()
		{
			Console.WriteLine("Sending to Microsoft");
		}
	}
	
	class Apple : IClient
	{
		public string ReadInvoice()
		{
			return "Apple wants 1000 dollars";
		}

		public void SendConfirmation()
		{
			Console.WriteLine("Sending to Apple");
		}
	}
	
	class Oracle : IClient
	{
		public string ReadInvoice()
		{
			return "Oracle wants 20 dollars";
		}
		
		public void SendConfirmation()
		{
			Console.WriteLine("Sending to Oracle");
		}
	}
}