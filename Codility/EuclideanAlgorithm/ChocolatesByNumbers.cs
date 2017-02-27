using System;
using Codility.Library;

namespace Codility.EuclideanAlgorithm
{
    public class ChocolatesByNumbers : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - ChocolatesByNumbers");

            const int M = 4;
            const int N = 10;

            var result = solution(N, M);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int N, int M)
        {
            return N/gcd(N, M);
        }

        private static int gcd(int a, int b)
        {
            return (a%b) == 0 ? b : gcd(b, a%b);
        }
    }
}