using System;
using Codility.Library;

namespace Codility.MaximumSlice
{
    internal class MaxProfit : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MaxProfit");

            var A = new[] {23171, 21011, 21123, 21366, 21013, 21367};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var maxEnding = 0;
            var length = A.Length;

            var maxSlice = 0;
            for (var i = 1; i < length; i++)
            {
                maxEnding = Math.Max(0, maxEnding + A[i] - A[i - 1]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }
            return maxSlice;
        }
    }
}