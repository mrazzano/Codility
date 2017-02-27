using System;
using System.Linq;
using Codility.Library;

namespace Codility.BinarySearch
{
    internal class NailingPlanks : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - NailingPlanks");

            var A = new[] {1, 4, 5, 8};
            var B = new[] {4, 5, 9, 10};
            var C = new[] {4, 6, 7, 10, 2};

            var result = solution(A, B, C);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A, int[] B, int[] C)
        {
            const int lowerBits = 15;

            var N = A.Length;
            var M = C.Length;

            var c = C.ToList();
            for (var i = 0; i < c.Count; i++)
            {
                c[i] = c[i] << lowerBits | i;
            }
            c.Sort();

            var result = 0;
            for (var i = 0; i < N && result < M; i++)
            {
                var minNail = M;

                var firstNail = c.BinarySearch(A[i] << lowerBits);
                firstNail = firstNail < 0 ? ~firstNail : firstNail;

                var secondNail = c.BinarySearch(B[i] + 1 << lowerBits);
                secondNail = secondNail < 0 ? ~secondNail : secondNail;

                for (var k = firstNail; k < secondNail && minNail > result; k++)
                {
                    minNail = Math.Min(minNail, c[k]%(1 << lowerBits));
                }

                result = Math.Max(result, minNail);
            }

            return result < M ? result + 1 : -1;
        }
    }
}