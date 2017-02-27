using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.StacksAndQueues
{
    internal class Brackets : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 1 - Brackets");

            const string S = "{[()()]}";

            var result = solution(S);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(string S)
        {
            if (S.Length > 200000)
                throw new ArgumentOutOfRangeException(S);

            if (String.IsNullOrEmpty(S))
                return 1;

            var stack = new Stack<char>(S.Length);
            foreach (var value in S)
            {
                switch (value)
                {
                    case '{':
                    case '[':
                    case '(':
                        stack.Push(value);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                            return 0;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                            return 0;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(')
                            return 0;
                        break;
                    default:
                        return 0;
                }
            }
            return stack.Count != 0 ? 0 : 1;
        }
    }
}