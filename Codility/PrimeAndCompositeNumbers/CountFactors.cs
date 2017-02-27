using System;
using Codility.Library;

namespace Codility.PrimeAndCompositeNumbers
{
    public class CountFactors : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - CountFactors");

            const int N = 24;

            var result = solution(N);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int N)
        {
            long i = 1;
            var result = 0;
            while (i*i < N)
            {
                if (N%i == 0)
                    result += 2;

                i++;
            }

            if (i*i == N)
                result += 1;

            return result;
        }
    }
}