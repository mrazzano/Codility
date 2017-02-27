using System;
using Codility.Library;

namespace Codility.EuclideanAlgorithm
{
    public class CommonPrimeDivisors : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - CommonPrimeDivisors");

            var A = new[] {15, 10, 3};
            var B = new[] {75, 30, 5};

            var result = solution(A, B);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A, int[] B)
        {
            var result = 0;
            var length = A.Length;
            for (var i = 0; i < length; i++)
            {
                var a = A[i];
                var b = B[i];

                var temp = 0;
                var divisor = gcd(a, b);

                while (temp != 1)
                {
                    temp = gcd(a, divisor);
                    a /= temp;
                }

                temp = 0;
                while (temp != 1)
                {
                    temp = gcd(b, divisor);
                    b /= temp;
                }

                if (a == 1 && b == 1)
                    result++;
            }
            return result;
        }

        private static int gcd(int a, int b)
        {
            return (a%b) == 0 ? b : gcd(b, a%b);
        }
    }
}