using System;
using Codility.Library;

namespace Codility.Sorting
{
    internal class NumberOfDiscIntersections : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - NumberOfDiscIntersections");

            var A = new[] {1, 5, 2, 1, 4, 0};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] input)
        {
            var result = 0;
            var upper = new long[input.Length];
            var lower = new long[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                lower[i] = (long) i - input[i];
                upper[i] = (long) i + input[i];
            }

            Array.Sort(lower);
            Array.Sort(upper);

            var j = 0;
            for (var i = 0; i < input.Length; i++)
            {
                while (j < input.Length && upper[i] >= lower[j])
                {
                    result += j - i;
                    j++;
                }
                if (result > 10000000) return -1;
            }

            return result;
        }
    }
}