using System;

namespace Inheritance2
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
        public void Check()
        {
            Console.WriteLine("Checking");
        }
    }

    class Uncle : Parent
    {
        public void Advise()
        {
            Console.WriteLine("Advising");
        }
    }

    class Child : Uncle
    {
        public void Play()
        {
            base.Check();
            base.Advise();
            Console.WriteLine("Playing");
        }
    }
}