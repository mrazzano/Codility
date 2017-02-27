using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.SieveOfEratosthenes
{
    public class CountNonDivisible : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - CountNonDivisible");

            var A = new[] {3, 1, 2, 3, 6};

            var result = solution(A);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(int[] A)
        {
            var length = A.Length;
            var count = new Dictionary<int, int>();

            foreach (var key in A)
            {
                if (count.ContainsKey(key))
                {
                    count[key]++;
                }
                else
                {
                    count.Add(key, 1);
                }
            }

            var divisors = new Dictionary<int, int>();
            foreach (var key in count.Keys)
            {
                var j = 1;
                var sum = 0;
                while (j*j <= key)
                {
                    if (key%j == 0)
                    {
                        if (count.ContainsKey(j))
                        {
                            sum += count[j];
                        }

                        var k = key/j;
                        if (k != j)
                        {
                            if (count.ContainsKey(k))
                            {
                                sum += count[k];
                            }
                        }
                    }
                    j++;
                }
                divisors.Add(key, length - sum);
            }

            for (var i = 0; i < length; i++)
                A[i] = divisors[A[i]];

            return A;
        }
    }
}