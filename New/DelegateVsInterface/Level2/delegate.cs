using System;

namespace Delegate2
{
    class Main
    {
		private delegate string ClientReadInvoice();
		
		public void Run()
        {
			ClientReadInvoice[] clientsReadInvoice = Factory();
			
			foreach (ClientReadInvoice clientReadInvoice in clientsReadInvoice)
			{
				string result = clientReadInvoice();
				
				Console.WriteLine(result);				
			}
        }
		
		private ClientReadInvoice[] Factory()
		{
			return new ClientReadInvoice[] {Microsoft.ReadInvoice, Apple.ReadInvoice, Oracle.ReadInvoice};
		}
    }

	static class Microsoft
	{
		public static string ReadInvoice()
		{
			return "Microsoft wants 300 dollars";
		}
	}
	
	static class Apple
	{
		public static string ReadInvoice()
		{
			return "Apple wants 1000 dollars";
		}
	}
	
	static class Oracle
	{
		public static string ReadInvoice()
		{
			return "Oracle wants 20 dollars";
		}
	}
}