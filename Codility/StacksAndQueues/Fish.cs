using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.StacksAndQueues
{
    internal class Fish : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 3 - Fish");

            var A = new[] {4, 3, 2, 1, 5};
            var B = new[] {0, 1, 0, 0, 0};

            var result = solution(A, B);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A, int[] B)
        {
            var result = 0;
            var stack = new Stack<int>();

            for (var i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    stack.Push(A[i]);
                }
                else
                {
                    while (stack.Count != 0)
                    {
                        var fish = stack.Peek();
                        if (fish < A[i])
                        {
                            stack.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if (stack.Count == 0)
                    result++;
            }
            return result + stack.Count;
        }
    }
}