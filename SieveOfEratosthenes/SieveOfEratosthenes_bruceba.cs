/**************************************************************************************************
 * Bradley Bruce & Amber Powers
 * November 9, 2017
 * In Class Sieve Of Eratosthenes Assignment 
 * Contemporary Programming
 * Bill Nicholson
 * This class implements SieveOfEratosthenes algorithm to find prime numbers within specified range
 * ************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes_bruceba : SieveOfEratosthenes
    {
        public override List<long> Solve(long start, long stop)
        {

            //length of array
            long Arraylength = stop - start;

            //create array of bools
            bool[] A = new bool[Arraylength];

            //make every bool true
            for (int a = 0; a < A.Length; a++)
            {
                A[a] = true;
            }

            //for every value not exceeding sqrt of stop value
            for (long i = start; i < Math.Sqrt(stop); i++)
            {
                //as long as the bool value is true
                if (A[i] == true)
                {
                    //initilize varibles j and z
                    long j;
                    long z = 0;

                    //for loop j
                    for (j = 0; j < A.Length; z++)
                    {


                        j = (i * i) + (z * i);

                        //as long as j does not exceed the length of the array make that value false
                        if (j < A.Length)
                        {
                            A[j] = false;
                        }


                    }//end for loop j

                }//end if a value is true


            }//end for every value not exceeding sqrt of stop value


            //create list array g to return 
            List<long> g = new List<long>();

            //any value that is still true is prime and is added to g
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == true)
                {
                    g.Add(i);

                }
            }

            //return g which is all values which are prime
            return g;



        }//end solve

    }//end class

}//end namespace
