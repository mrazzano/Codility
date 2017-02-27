using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.CaterpillarMethod
{
    internal class AbsDistinct : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - AbsDistinct");

            var A = new[] {-5, -3, -1, 0, 3, 6};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            var hash = new HashSet<long>();
            foreach (var item in A)
            {
                hash.Add(Math.Abs((long) item));
            }

            return hash.Count;
        }
    }
}