using System;
using Codility.Library;

namespace Codility.CountingElements
{
    internal class FrogRiverOne : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - FrogRiverOne");

            const int X = 5;
            var A = new[] {1, 3, 1, 4, 2, 3, 5, 4};

            var result = solution(X, A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int X, int[] A)
        {
            var counter = 0;
            var positions = new bool[X];

            for (var i = 0; i < A.Length; i++)
            {
                var item = A[i];
                if (item > X)
                    continue;

                if (positions[item - 1])
                    continue;

                positions[item - 1] = true;
                counter++;
                if (counter == X)
                    return i;
            }

            return -1;
        }
    }
}