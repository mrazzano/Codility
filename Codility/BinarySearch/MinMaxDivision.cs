using System;
using System.Linq;
using Codility.Library;

namespace Codility.BinarySearch
{
    internal class MinMaxDivision : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MinMaxDivision");

            const int K = 3;
            const int M = 5;
            var A = new[] {2, 1, 5, 1, 2, 2, 2};

            var result = solution(K, M, A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int K, int M, int[] A)
        {
            var max = A.Max();
            if (max > M)
                return 0;

            var result = max*A.Length;

            while (max < result)
            {
                var t = (max + result)/2;

                int i = 0, j = 0, s = 0;
                while (i < A.Length && j < K)
                {
                    s += A[i];
                    if (s > t)
                    {
                        s = A[i];
                        j++;
                    }
                    i++;
                }

                if (j == K)
                {
                    max = t + 1;
                }
                else
                {
                    result = t;
                }
            }
            return result;
        }
    }
}