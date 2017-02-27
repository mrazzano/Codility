using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Flags : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - Flags");

            var A = new[] {1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            var peaks = new List<int>();
            for (var i = 1; i < length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            var peaksFound = peaks.Count;
            if (peaksFound < 2)
                return peaksFound;

            var maxFlags = peaks.Count;
            var minFlags = 1;
            var result = 0;
            while (maxFlags >= minFlags)
            {
                // binary search
                var flags = (minFlags + maxFlags)/2;
                if (CheckFlags(flags, peaks))
                {
                    result = flags;
                    minFlags = flags + 1;
                }
                else
                {
                    maxFlags = flags - 1;
                }
            }
            return result;
        }

        private static bool CheckFlags(int flagsCount, List<int> flags)
        {
            var i = 1;
            var lastFlag = flags[0];
            var actualFlags = flagsCount - 1;
            while (actualFlags > 0 && i < flags.Count)
            {
                if (flags[i] - lastFlag >= flagsCount)
                {
                    actualFlags--;
                    lastFlag = flags[i];
                }

                i++;
            }
            return actualFlags == 0;
        }
    }
}