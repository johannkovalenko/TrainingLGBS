using System;

namespace Inheritance1
{
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Inheritance");
            var child = new Child();
            child.Play(); 
        }
    }

    class Parent
    {
        public virtual void Check() // abstract
        {
            Console.WriteLine("Checking");
        }
    }

    class Child : Parent
    {
        public void Play()
        {
            base.Check();
            Console.WriteLine("Playing");
        }
		
		public override void Check()
		{
			base.Check();
			
			Console.WriteLine("Something else");
		}
    }
	
	
}