using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    /// <summary>
    /// Base class is abstract, you must implement the Solve method in your derived class
    /// </summary>
    abstract class SieveOfEratosthenes
    {
        /// <summary>
        /// The famous Sieve. Uses all numbers from start to stop, inclusive
        /// </summary>
        /// <param name="start">first number in the range</param>
        /// <param name="stop">last number in the range</param>
        /// <returns>A List containing all the prime numbers between start and stop, inclusive, inn ascending order.</returns>
        abstract public List<long> Solve(long start, long stop);
    }
}