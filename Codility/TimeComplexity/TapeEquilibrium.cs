using System;
using System.Linq;
using Codility.Library;

namespace Codility.TimeComplexity
{
    internal class TapeEquilibrium : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - TapeEquilibrium");

            var A = new[] {3, 1, 2, 4, 3};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var sumLeft = 0;
            var sumRight = A.Sum();

            var result = int.MaxValue;
            for (var i = 1; i < A.Length; i++)
            {
                var current = A[i - 1];
                sumLeft += current;
                sumRight -= current;

                var diff = Math.Abs(sumLeft - sumRight);
                if (diff < result)
                    result = diff;
            }
            return result;
        }
    }
}