using System;

namespace MyProject
{
    public class SingletonClass
    {
        private SingletonClass()
        {}

        public string rootPath;

        public static SingletonClass OneInstance()
        {
            return new SingletonClass();
        }
    }
}