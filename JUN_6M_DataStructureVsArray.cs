/* Questions

	List all the advantages of the type List<CustomType>.

*/

namespace Exercise1
{
	//Please tell the bad practice and provide a better code

	using System;

	class MainClass
	{
		static void Main()
		{	
			List<object[]> myData = new List<object[]>();
			
			myData.Add(Emp1());
			myData.Add(Emp2());
			
			foreach (object emp in myData)
				if (emp[2] > 5000)
					Console.WriteLine(emp[0] + " earns more than 5000 zl");
				
			Console.ReadLine();
		}
		
		static object[] Emp1()
		{
			object[] output = new object[3];
			
			output[0] = "Pawel"; 	//Name
			output[1] = 33; 		//Age
			output[2] = 7000; 		//Salary
			
			return output;
		}
		
		static object[] Emp2()
		{
			object[] output = new object[3];
			
			output[0] = "Michal"; 	//Name
			output[1] = 27; 		//Age
			output[2] = 5000; 		//Salary
			
			return output;
		}
	}	
}