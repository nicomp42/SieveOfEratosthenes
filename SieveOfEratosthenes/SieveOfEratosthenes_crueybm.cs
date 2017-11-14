/*
 * Name: Brandon Cruey 
 * email: crueybm@mail.uc.edu
 * Class: Contemporary Programming
 * Date: 11/11/2017
 * Assignment: Sieve of Eratosthenes
 * Description: Solution to the Sieve of Eratosthenes problem given in class on 11/9
 * Citation: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes_crueybm : SieveOfEratosthenes
    {
        public override List<long> Solve(long start, long stop)
        {
            List<long> solution = new List<long>();
            bool[] sol = new bool[stop + 1];
            for (long i = 2; i <= stop; i++)
            {
                sol[i] = true;
            }
            for (long i = 2; i <= Math.Sqrt(stop); i++)
            {
                if (sol[i] == true)
                {
                    for (long j = i * i; j <= stop; j += i)
                    {
                        sol[j] = false;
                    }
                }
            }

            for (long i = start; i <= stop; i++)
            {
                if (sol[i])
                {
                    solution.Add(i);
                }
            }
            return solution;
        }
    }
}

