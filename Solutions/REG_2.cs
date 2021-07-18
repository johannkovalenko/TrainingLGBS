//Show the bad practice in below code and provide a better version

class MainClass
{
	class DB
	{
		public Type gross = new Type();
		public Type net = new Type();
		
		class Type
		{
			public int thisYear;
			public int lastYear;
		}			
	}
	
	static void Main
	{
		DB db = new DB();
		
		db.gross.thisYear 	= 7000;
		db.gross.lastYear 	= 5000;
		db.net.thisYear	= 6800;
		db.net.lastYear	= 4850;
	}
}