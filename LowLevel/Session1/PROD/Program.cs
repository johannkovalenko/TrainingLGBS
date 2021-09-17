using System;

namespace PROD
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = ToInteger("490asdf55");

            Console.WriteLine(result);
        }

        private static int ToInteger(string inputString)
        {
            //dostaje: "345" zwraca 345

            // 5 * 1 + 4 * 10 + 3 * 100 = 345
            int output = 0;
            int multiplicator = 1;

            for (int i=inputString.Length - 1; i>=0; i--)
            {
                int currentInt = (int)inputString[i] ^ 48;

                output += currentInt * multiplicator;

                multiplicator *= 10;
            }
            return output;
        }
    }
}


// 64 32 16 8 4 2 1
//     1  0 1 1 0 1

//     1  1 0 1 0 0


// int:     45      -> 00000000 00000000 00000000 00101101 (4 byte)
// string:  "45"    -> tablica integer (2 x 4 byte) 52 53

// 00000000 00000000 00000000 00110100 00000000 00000000 00000000 00110101


// czy jest operator który nam daje AND, OR, XOR, NOT

// 1 and 1 = 1, 1 and 0 = 0, 0 and 0 = 0
// 1 or 1 = 1, 1 or 0 = 1, 0 or 0 = 0
// 1 xor 1 = 0, 1 or 0 = 1, 0 or 0 = 0

// 0011 0100 -> 52 -> HEX: 38
// 0011 0000 -> 48 -> HEX: 30
// 0000 0100 ->  4 xor




