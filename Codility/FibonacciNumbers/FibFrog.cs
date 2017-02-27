using System;
using System.Collections.Generic;
using Codility.Library;

namespace Codility.FibonacciNumbers
{
    public class FibFrog : IQuestion
    {
        public void Run()
        {
            Console.WriteLine("Question 2 - FibFrog");

            var A = new[] {0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0};

            var result = solution(A);

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine();
        }

        private static int solution(int[] A)
        {
            var length = A.Length;
            if (length <= 2)
                return 1;

            var fib = new List<int> {1, 1};

            for (var i = 2; i < length; i++)
            {
                var number = fib[i - 1] + fib[i - 2];
                fib.Add(number);
                if (number > length)
                    break;
            }

            fib.Reverse();

            var index = 0;
            var queue = new List<Point> {new Point(-1, 0)};
            while (true)
            {
                if (index == queue.Count)
                    return -1;

                var current = queue[index];
                foreach (var item in fib)
                {
                    var next = item + current.X;
                    if (next == length)
                    {
                        return current.Y + 1;
                    }
                    if ((next > length) || next < 0
                        || (A[next] == 0))
                    {
                        continue;
                    }

                    queue.Add(new Point(next, current.Y + 1));
                    A[next] = 0;
                }

                index++;
            }
        }

        internal class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}