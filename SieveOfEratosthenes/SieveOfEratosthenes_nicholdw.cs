using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes_nicholdw: SieveOfEratosthenes
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
            List<bool> A = new List<bool>();
            for (int i = 0; i <= stop; i++) { A.Add(true); solution.Add(i);}

            for (int i=2; i <= Math.Sqrt(stop); i++)
            {
                if(A[i] == true)
                {
                    for (int j = 2; j <= stop; j++)
                    {
                        A[j] = false;
                        for (int c = 0; c <= stop; c++)
                        {
                            j = i * i + c * i;
                            if (j <= stop) { A[j] = false; }
                            else { break; }
                        }
                    }
                }
            }
            A[0] = false;
            A[1] = false;
            A[2] = false;
            for(int i = 0; i < A.Count; i++)
            {
                if (A[i] == true)
                {
                    Console.WriteLine(solution[i].ToString());
                }
            }
            return solution;
        }
    }
}
