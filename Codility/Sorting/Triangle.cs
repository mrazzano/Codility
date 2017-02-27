using System;
using Codility.Library;

namespace Codility.Sorting
{
    internal class Triangle : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - Triangle");

            var A = new[] {10, 2, 5, 1, 8, 20};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] input)
        {
            if (input.Length < 3)
                return 0;

            Array.Sort(input);
            for (var i = 0; i < input.Length - 2; i++)
            {
                // be mindful of overflow potential
                if (input[i] >= 0 && input[i] > input[i + 2] - input[i + 1])
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}