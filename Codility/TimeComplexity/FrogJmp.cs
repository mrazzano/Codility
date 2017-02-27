using System;
using Codility.Library;

namespace Codility.TimeComplexity
{
    internal class FrogJmp : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - FrogJmp");

            const int X = 10;
            const int Y = 85;
            const int D = 30;

            var result = solution(X, Y, D);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int X, int Y, int D)
        {
            var result = (Y - X)/D;
            if ((Y - X)%D > 0)
                result++;

            return result;
        }
    }
}