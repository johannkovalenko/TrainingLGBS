using System;

namespace MyProject
{
    public class MyClassHiding : MyBaseClassHiding
    {
        new public void MyMethod()
        {
            Console.WriteLine("Hello World");
        }
    }
}