using System;
using Codility.Library;

namespace Codility.CountingElements
{
    internal class MaxCounters : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - MaxCounters");

            const int N = 5;
            var A = new[] {3, 4, 4, 6, 1, 4, 4};

            var result = solution(N, A);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(int N, int[] A)
        {
            var maximum = 0;
            var resetLimit = 0;
            var result = new int[N];

            foreach (var item in A)
            {
                if (item >= 1 && item <= N)
                {
                    if (result[item - 1] < resetLimit)
                    {
                        result[item - 1] = resetLimit + 1;
                    }
                    else
                    {
                        result[item - 1]++;
                    }

                    if (result[item - 1] > maximum)
                    {
                        maximum = result[item - 1];
                    }
                }
                else
                {
                    resetLimit = maximum;
                }
            }

            for (var i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;
        }
    }
}