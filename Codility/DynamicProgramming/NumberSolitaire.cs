using System;
using Codility.Library;

namespace Codility.DynamicProgramming
{
    internal class NumberSolitaire : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - NumberSolitaire");

            var A = new[] {1, -2, 0, 9, -1, -2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            var dp = new int[length];

            dp[0] = A[0];
            for (var i = 1; i < length; i++)
            {
                dp[i] = dp[i - 1];
                for (var j = 1; j <= 6; j++)
                {
                    if (i < j)
                        break;

                    dp[i] = Math.Max(dp[i], dp[i - j]);
                }
                dp[i] += A[i];
            }
            return dp[length - 1];
        }
    }
}