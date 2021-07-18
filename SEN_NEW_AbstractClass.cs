// Solutions at the bottom

using System;
using System.Collections.Generic;

class App
{
    static void Main()
    {

    }
}

// namespace Exercise_1
// {
//     // What will be the results?
//     // Is the approach sensible?

//     class App
//     {
//         public void Main()
//         {    
//             var cars = new List<Car>();
//             cars.Add(new Car());
//             cars.Add(new Kia());
//             cars.Add(new Hyundai());

//             foreach (Car car in cars)
//                 car.Run();
//         }
//     }

//     class Car 
//     {
//         public void Run() 
//         {
//             Console.WriteLine("Car");
//         }
//     }
//     class Kia : Car 
//     {
//         public void Run() 
//         {
//             Console.WriteLine("Kia");
//         }
//     }
//     class Hyundai : Car 
//     {
//         public void Run() 
//         {
//             Console.WriteLine("Hyundai");
//         }
//     }
// }

namespace Exercise_1a
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    class Car 
    {
        public void Run() 
        {
            Console.WriteLine("Car");
        }
    }
    class Kia : Car 
    {
        public new void Run() 
        {
            Console.WriteLine("Kia");
        }
    }
    class Hyundai : Car 
    {
        public new void Run() 
        {
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_1b
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Car());
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    class Car 
    {
        public virtual void Run() 
        {
            Console.WriteLine("Car");
        }
    }
    class Kia : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Kia");
        }
    }
    class Hyundai : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Hyundai");
        }
    }
}

// namespace Exercise_1c
// {
//     // Which line/s will not compile?

//     class App
//     {
//         public void Main()
//         {    
//             var cars = new List<Car>();
//             cars.Add(new Car());
//             cars.Add(new Kia());
//             cars.Add(new Hyundai());

//             foreach (Car car in cars)
//                 car.Run();
//         }
//     }

//     class Car 
//     {
//         public void Run() 
//         {
//             Console.WriteLine("Car");
//         }
//     }
//     class Kia : Car 
//     {
//         public override void Run() 
//         {
//             Console.WriteLine("Kia");
//         }
//     }
//     class Hyundai : Car 
//     {
//         public override void Run() 
//         {
//             Console.WriteLine("Hyundai");
//         }
//     }
// }

namespace Exercise_2
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    abstract class Car 
    {
        public abstract void Run();
    }
    class Kia : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Kia");
        }
    }
    class Hyundai : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_2a
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
            {
                car.Run();
                car.CommonLogic();
            }
        }
    }

    abstract class Car 
    {
        public abstract void Run();
        
        public void CommonLogic()
        {
            Console.WriteLine("Commmon part");
        }
    }
    class Kia : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Kia");
        }
    }
    class Hyundai : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_2b
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    abstract class Car 
    {        
        public virtual void Run()
        {
            Console.WriteLine("Commmon part");
        }
    }
    class Kia : Car 
    {
        public override void Run() 
        {
            Console.WriteLine("Kia");
            base.Run();
        }
    }
    class Hyundai : Car 
    {
        public override void Run() 
        {
            base.Run();
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_2c
{
    // Which line/s will not compile?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    abstract class Car 
    {        
        protected virtual void Run()
        {
            Console.WriteLine("Commmon part");
        }
    }
    class Kia : Car 
    {
        protected override void Run() 
        {
            Console.WriteLine("Kia");
            base.Run();
        }
    }
    class Hyundai : Car 
    {
        public override void Run() 
        {
            base.Run();
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_2d
{
    // What will be the results?
    // Is the approach sensible?

    class App
    {
        public void Main()
        {    
            var cars = new List<Car>();
            cars.Add(new Kia());
            cars.Add(new Hyundai());

            foreach (Car car in cars)
                car.Run();
        }
    }

    interface Car 
    {
        void Run();
    }

    class Kia : Car 
    {
        public void Run() 
        {
            Console.WriteLine("Kia");
        }
    }

    class Hyundai : Car 
    {
        public void Run() 
        {
            Console.WriteLine("Hyundai");
        }
    }
}

namespace Exercise_3
{
	//This abstract class is very nice.
	//But unfortunately this code won't compile.
	//Please explain why and repair the code

	using System;

	class MainClass
	{
		static void Main()
		{
			Car[] cars = {new Kia(), new Hyundai()};
			int totalTax;
			
			foreach (Car car in cars)
			{
				totalTax 	= 	car.GeneralCarTax();
				totalTax 	+= 	car.SpecificCarTax();
			}
			
			Car car1 = new Car();
			totalTax += car1.GeneralCarTax();
			totalTax += car1.SpecificCarTax();

			Console.WriteLine(totalTax);
			
			Console.ReadLine();
		}
	}

	abstract class Car
	{
		public virtual int GeneralCarTax()
		{
			return 50;
		}
		
		public abstract int SpecificCarTax();
	}

	class Kia : Car
	{
		public override int SpecificCarTax()
		{
			return 20;
		}
	}

	class Hyundai : Car
	{
		public override int SpecificCarTax()
		{
			return 15;
		}
	}
}

// Exercise 4



// show which Ex shows standard inheritance and which shows polimorphism
// when would you use which concept? provide a example

using System;

class MainClass
{
	static void Main()
	{
		Ex1();
		Ex2();
 
		Console.ReadLine();
	}
	
	static void Ex1()
	{
	
	}
	
	static void Ex2()
	{
		
	}
}

namespace Ex1
{
	abstract class Car
	{
		public virtual int GeneralCarTax()
		{
			return 50;
		}
		
		public abstract int SpecificCarTax();
	}

	class Kia : Car
	{
		public override int SpecificCarTax()
		{
			return 20;
		}
	}

	class Hyundai : Car
	{
		public override int SpecificCarTax()
		{
			return 15;
		}
	}
}

namespace Ex2
{
	class Car
	{
		public int GeneralCarTax()
		{
			return 50;
		}
	}

	class Kia : Car
	{
		public int SpecificCarTax()
		{
			return 20;
		}
	}

	class Hyundai : Car
	{
		public int SpecificCarTax()
		{
			return 15;
		}
	}
}	