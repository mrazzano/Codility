using System;
using System.Linq;
using Codility.Library;

namespace Codility.Iterations
{
    internal class BinaryGap : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - BinaryGap");

            const int N = 1041;

            var result = solution(N);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int N)
        {
            return Convert
                .ToString(N, 2)
                .Trim('0')
                .Split('1')
                .Max(x => x.Length);
        }
    }
}