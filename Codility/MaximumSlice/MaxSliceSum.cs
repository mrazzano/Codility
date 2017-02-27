using System;
using Codility.Library;

namespace Codility.MaximumSlice
{
    internal class MaxSliceSum : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - MaxSliceSum");

            var A = new[] {3, 2, -6, 4, 0};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            double maxSlice = Int32.MinValue;
            double maxEnding = Int32.MinValue;

            foreach (var item in A)
            {
                maxEnding = Math.Max(item, maxEnding + item);
                maxSlice = Math.Max(maxEnding, maxSlice);
            }

            return (int) maxSlice;
        }
    }
}