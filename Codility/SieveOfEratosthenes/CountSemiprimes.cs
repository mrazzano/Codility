using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.SieveOfEratosthenes
{
    public class CountSemiprimes : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - CountSemiprimes");

            const int N = 26;
            var P = new[] {1, 4, 16};
            var Q = new[] {26, 10, 20};

            var result = solution(N, P, Q);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(int N, int[] P, int[] Q)
        {
            var nSqrt = Math.Sqrt(N);
            var sieve = new bool[N + 1];

            for (var i = 0; i < sieve.Length; i++)
                sieve[i] = true;

            // perform sieve
            sieve[0] = false;
            sieve[1] = false;
            for (var i = 2; i < nSqrt; i++)
            {
                if (!sieve[i])
                    continue;

                var j = i*i;
                while (j <= N)
                {
                    sieve[j] = false;
                    j += i;
                }
            }

            // get array of primes
            var primes = new List<int>();
            for (var i = 0; i < sieve.Length; i++)
            {
                if (sieve[i])
                {
                    primes.Add(i);
                }
            }

            // calculate semiprimes
            var semiPrimes = new int[N + 1];
            for (var i = 0; i <= nSqrt; i++)
            {
                for (var j = i; j < primes.Count; j++)
                {
                    var semiPrime = primes[i]*primes[j];
                    if (semiPrime > N)
                    {
                        break;
                    }
                    semiPrimes[semiPrime] = 1;
                }
            }

            // calculate prefix sums
            var semiPrimesCount = new int[N + 1];
            for (var i = 1; i < semiPrimesCount.Length; i++)
            {
                semiPrimesCount[i] = semiPrimesCount[i - 1] + semiPrimes[i];
            }

            //obtain result
            var result = new int[P.Length];
            for (var i = 0; i < P.Length; i++)
            {
                result[i] = semiPrimesCount[Q[i]] - semiPrimesCount[P[i] - 1];
            }

            return result;
        }
    }
}