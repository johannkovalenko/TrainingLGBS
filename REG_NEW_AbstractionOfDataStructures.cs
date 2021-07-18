/* Questions
	True or false?
		a) having a data structure is already a sign of abstraction
		b) if the data structure has too many variable, sub classes should be created. This is meant by "Abstraction of Data Structures"
		
	You can:
		a) create a data structure with a subclass structure	
*/


namespace Exercise1
{
	//Show the bad practice in below code and provide a better version

	class MainClass
	{
		class DB
		{
			public int salaryGross2019;
			public int salaryGross2018;
			public int salaryNet2019;
			public int salaryNet2019;			
		}
		
		static void Main
		{
			DB db = new DB();
			
			db.salaryGross2019 	= 7000;
			db.salaryNet2019 	= 5000;
			db.salaryGross2018	= 6800;
			db.salaryNet2018	= 4850;
		}
	}
}