/*
 * Jeffrey Tskhadashvili
 * Michael Lawson
 * Sieve of Eratosthenes class
 * Done In class 11/09/17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class JeffreysClass : SieveOfEratosthenes
    {
        public JeffreysClass()
        {
        }

        //impliment solve method
        public override List<long> Solve(long start, long stop)
        {
            //solution list
            List<long> solution = new List<long>();

            
            //array of bools to check if prime
             bool[] MakeSieve = new bool[stop + 1];

            //make all values true
            for (long i = start; i <= stop; i++)
            {
                MakeSieve[i] = true;
            }

            //check if prime, if not prime, make false
            for (long i = start; i <= stop; i++)
            {
                if (MakeSieve[i])
                {
                    for (long j = i * 2; j <= stop ; j += i)
                    {
                        MakeSieve[j] = false;
                    }
                }
            }
            //add to the solution list if it is true, because true = prime
            for (int i = 0; i < MakeSieve.Length; i++)
            {
                if (MakeSieve[i] == true)
                {
                    solution.Add(i);
                }               
            }
            //remove any non-primes that might have slipped through
            for (int i = 0; i < solution.Count; i++)
            {
                if (solution[i] % 2 == 0)
                {
                    solution.RemoveAt(i);
                }
            }
            //test the first 100 primes in the sieve
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(solution[i]);
            }
            //return the solution list
            return solution;
        } 

        




    }
}
