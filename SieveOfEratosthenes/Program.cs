// https://primes.utm.edu/nthprime/index.php#nth for primes
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
            List<long> primes;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            // You will compute 1,000,000 primes
            primes = sieve.Solve(1, 15485864); // The 1,000,000th prime is 15,485,863
            stopWatch.Stop();
            Console.Write(name + ": " + stopWatch.ElapsedMilliseconds.ToString() + " Milliseconds, ");
            try
            {
                Console.WriteLine("returned " + primes.Count + " primes, first = " + primes[0] + " last = " + primes[primes.Count - 1]);
            } catch (Exception ex) {Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
