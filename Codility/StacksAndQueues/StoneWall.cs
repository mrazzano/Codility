using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.StacksAndQueues
{
    internal class StoneWall : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - StoneWall");

            var A = new[] {8, 8, 5, 7, 9, 8, 7, 4, 8};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var result = 0;
            var stack = new Stack<int>();

            foreach (var item in A)
            {
                while (stack.Count > 0 && stack.Peek() > item)
                    stack.Pop();

                if (stack.Count == 0 || stack.Peek() < item)
                {
                    stack.Push(item);
                    result++;
                }
            }
            return result;
        }
    }
}