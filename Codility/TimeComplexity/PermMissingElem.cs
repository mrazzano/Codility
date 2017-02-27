using System;
using Codility.Library;

namespace Codility.TimeComplexity
{
    internal class PermMissingElem : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - PermMissingElem");

            var A = new[] {2, 3, 1, 5};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            long length = A.Length + 1;
            var total = length*(length + 1)/2;

            foreach (var i in A)
                total -= i;

            return (int) total;
        }
    }
}