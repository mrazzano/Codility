using System;
using Codility.Library;

namespace Codility.CaterpillarMethod
{
    internal class CountTriangles : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - CountTriangles");

            var A = new[] {10, 2, 5, 1, 8, 12};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var result = 0;
            var length = A.Length;

            Array.Sort(A);
            for (var i = 0; i < length; i++)
            {
                var k = i + 2;
                for (var j = i + 1; j < length; j++)
                {
                    while (k < length && A[i] + A[j] > A[k] && A[j] + A[k] > A[i] && A[i] + A[k] > A[j])
                    {
                        k++;
                    }

                    result += k - j - 1;
                }
            }

            return result;
        }
    }
}