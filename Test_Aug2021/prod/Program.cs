using System;
using System.Diagnostics;

namespace prod
{
    class Modulo
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

    class ModuloWithSquareRoot
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

    class Sieve
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

    class SieveWithoutProduct
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            for (int i=0;i<bContainer.Length;i++)
                bContainer[i] = true;

            for (int i=2;i<bContainer.Length;i++)
                if (bContainer[i])
                    for (int j=i+i;j<bContainer.Length;j+=i)
                    {
                        if (j < bContainer.Length)
                            bContainer[j] = false;
                        else
                            break;
                    }

            return bContainer;
        }
    }  

    class SieveImproved
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

    class SieveWithSquareRoot
    {
        public bool[] Run(int maxNumber)
        {
            bool[] bContainer = new bool[maxNumber];

            int root = (int)Math.Sqrt(maxNumber);
            for (int i=2;i<root;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;

            return bContainer;
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 10000;

            bool[] bContainer;
            bool print = false; // Flag, turn off when testing very large prime sequences

            foreach (string algorithm in new string[] {"Modulo", "ModuloWithSquareRoot", "Sieve", "SieveWithoutProduct", "SieveImproved", "SieveWithSquareRoot"})
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                //Algorithms to generate prime numbers
                switch (algorithm)
                {
                    case "Modulo":
                        bContainer = new Modulo().Run(maxNumber);
                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (!bContainer[i])
                                    Console.Write(i + " ");
                        }

                        break;
                    
                    case "ModuloWithSquareRoot":
                        bContainer = new ModuloWithSquareRoot().Run(maxNumber);
                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (!bContainer[i])
                                    Console.Write(i + " ");
                        }
                        break;
                    
                    case "Sieve":
                        bContainer = new Sieve().Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (!bContainer[i])
                                    Console.Write(i + " ");
                        }
                        
                        break;
                    
                    case "SieveWithoutProduct":
                        bContainer = new SieveWithoutProduct().Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (bContainer[i])
                                    Console.Write(i + " ");
                        }
                        break;

                    case "SieveImproved":
                        bContainer = new SieveImproved().Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (!bContainer[i])
                                    Console.Write(i + " ");
                        }
                        break;

                    case "SieveWithSquareRoot":
                        bContainer = new SieveWithSquareRoot().Run(maxNumber);

                        stopwatch.Stop();

                        if (print)
                        {
                            for (int i=2;i<bContainer.Length;i++)
                                if (!bContainer[i])
                                    Console.Write(i + " ");
                        }
                        break;
                }

                Console.WriteLine(algorithm + " " + stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }
}
