using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.StacksAndQueues
{
    internal class Nesting : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 4 - Nesting");

            const string S = "(()(())())";

            var result = solution(S);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(string S)
        {
            var stack = new Stack<char>();
            foreach (var item in S)
            {
                switch (item)
                {
                    case '(':
                        stack.Push(item);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return 0;
                        break;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}