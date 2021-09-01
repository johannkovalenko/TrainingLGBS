using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace prod
{
    public abstract class Algorithm
    {
        public abstract void Run(int maxNumber);

        protected bool[] bContainer;

        public void Print()
        {
            for (int i=2;i<bContainer.Length;i++)
                if (!bContainer[i])
                    Console.Write(i + " ");
        }

        public List<int> GetPrimeNumbers()
        {
            var output = new List<int>();

            for (int i=2;i<bContainer.Length;i++)
                if (!bContainer[i])
                    output.Add(i);

            return output;            
        }
    }

    public class Modulo : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

            for (int i=2;i<maxNumber;i++)
                for (int j=2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        bContainer[i] = true;
                        break;
                    }
                }
        }
    }

    public class ModuloWithSquareRoot : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

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
        }
    }

    public class Sieve : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

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
        }
    }

    public class SieveWithoutProduct : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

            for (int i=2;i<bContainer.Length;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<bContainer.Length;j+=i)
                    {
                        if (j < bContainer.Length)
                            bContainer[j] = true;
                        else
                            break;
                    }
        }
    }  

    public class SieveImproved : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

            for (int i=2;i<maxNumber;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;
        }
    }  

    public class SieveWithSquareRoot : Algorithm
    {
        public override void Run(int maxNumber)
        {
            bContainer = new bool[maxNumber];

            int root = (int)Math.Sqrt(maxNumber);
            for (int i=2;i<=root;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;
        }
    }  

    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 10000;

            bool print = false; // Flag, turn off when testing very large prime sequences

            Dictionary<string, Algorithm> algorithms = new Strategies().Generate();
            
            foreach (string algorithmName in algorithms.Keys)
            {
                Stopwatch stopwatch = new Stopwatch();
                var algorithm = algorithms[algorithmName];

                stopwatch.Start();
                algorithm.Run(maxNumber);
                stopwatch.Stop();

                if (print)
                    algorithm.Print();

                Console.WriteLine(algorithmName + ": " + stopwatch.Elapsed.TotalMilliseconds);
            }
        }
    }

    class Strategies
    {
        public Dictionary<string, Algorithm> Generate()
        {
            return StandardSet();
        }

        private Dictionary<string, Algorithm> StandardSet()
        {
            return new Dictionary<string, Algorithm> {
                {"Modulo",                  new Modulo()}, 
                {"ModuloWithSquareRoot",    new ModuloWithSquareRoot()}, 
                {"Sieve",                   new Sieve()}, 
                {"SieveWithoutProduct",     new SieveWithoutProduct()},
                {"SieveImproved",           new SieveImproved()},
                {"SieveWithSquareRoot",     new SieveWithSquareRoot()}
            };
        }
    }
}
