using System;
using Codility.Library;

namespace Codility.DynamicProgramming
{
    internal class MinAbsSum : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MinAbsSum");

            var A = new[] {1, 5, -2, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var max = 0;
            var sum = 0;
            for (var i = 0; i < A.Length; i++)
            {
                A[i] = Math.Abs(A[i]);
                max = Math.Max(max, A[i]);
                sum += A[i];
            }

            var counts = new int[max + 1];
            foreach (var number in A)
            {
                counts[number]++;
            }

            var reaches = new bool[sum/2 + 1];
            reaches[0] = true;
            for (var i = 1; i < counts.Length; i++)
            {
                if (counts[i] == 0)
                {
                    continue;
                }

                var remains = new int[reaches.Length];
                for (var j = 0; j < remains.Length; j++)
                {
                    remains[j] = reaches[j] ? counts[i] : -1;
                }

                for (var j = 0; j + i < remains.Length; j++)
                {
                    if (remains[j] > 0)
                    {
                        remains[j + i] = Math.Max(remains[j + i], remains[j] - 1);
                    }
                }

                for (var j = 0; j < remains.Length; j++)
                {
                    if (remains[j] >= 0)
                    {
                        reaches[j] = true;
                    }
                }
            }

            for (var i = reaches.Length - 1;; i--)
            {
                if (reaches[i])
                {
                    return sum - i - i;
                }
            }
        }
    }
}