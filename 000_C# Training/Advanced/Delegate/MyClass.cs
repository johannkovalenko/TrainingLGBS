using System;

namespace OtherSpace
{
    public class MyClass
    {
        public delegate void CheckVIN(int vin);
        private CheckVIN checkVIN {get; set;}

        public void AddCallback(CheckVIN checkVIN)
        {
            this.checkVIN = new CheckVIN(checkVIN);
        }

        public void Exe(int number)
        {
            checkVIN(number);
        }

    }
}