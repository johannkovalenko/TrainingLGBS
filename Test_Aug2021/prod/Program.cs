using System;
using System.Diagnostics;

namespace prod
{
    interface Algorithm
    {
        bool[] Run(int maxNumber);
    }

    public class Modulo : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            for (int i=2;i<maxNumber;i++)
                for (int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        bContainer[i] = true;
                        break;
                    }
                }

            return bContainer;
        }
    }

    public class ModuloWithSquareRoot : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            for (int i=2;i<maxNumber;i++)
            {
                int squareRoot = (int)Math.Sqrt(i);

                for (int j=2;j<=squareRoot;j++)
                {
                    if (i % j == 0)
                    {
                        bContainer[i] = true;
                        break;
                    }
                }
            }

            return bContainer;
        }
    }

    public class Sieve : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            int product = 0;

            for (int i=2;i<maxNumber;i++)
                if (!bContainer[i])
                    for (int j=2;j<maxNumber;j++)
                    {
                        product = i * j;

                        if (product < maxNumber)
                            bContainer[product] = true;
                        else
                            break;
                    }

            return bContainer;
        }
    }

    public class SieveWithoutProduct : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            for (int i=2;i<bContainer.Length;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<bContainer.Length;j+=i)
                    {
                        if (j < bContainer.Length)
                            bContainer[j] = true;
                        else
                            break;
                    }

            return bContainer;
        }
    }  

    public class SieveImproved : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            for (int i=2;i<maxNumber;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;

            return bContainer;
        }
    }  

    public class SieveWithSquareRoot : Algorithm
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            int root = (int)Math.Sqrt(maxNumber);
            for (int i=2;i<=root;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;

            return bContainer;
        }
    }  

    class Printing
    {
        public void Run(bool[] bContainer)
        {
            for (int i=2;i<bContainer.Length;i++)
                if (!bContainer[i])
                    Console.Write(i + " ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 10;

            bool[] bContainer;
            bool print = true; // Flag, turn off when testing very large prime sequences

            var printing = new Printing();

            Algorithm algorithm;
            
            foreach (string currentAlgorithm in new string[] {"Modulo", "ModuloWithSquareRoot", "Sieve", "SieveWithoutProduct", "SieveImproved", "SieveWithSquareRoot"})
            {
                
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                //Algorithms to generate prime numbers
                switch (currentAlgorithm)
                {
                    case "Modulo":
                        algorithm = new Modulo();
                        bContainer = algorithm.Run(maxNumber);
                        stopwatch.Stop();

                        if (print)
                            printing.Run(bContainer);

                        break;
                    case "ModuloWithSquareRoot":
                        algorithm = new ModuloWithSquareRoot();
                        bContainer = algorithm.Run(maxNumber);
                        stopwatch.Stop();

                        if (print)
                            printing.Run(bContainer);

                        break;
                    case "Sieve":
                        algorithm = new Sieve();
                        bContainer = algorithm.Run(maxNumber);
                        stopwatch.Stop();

                        if (print)
                            printing.Run(bContainer);

                        break;
                    case "SieveWithoutProduct":
                        algorithm = new SieveWithoutProduct();
                        bContainer = algorithm.Run(maxNumber);

                        stopwatch.Stop();
                        
                        if (print)
                            printing.Run(bContainer);

                        break;
                    case "SieveImproved":
                        algorithm = new SieveImproved();
                        bContainer = algorithm.Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                            printing.Run(bContainer);

                        break;
                    case "SieveWithSquareRoot":
                        algorithm = new SieveWithSquareRoot();
                        bContainer = algorithm.Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                            printing.Run(bContainer);

                        break;
                }

                Console.WriteLine(currentAlgorithm + " " + stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }
}
