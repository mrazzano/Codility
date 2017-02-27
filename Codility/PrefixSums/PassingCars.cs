using System;
using Codility.Library;

namespace Codility.PrefixSums
{
    internal class PassingCars : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - PassingCars");

            var A = new[] {0, 1, 0, 1, 1};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var west = 0;
            var result = 0;
            foreach (var item in A)
            {
                if (item == 0)
                {
                    west++;
                }
                else
                {
                    result += west;
                }

                if (result > 1000000000)
                    return -1;
            }

            return result;
        }
    }
}