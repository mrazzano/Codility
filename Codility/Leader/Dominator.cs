using System;
using Codility.Library;

namespace Codility.Leader
{
    internal class Dominator : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - Dominator");

            var A = new[] {3, 4, 3, 2, 3, -1, 3, 3};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;

            var count = 0;
            var candidate = A[0];

            foreach (var item in A)
            {
                if (item == candidate)
                {
                    count++;
                }
                else
                {
                    if (count == 0)
                    {
                        count++;
                        candidate = item;
                    }
                    else
                    {
                        count--;
                    }
                }
            }

            count = 0;
            var index = -1;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                {
                    count++;
                    index = i;
                }
            }

            if (count > A.Length/2)
                return index;

            return -1;
        }
    }
}