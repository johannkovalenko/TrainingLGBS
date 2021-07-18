// under which circumstances does it make sense to use the using directive as in Ex2 ?

using System;
using System.Collections.Generic;

class MainClass
{
	static void Main()
	{
		
	}
}

namespace Ex1
{
	class App
	{
		public static void Run()
		{
			bool[] choices = {true, true, false, false, true}; // from external source
			
			List<DB> list = new List<DB>();
			
			foreach (bool choice in choices)
			{
				DB db = new DB();
				
				switch (choice)
				{
					case true:
						db.age = 30;
						db.name = "AAA";
						break;
					case false:
						db.age = 25;
						db.name = "BBB";
						break;
				}
				
				list.Add(db);
			}
		}
	}
	
	class DB
	{
		public int age;
		public string name;
	}
}

namespace Ex2
{
	class App
	{
		public static void Run()
		{
			bool[] choices = {true, true, false, false, true}; // from external source
			
			List<DB> list = new List<DB>();
			
			foreach (bool choice in choices)
			{
				using (DB db = new DB())
				{
					switch (choice)
					{
						case true:
							db.age = 30;
							db.name = "AAA";
							break;
						case false:
							db.age = 25;
							db.name = "BBB";
							break;
					}
					
					list.Add(db);
				}
			}
		}
	}
	
	class DB : IDisposable
	{
		public int age;
		public string name;
		
		bool disposed = false;

		public void Dispose()
		{ 
			Dispose(true);
			GC.SuppressFinalize(this);           
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposed)
				return; 

			if (disposing) 
			{
				//this.age = null;
				this.name = null;
			}

			disposed = true;
		}
	}
}