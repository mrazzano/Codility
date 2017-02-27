using System;
using Codility.Library;

namespace Codility.PrefixSums
{
    internal class MinAvgTwoSlice : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - MinAvgTwoSlice");

            var A = new[] {4, 2, 2, 5, 1, 5, 8};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var result = 0;
            var minValue = Double.MaxValue;

            for (var i = 0; i < A.Length - 1; i++)
            {
                if (((A[i] + A[i + 1])/2.0) < minValue)
                {
                    result = i;
                    minValue = (A[i] + A[i + 1])/2.0;
                }
                if (i < A.Length - 2)
                {
                    if (((A[i] + A[i + 1] + A[i + 2])/3.0) < minValue)
                    {
                        result = i;
                        minValue = (A[i] + A[i + 1] + A[i + 2])/3.0;
                    }
                }
            }

            return result;
        }
    }
}