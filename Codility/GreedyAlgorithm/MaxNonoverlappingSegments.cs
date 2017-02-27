using System;
using Codility.Library;

namespace Codility.GreedyAlgorithm
{
    internal class MaxNonoverlappingSegments : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MaxNonoverlappingSegments");

            var A = new[] {1, 3, 7, 9, 9};
            var B = new[] {5, 6, 8, 9, 10};


            var result = solution(A, B);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A, int[] B)
        {
            var length = A.Length;
            if (length == 0)
                return length;

            var result = 1;
            var previousEnd = B[0];
            for (var i = 1; i < length; i++)
            {
                if (A[i] > previousEnd)
                {
                    previousEnd = B[i];
                    result++;
                }
            }

            return result;
        }
    }
}