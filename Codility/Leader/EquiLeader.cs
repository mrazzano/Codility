using System;
using Codility.Library;

namespace Codility.Leader
{
    internal class EquiLeader : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - EquiLeader");

            var A = new[] {4, 3, 4, 4, 4, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            if (length == 0)
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

            var total = 0;
            for (var i = 0; i < length; i++)
            {
                if (A[i] == candidate)
                {
                    total++;
                }
            }

            var result = 0;
            var leaders = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] == candidate)
                    leaders++;

                var leadersInRightPart = (total - leaders);
                if (leaders > (i + 1)/2 && leadersInRightPart > (length - i - 1)/2)
                {
                    result++;
                }
            }
            return result;
        }
    }
}