/*
 * Authors:
 * Kellam Spencer
 * Jeremy Ring
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes_spencekk:SieveOfEratosthenes
    {
        /// <summary>
        /// The famous Sieve. Uses all numbers from start to stop, inclusive
        /// </summary>
        /// <param name="start">first number in the range</param>
        /// <param name="stop">last number in the range</param>
        /// <returns>A List containing all the prime numbers between start and stop, inclusive, inn ascending order.</returns>
        public override List<long> Solve(long start, long stop)
        {
            List<long> solution = new List<long>();

            bool[] booleans = new bool[stop+1];

            for(long i = 2; i <= stop; i++)
            {
                booleans[i] = true;
            }

            for(long i = 2; i <= Math.Sqrt(stop); i++)
            {
                if(booleans[i])
                {
                    for(long j = i*i; j <= stop; j += i)
                    {
                        booleans[j] = false;

                    }
                }
            }

            for (long i = start; i <= stop; i++)
            {
                if(booleans[i])
                {
                    solution.Add(i);
                }
            }

            return solution;
        }
    }
}
