using System;

//135 
//we are great our code is forever :-/

namespace MyProject
{
    public class MainClass
    {
        public static void Main()
        {
            IReadFile readFile = new ReadFile();

            DoTheReadFile(readFile);
        }

        public static void DoTheReadFile(IReadFile readFile)
        {
            string rawText = readFile.Run("data.txt");

            Console.WriteLine(rawText);
            Console.ReadLine();
        }
    }
}