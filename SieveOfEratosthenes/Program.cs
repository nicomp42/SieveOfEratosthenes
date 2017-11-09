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
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            (new SieveOfEratosthenes_nicholdw()).Solve(2,100);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds.ToString() + " Milliseconds");
        }
    }
}
