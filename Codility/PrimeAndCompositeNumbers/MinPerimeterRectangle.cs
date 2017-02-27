using System;
using Codility.Library;

namespace Codility.PrimeAndCompositeNumbers
{
    public class MinPerimeterRectangle : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - MinPerimeterRectangle");

            const int N = 30;

            var result = solution(N);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int N)
        {
            var i = 1;
            var result = Int32.MaxValue;
            while (i*i < N)
            {
                if (N%i == 0)
                {
                    result = Math.Min(result, 2*(i + N/i));
                }
                i++;
            }

            if (i*i == N)
                result = Math.Min(result, 2*(i + N/i));

            return result;
        }
    }
}