using System;
using Codility.Library;

namespace Codility.Sorting
{
    internal class MaxProductOfThree : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MaxProductOfThree");

            var A = new[] {-3, 1, 2, -2, 5, 6};

            var result = solutin(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solutin(int[] A)
        {
            Array.Sort(A);

            var length = A.Length;
            var upper = A[length - 1]*A[length - 2]*A[length - 3];

            if (A[0] < 0 && A[1] < 0)
            {
                var lower = A[0]*A[1]*A[length - 1];
                if (lower > upper)
                    return lower;
            }

            return upper;
        }
    }
}