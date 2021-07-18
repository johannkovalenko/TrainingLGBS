// which operations of value assignment will throw an error at compile time and which not.
// Please explain your choices

class MainClass 
{
	static void Main()
	{
		PartKia();
		PartCar();
		PartVehicle();
	}
	
	static void PartKia()
	{
		Kia kia = new Kia();
		
		kia.numberOfWheels 	= 4;
		//kia.engineType 		= "DOHC";
		//kia.vin				= "abcdefgh";
		kia.rearWindowNumber = 1234;
		//kia.frontWindowNumber = 5678;
		kia.primeMinisterOfKorea = "Sun";
		kia.rulingPartyInKorea = "Socialist Party";		
		
		kia.Assign();
	}

	static void PartCar()
	{
		Car car = new Car();
		
		car.numberOfWheels 	= 4;
		//car.engineType 		= "DOHC";
		//car.vin				= "abcdefgh";
		car.rearWindowNumber = 1234;
		//car.frontWindowNumber = 5678;
		// car.primeMinisterOfKorea = "Sun";
		// car.rulingPartyInKorea = "Socialist Party";

		car.Assign();
	}
	
	static void PartVehicle()
	{
		Vehicle vehicle = new Vehicle();
		
		vehicle.numberOfWheels 	= 4;
		//vehicle.engineType 		= "DOHC";
		// vehicle.vin				= "abcdefgh";
		//vehicle.rearWindowNumber = 1234;
		// vehicle.frontWindowNumber = 5678;
		// vehicle.primeMinisterOfKorea = "Sun";
		// vehicle.rulingPartyInKorea = "Socialist Party";	

		vehicle.Assign();
	}
}

class Vehicle
{
	public 		int 	numberOfWheels;
	protected 	string 	engineType;
	private		string  vin;
	
	public 		void	Assign()
	{
		numberOfWheels 	= 4;
		engineType 		= "DOHC";
		vin				= "abcdefgh";
		
		string x = vin;
		//rearWindowNumber = 1234;
		//frontWindowNumber = 5678;
		// primeMinisterOfKorea = "Sun";
		// rulingPartyInKorea = "Socialist Party";			
	}
}

class Car : Vehicle
{
	public 		int 	rearWindowNumber;
	protected	int		frontWindowNumber;

	new public void	Assign()
	{
		numberOfWheels 	= 4;
		engineType 		= "DOHC";
		//vin				= "abcdefgh";
		rearWindowNumber = 1234;
		frontWindowNumber = 5678;
		// primeMinisterOfKorea = "Sun";
		// rulingPartyInKorea = "Socialist Party";			
	}
}

class Kia : Car
{
	public 		string	primeMinisterOfKorea;
	public		string	rulingPartyInKorea;
	
	new public void	Assign()
	{
		base.Assign();
		numberOfWheels 	= 4;
		engineType 		= "DOHC";
		//vin				= "abcdefgh";
		rearWindowNumber = 1234;
		frontWindowNumber = 5678;
		primeMinisterOfKorea = "Sun";
		rulingPartyInKorea = "Socialist Party";			
	}
}