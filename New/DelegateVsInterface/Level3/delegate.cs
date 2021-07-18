using System;

namespace Delegate3
{
    class Main
    {
		private delegate string DReadInvoice();
		private delegate void 	DSendConfirmation();
		
		public void Run()
        {
			Client[] clients = Factory();
			
			foreach (Client client in clients)
			{
				string result = client.readInvoice();
				
				Console.WriteLine(result);

				client.sendConfirmation();
			}
        }
		
		private Client[] Factory()
		{
			return new Client[]
			{
				new Client(Microsoft.ReadInvoice, Microsoft.SendConfirmation),
				new Client(Apple.ReadInvoice, Apple.SendConfirmation),
				new Client(Oracle.ReadInvoice, Oracle.SendConfirmation)
			};			
		}
		
		private class Client
		{
			public Client(DReadInvoice readInvoice, DSendConfirmation sendConfirmation)
			{
				this.readInvoice = readInvoice;
				this.sendConfirmation = sendConfirmation;
			}
			
			public DReadInvoice readInvoice;
			public DSendConfirmation sendConfirmation;
		}
    }

	static class Microsoft
	{
		public static string ReadInvoice()
		{
			return "Microsoft wants 300 dollars";
		}
		
		public static void SendConfirmation()
		{
			Console.WriteLine("Sending to Microsoft");
		}
	}
	
	static class Apple
	{
		public static string ReadInvoice()
		{
			return "Apple wants 1000 dollars";
		}

		public static void SendConfirmation()
		{
			Console.WriteLine("Sending to Apple");
		}
	}
	
	static class Oracle
	{
		public static string ReadInvoice()
		{
			return "Oracle wants 20 dollars";
		}
		
		public static void SendConfirmation()
		{
			Console.WriteLine("Sending to Oracle");
		}
	}
}