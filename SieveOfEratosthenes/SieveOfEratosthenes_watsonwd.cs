/*****************************************************************
 * In class assignment
 * William Watson, Liam Powers
 * Description: This class uses the Sieve of Eratosthenes algorithm to find the prime numbers between a given start and stop point.
 * Due date: 11/09/2017
 * Citations: https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes 
 * Course: Contemporary programming fall 2017
 * Additional info:
 * 
 * ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{

    class SieveOfEratosthenes_watsonwd : SieveOfEratosthenes
    {
        public override List<long> Solve(long start, long stop)
        {
            // Declaration and instanciation of the returned List of primes and initial list of booleans.
            List<long> solution = new List<long>();
            List<bool> A = new List<bool>();

            // Initially every boolean in the list A will be set to true.
            for (long i = start; i < stop; i++)
            {
                A.Add(true);
            }

            // Logic of Sieve of Erratosthenes algorithm, temp variable is actual value of what is at the index.
            long temp = 0;
            for (long i = 0; i < Math.Sqrt(stop) - start; i++)
            {
                temp = start + i;
                if (A[(int)i])
                {
                    for (long j = temp * temp; j < stop; j += temp)
                    {
                        A[(int)(j - start)] = false;
                    }
                }
            }

            // This loop adds the prime values to the solution list.
            int x = 0;
            for (long i = start; i < stop; i++)
            {
                if (A[x])
                {
                    solution.Add(i);
                }

                x++;
            }

            return solution;
        }
    }
}
