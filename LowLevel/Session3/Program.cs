using System;
using System.Diagnostics;
using System.Text;

namespace Session3
{
    class Program
    {
        static StringBuilder sb = new StringBuilder();
        static Stopwatch stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            Horizontal();
            Vertical();
            Horizontal();
            Vertical();
            Vertical();
            Horizontal();
            
            Console.WriteLine(sb.ToString());
        }

        static void Horizontal()
        {
            stopwatch.Start();

            int x = 0;

            int[,] arr = new int[10000, 10000];

            for(int i=0; i<10000; i++)
                for(int j=0; j<10000; j++)
                    x = arr[i, j];

            stopwatch.Stop();
            sb.Append("Horizontal " + stopwatch.Elapsed.TotalMilliseconds + "\r\n");
            stopwatch.Reset();
        }

        static void Vertical()
        {
            stopwatch.Start();

            int x = 0;

            int[,] arr = new int[10000, 10000];

            for(int i=0; i<10000; i++)
                for(int j=0; j<10000; j++)
                    x = arr[j, i];

            stopwatch.Stop();
            sb.Append("Vertical " + stopwatch.Elapsed.TotalMilliseconds + "\r\n"); 
            stopwatch.Reset();
        }
    }
}
