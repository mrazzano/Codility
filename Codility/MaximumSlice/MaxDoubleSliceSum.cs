using System;
using Codility.Library;

namespace Codility.MaximumSlice
{
    internal class MaxDoubleSliceSum : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - MaxDoubleSliceSum");

            var A = new[] {3, 2, 6, -1, 4, 5, -1, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            var maxEndingHere = new int[length];
            var maxStartingHere = new int[length];

            for (var i = 1; i < length - 1; i++)
            {
                maxEndingHere[i] = Math.Max(0, A[i] + maxEndingHere[i - 1]);
            }

            for (var i = length - 2; i > 0; i--)
            {
                maxStartingHere[i] = Math.Max(0, A[i] + maxStartingHere[i + 1]);
            }

            var result = 0;
            for (var i = 1; i < length - 1; i++)
            {
                result = Math.Max(result, maxEndingHere[i - 1] + maxStartingHere[i + 1]);
            }
            return result;
        }
    }
}