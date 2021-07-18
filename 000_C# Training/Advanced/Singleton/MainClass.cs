using System;

namespace MyProject
{
    class MainClass
    {
        static void Main()
        {
            SingletonClass singletonClass = SingletonClass.OneInstance();
            singletonClass.rootPath = @"C:\file.txt";

            Console.WriteLine(singletonClass.rootPath);
        }
    }
}