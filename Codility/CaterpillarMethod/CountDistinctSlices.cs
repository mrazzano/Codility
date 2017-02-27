using System;
using Codility.Library;

namespace Codility.CaterpillarMethod
{
    internal class CountDistinctSlices : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - CountDistinctSlices");

            const int M = 5;
            var A = new[] {3, 4, 5, 5, 2};

            var result = solution(M, A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int M, int[] A)
        {
            const int max = 1000000000;

            var head = 0;
            var tail = 0;
            var length = A.Length;
            var counters = new int[M + 1];

            var result = 0;
            while (tail < length)
            {
                while (head < length && counters[A[head]] != 2)
                {
                    counters[A[head]]++;
                    if (counters[A[head]] == 2)
                        break;

                    head++;
                }

                result += head - tail;
                if (result > max)
                    return max;

                counters[A[tail]] = 0;
                tail++;
            }

            return result;
        }
    }
}