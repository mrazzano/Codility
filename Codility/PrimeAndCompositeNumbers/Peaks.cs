using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Peaks : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - Peaks");

            var A = new[] {1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            var peaks = new List<int>();
            for (var i = 1; i < length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            var result = 0;
            for (var i = 1; i < length; i++)
            {
                if ((length%i) != 0)
                    continue;

                var target = 0;
                var block = length/i;
                foreach (var item in peaks)
                {
                    if (target*block <= item && item < (target + 1)*block)
                    {
                        target++;
                    }
                }
                if (target == i)
                {
                    result = i;
                }
            }
            return result;
        }
    }
}