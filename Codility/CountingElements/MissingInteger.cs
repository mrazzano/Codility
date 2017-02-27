using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.CountingElements
{
    internal class MissingInteger : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - MissingInteger");

            var A = new[] {1, 3, 6, 4, 1, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var result = 1;
            var hash = new HashSet<int>(A);
            while (hash.Contains(result))
                result++;

            return result;
        }
    }
}