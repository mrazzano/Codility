using System;
using Codility.Library;

namespace Codility.GreedyAlgorithm
{
    internal class TieRopes : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - TieRopes");

            const int K = 4;
            var A = new[] {1, 2, 3, 4, 1, 1, 3};

            var result = solution(K, A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int K, int[] A)
        {
            var result = 0;

            var sum = 0;
            foreach (var item in A)
            {
                sum += item;
                if (sum >= K)
                {
                    sum = 0;
                    result++;
                }
            }
            return result;
        }
    }
}