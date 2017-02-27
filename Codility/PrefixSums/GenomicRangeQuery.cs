using System;
using Codility.Library;

namespace Codility.PrefixSums
{
    internal class GenomicRangeQuery : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - GenomicRangeQuery");

            const string S = "CAGCCTA";
            var P = new[] {2, 5, 0};
            var Q = new[] {4, 5, 6};

            var result = solution(S, P, Q);

            Console.WriteLine("Result: {0}", Utility.GetPrintArray(result));
            Console.WriteLine();
        }

        private static int[] solution(string S, int[] P, int[] Q)
        {
            const int numberOfNucleotides = 4;

            var nucleotides = new int[numberOfNucleotides, S.Length];
            for (var i = 0; i < S.Length; i++)
            {
                var ch = S[i];
                switch (ch)
                {
                    case 'A':
                        nucleotides[0, i]++;
                        break;
                    case 'C':
                        nucleotides[1, i]++;
                        break;
                    case 'G':
                        nucleotides[2, i]++;
                        break;
                    case 'T':
                        nucleotides[3, i]++;
                        break;
                }
            }

            var prefixSum = new int[numberOfNucleotides, S.Length + 1];
            for (var k = 1; k < S.Length + 1; k++)
            {
                for (var j = 0; j < numberOfNucleotides; j++)
                {
                    prefixSum[j, k] = prefixSum[j, k - 1] + nucleotides[j, k - 1];
                }
            }

            var result = new int[P.Length];
            for (var i = 0; i < P.Length; i++)
            {
                var x = P[i];
                var y = Q[i];
                for (var j = 0; j < numberOfNucleotides; j++)
                {
                    if (prefixSum[j, y + 1] - prefixSum[j, x] > 0)
                    {
                        result[i] = j + 1;
                        break;
                    }
                }
            }

            return result;
        }
    }
}