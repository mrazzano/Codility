using System;
using Codility.Library;

namespace Codility.FibonacciNumbers
{
    public class Ladder : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - Ladder");

            var A = new[] {4, 4, 5, 5, 1};
            var B = new[] {3, 2, 4, 3, 1};

            var result = solution(A, B);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(int[] A, int[] B)
        {
            var max = 0;
            foreach (var item in A)
            {
                max = Math.Max(item, max);
            }

            max += 2;
            var fib = new double[max];

            fib[0] = 1;
            fib[1] = 1;
            for (var i = 2; i < max; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2]%(1 << 30);
            }

            var result = new int[A.Length];
            for (var i = 0; i < A.Length; i++)
            {
                result[i] = (int) (fib[A[i]]%(1 << B[i]));
            }

            return result;
        }
    }
}