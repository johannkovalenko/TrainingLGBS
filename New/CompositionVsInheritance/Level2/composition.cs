using System;

namespace Composition2
{
    class Main
    {
        public void Run()
        {
            Console.WriteLine("Composition");
            var parent = new Parent();
            var uncle = new Uncle();
            var child = new Child(parent, uncle); 
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

    class Uncle
    {
        public void Advise()
        {
            Console.WriteLine("Advising");
        }
    }

    class Child
    {
        private Parent parent;
        private Uncle uncle;

        public Child(Parent parent, Uncle uncle)
        {
            this.parent = parent;
            this.uncle = uncle;
        }

        public void Play()
        {
            parent.Check();
            uncle.Advise();
            Console.WriteLine("Playing");
        }
    }
}