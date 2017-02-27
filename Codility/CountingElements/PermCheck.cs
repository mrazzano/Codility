using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.CountingElements
{
    internal class PermCheck : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - PermCheck");

            var A = new[] {4, 1, 3, 2};

            var result = DoWork(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int DoWork(int[] input)
        {
            var result = 1;
            var hash = new HashSet<int>(input);
            while (hash.Contains(result))
                result++;

            return result == input.Length + 1 ? 1 : 0;
        }
    }
}