using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.Sorting
{
    internal class Distinct : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - Distinct");

            var A = new[] {2, 1, 1, 2, 3, 1};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            return new HashSet<int>(A).Count;
        }
    }
}