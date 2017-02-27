using System;
using System.Linq;
using Codility.Library;

namespace Codility.Arrays
{
    public class OddOccurrencesInArray : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - OddOccurrencesInArray");

            var A = new[] {9, 3, 9, 3, 9, 7, 9};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            return A.Aggregate(0, (current, i) => current ^ i);
        }
    }
}