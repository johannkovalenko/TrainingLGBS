class app
{
    static void Main()
    {
        //Level 1: Slight advantage for Delegate
        new Delegate1.Main().Run();
        new Interface1.Main().Run();

        //Level 2: Slight advantage for Delegate
        new Delegate2.Main().Run();
        new Interface2.Main().Run();
		
        //Level 3: Interface wins
        new Delegate3.Main().Run();
        new Interface3.Main().Run();	

        //Level 4: Abstract class wins
        new Delegate4.Main().Run();
        new Interface4.Main().Run();	
		
		System.Console.ReadLine();
    }
}