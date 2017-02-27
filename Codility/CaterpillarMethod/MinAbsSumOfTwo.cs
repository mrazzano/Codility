using System;
using Codility.Library;

namespace Codility.CaterpillarMethod
{
    internal class MinAbsSumOfTwo : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - MinAbsSumOfTwo");

            var A = new[] {1, 4, -3};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var head = 0;
            var tail = A.Length - 1;

            Array.Sort(A);

            var result = Int32.MaxValue;
            while (head <= tail)
            {
                result = Math.Min(result, Math.Abs(A[head] + A[tail]));
                if (Math.Abs(A[head]) > Math.Abs(A[tail]))
                {
                    head++;
                }
                else
                {
                    tail--;
                }
            }
            return result;
        }
    }
}