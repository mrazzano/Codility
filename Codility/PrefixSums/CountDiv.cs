using System;
using Codility.Library;

namespace Codility.PrefixSums
{
    internal class CountDiv : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - CountDiv");

            const int A = 6;
            const int B = 11;
            const int K = 2;

            var result = solution(A, B, K);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int A, int B, int K)
        {
            long result;
            if (A%K == 0)
            {
                result = ((B - A)/K) + 1;
            }
            else
            {
                result = (B/K - ((A/K) + 1)) + 1;
            }

            return (int) result;
        }
    }
}