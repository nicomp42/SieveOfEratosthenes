using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new SieveOfEratosthenes_nicholdw(), "nicholdw");

        }
        private static void Test(SieveOfEratosthenes sieve, String name)
        { 
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sieve.Solve(3,1000000000);
            stopWatch.Stop();
            Console.WriteLine(name + ": " + stopWatch.ElapsedMilliseconds.ToString() + " Milliseconds");
        }
    }
}
