// Solutions at the bottom

using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {
        new Exercise_4.App().Main();
    }
}

// namespace Exercise_1
// {
//     // Which line/s will not compile?
//     class App
//     {
//         public void Main()
//         {    
//             Car car = new Car();
//             Car kia1 = new Kia();
//             Kia kia2 = new Kia();
//             Kia kia3 = new Car();
//         }
//     }

//     class Car {}
//     class Kia : Car {}
// }

// namespace Exercise_2
// {
//     // Which line/s will not compile?
//     class App
//     {
//         public void Main()
//         {    
//             Car car = new Car();
//             Car kia1 = new Kia();
//             Kia kia2 = new Kia();
//             Kia kia3 = new Car();
//         }
//     }

//     abstract class Car {}
//     class Kia : Car {}
// }

// namespace Exercise_3
// {
//     // Which line/s will not compile?
//     class App
//     {
//         public void Main()
//         {    
//             var a = new List<Car>();
//             a.Add(new Car());
//             a.Add(new Kia());
//             a.Add(new Hyundai());

//             var b = new List<Kia>();
//             b.Add(new Car());
//             b.Add(new Kia());
//             b.Add(new Hyundai());
//         }
//     }

//     abstract class Car {}
//     class Kia : Car {}
//     class Hyundai : Car {}
// }

namespace Exercise_4
{
    // Will this code compile?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            Kia kia = new Kia();
            kia.KiaPart();
            kia.CommonPart();
        }
    }

    class Car 
    {
        public void CommonPart()
        {
            Console.WriteLine("Common");
        }
    }

    class Kia : Car 
    {
        public void KiaPart()
        {
            Console.WriteLine("Kia");
        }
    }
}

namespace Exercise_5
{
    // Which line/s will not compile?

    class App
    {
        public void Main()
        {    
            MyClass myClass = new MyClass();
            myClass.baseCounter = 5;
            myClass.Run();
        }
    }

    class BaseClass 
    {
        protected int baseCounter = 0;
    }

    class MyClass : BaseClass 
    {
        public void Run()
        {
            Console.WriteLine(baseCounter);
        }
    }
}

namespace Exercise_6
{
    // Do the variables fit contextually?

    class App
    {
        public void Main()
        {

        }
    }

    abstract class Company
    {
        public string ceo;
        public int cylinders;
    }

    abstract class IT : Company
    {
        public float screenSize;
    }

    abstract class Automotive : Company
    {
        public bool FourWheelDrive;
    }

    class Software : IT
    {
        public string headquarters;
    }

    class Hardware : IT
    {
        public string headquarters;
        public string processor;
    }

    class Car : Automotive
    {
        public string headquarters;
        public int axesOfTrailer;
    }

    class Truck : Automotive
    {
        public string headquarters;
    }
}

namespace Exercise_6a
{
    // Do the variables fit contextually?

    class App
    {
        public void Main()
        {

        }
    }

    abstract class Company
    {
        public string ceo;
        public string headquarters;
    }

    abstract class IT : Company
    {

    }

    abstract class Automotive : Company
    {
        public bool FourWheelDrive;
        public int cylinders;
    }

    class Software : IT
    {

    }

    class Hardware : IT
    {
        public float screenSize;
        public string processor;
    }

    class Car : Automotive
    {

    }

    class Truck : Automotive
    {
        public int axesOfTrailer;
    }
}

namespace Exercise_7
{
    class App
    {
        public void Main()
        {

        }
    }

    abstract class Company
    {
        protected string ceo;
        protected string headquarters;
    }

    class Microsoft : Company
    {
        string currentOS = "Windows 10";
    
        public void Presentation()
        {
            ceo = "Used to be Bill Gates";
            headquarters = "Somewhere in the USA";

            Console.WriteLine(ceo + headquarters + currentOS);
        }
    }

    class Oracle : Company
    {
        string currentJava = "14.0";

        public void Presentation()
        {
            ceo = "No idea";
            headquarters = "Somewhere in the USA";

            Console.WriteLine(ceo + headquarters + currentJava);
        }
    }
}

// Exercise_8

// What is the value of ... at the end of Main():
//	1) model
// 	2) country
//	3) count

// What do we have to do to access all variables at the Main function level?

class MainClass
{
	static string country = "France";
	static void Main()
	{
		string country = "Poland";
		
		Car car = new Car();
		
		int count = Count();
	
	}
	
	static int Count()
	{
		return 500;
	}
}	

class Vehicle
{
	public string model = "Subaru Impreza"; 
}

class Car : Vehicle
{
	public string model = "Kia Ceed";
}

class MotoCycle
{
	public static string country = "Italy";
	
	public static int Count()
	{
		return 5;
	}
}

namespace A
{
	class Car
	{
		public string model = "Alfa Romeo 159";
	}
}

//Exercise 9

// Indicate the conceptual errors and provide an improved code
// Does this concept of taylor-fitted classes allow for polimorphism?

class MainClass
{
	static void Main()
	{

	}
}

class Vehicle
{
	protected int VIN;
	protected int roofHeight;
	protected bool fourWheelDrive;
}

class Car : Vehicle
{
	protected int numberOfWheels;
}

class Cabriolet : Car
{
	public int numberOfDoors;
}

class Sedan : Car
{
	public int numberOfDoors;
	public int heightOfRearWindow;
}

class Motocycle : Vehicle
{
	protected int numberOfWheels;
}

class TouringBike : Motocycle
{
	
}

// Exercise 10

// Is this a legit approach?

class MySuperDictionary : Dictionary<string, string>
{
	
}

// Exercise 11

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
		kia.engineType 		= "DOHC";
		kia.vin				= "abcdefgh";
		kia.rearWindowNumber = 1234;
		kia.frontWindowNumber = 5678;
		kia.primeMinisterOfKorea = "Sun";
		kia.rulingPartyInKorea = "Socialist Party";		
		
		kia.Assign();
	}

	static void PartCar()
	{
		Car car = new Car();
		
		car.numberOfWheels 	= 4;
		car.engineType 		= "DOHC";
		car.vin				= "abcdefgh";
		car.rearWindowNumber = 1234;
		car.frontWindowNumber = 5678;
		car.primeMinisterOfKorea = "Sun";
		car.rulingPartyInKorea = "Socialist Party";

		car.Assign();
	}
	
	static void PartVehicle()
	{
		Vehicle vehicle = new Vehicle();
		
		vehicle.numberOfWheels 	= 4;
		vehicle.engineType 		= "DOHC";
		vehicle.vin				= "abcdefgh";
		vehicle.rearWindowNumber = 1234;
		vehicle.frontWindowNumber = 5678;
		vehicle.primeMinisterOfKorea = "Sun";
		vehicle.rulingPartyInKorea = "Socialist Party";	

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
		rearWindowNumber = 1234;
		frontWindowNumber = 5678;
		primeMinisterOfKorea = "Sun";
		rulingPartyInKorea = "Socialist Party";			
	}
}

class Car : Vehicle
{
	public 		int 	rearWindowNumber;
	protected	int		frontWindowNumber;

	public 		void	Assign()
	{
		numberOfWheels 	= 4;
		engineType 		= "DOHC";
		vin				= "abcdefgh";
		rearWindowNumber = 1234;
		frontWindowNumber = 5678;
		primeMinisterOfKorea = "Sun";
		rulingPartyInKorea = "Socialist Party";			
	}
}

class Kia : Car
{
	public 		string	primeMinisterOfKorea;
	public		string	rulingPartyInKorea;
	
	public 		void	Assign()
	{
		numberOfWheels 	= 4;
		engineType 		= "DOHC";
		vin				= "abcdefgh";
		rearWindowNumber = 1234;
		frontWindowNumber = 5678;
		primeMinisterOfKorea = "Sun";
		rulingPartyInKorea = "Socialist Party";			
	}
}