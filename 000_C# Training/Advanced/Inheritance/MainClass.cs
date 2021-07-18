using System;

namespace MyProject
{
    class MainClass
    {
        public static void Main()
        {
            new MyClassHiding().MyMethod();
            new MyClassOverride().MyMethod();

            new ClassTryingToImplementSealedClass().MyMethod();
        }
    }
}