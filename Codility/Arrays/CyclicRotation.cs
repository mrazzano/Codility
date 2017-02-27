using System;
using Codility.Library;

namespace Codility.Arrays
{
    public class CyclicRotation : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - CyclicRotation");

            const int N = 3;
            var A = new[] {3, 8, 9, 7, 6};

            var result = solution(A, N);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(int[] A, int N)
        {
            var length = A.Length;
            if (length <= 0)
                return A;

            N = N%length;

            Array.Reverse(A);
            Array.Reverse(A, 0, N);
            Array.Reverse(A, N, length - N);
            return A;
        }
    }
}