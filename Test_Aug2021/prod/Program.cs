using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace prod
{
    public abstract class Algorithm
    {
        protected bool[] bContainer;
        protected int maxNumber;

        public Algorithm(int maxNumber)
        {
            this.maxNumber = maxNumber;
            bContainer = new bool[maxNumber];
        }

        public abstract void Run();

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
        public Modulo(int maxNumber) : base(maxNumber) {}

        public override void Run()
        {
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
        public ModuloWithSquareRoot(int maxNumber) : base(maxNumber) {}
        
        public override void Run()
        {
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
        public Sieve(int maxNumber) : base(maxNumber) {}

        public override void Run()
        {
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
        public SieveWithoutProduct(int maxNumber) : base(maxNumber) {}

        public override void Run()
        {
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
        public SieveImproved(int maxNumber) : base(maxNumber) {}

        public override void Run()
        {
            for (int i=2;i<maxNumber;i++)
                if (!bContainer[i])
                    for (int j=i+i;j<maxNumber;j+=i)
                        bContainer[j] = true;
        }
    }  

    public class SieveWithSquareRoot : Algorithm
    {
        public SieveWithSquareRoot(int maxNumber) : base(maxNumber) {}

        public override void Run()
        {
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
            Dictionary<string, Algorithm> algorithms = new Strategies(Config.maxNumber).Generate();

            var myStopwatch = new MyStopwatch();
            
            foreach (KeyValuePair<string, Algorithm> algorithm in algorithms)
            {
                myStopwatch.Start();
                algorithm.Value.Run();
                myStopwatch.StopAndRecord(algorithm.Key);

                if (Config.print)
                    algorithm.Value.Print();
            }

            myStopwatch.Print();
        }
    }

    class Config
    {
        public static int maxNumber = 10000;
        public static bool print = false;
        public static string set = "Reversed";
    }

    class MyStopwatch : Stopwatch
    {
        private Stopwatch stopwatch = new Stopwatch();
        private StringBuilder sb = new StringBuilder();

        public new void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        public void StopAndRecord(string algorithmName)
        {
            stopwatch.Stop();
            sb.Append(algorithmName + ": " + stopwatch.Elapsed.TotalMilliseconds + "\r\n");
        }

        public void Print()
        {
            Console.WriteLine(sb.ToString());
        }
    }

    class Strategies
    {
        private int maxNumber;

        public Strategies(int maxNumber)
        {
            this.maxNumber = maxNumber;
        }

        public Dictionary<string, Algorithm> Generate()
        {
            switch (Config.set)
            {
                case "Standard":
                    return StandardSet();
                case "Reversed":
                    return ReversedSet();
                default:
                    return StandardSet();
            }
        }

        private Dictionary<string, Algorithm> StandardSet()
        {
            return new Dictionary<string, Algorithm> {
                {"Modulo",                  new Modulo(maxNumber)}, 
                {"ModuloWithSquareRoot",    new ModuloWithSquareRoot(maxNumber)}, 
                {"Sieve",                   new Sieve(maxNumber)}, 
                {"SieveWithoutProduct",     new SieveWithoutProduct(maxNumber)},
                {"SieveImproved",           new SieveImproved(maxNumber)},
                {"SieveWithSquareRoot",     new SieveWithSquareRoot(maxNumber)}
            };
        }

        private Dictionary<string, Algorithm> ReversedSet()
        {
            return new Dictionary<string, Algorithm> {
                {"SieveWithSquareRoot",     new SieveWithSquareRoot(maxNumber)},
                {"SieveImproved",           new SieveImproved(maxNumber)},
                {"SieveWithoutProduct",     new SieveWithoutProduct(maxNumber)},
                {"Sieve",                   new Sieve(maxNumber)},
                {"ModuloWithSquareRoot",    new ModuloWithSquareRoot(maxNumber)}, 
                {"Modulo",                  new Modulo(maxNumber)} 
            };
        }
    }
}
