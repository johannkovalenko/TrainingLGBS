using System;

namespace Composition1
{
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Composition");
            var parent = new Parent();
            var child = new Child(parent);
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

    class Child
    {
        private Parent parent;

        public Child(Parent parent)
        {
            this.parent = parent;
        }

        public void Play()
        {
            parent.Check();
            Console.WriteLine("Playing");
        }
    }
}