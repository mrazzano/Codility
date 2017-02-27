using System;
using System.Diagnostics;
using System.Collections.Generic;
using Codility.Library;

namespace Codility
{
    class Program
    {
        static void Main()
        {
            const string header = "Solutions for Codility exercises Lessons 1 - 17.";

            // write program header
            Console.WriteLine(Utility.GetProgramHeader(header, new DateTime(2017, 2, 20)));

            // start program timer
            var timer = new Stopwatch();
            timer.Start();

            // execute all modules
            RunIterationQuestions();
            RunArrayQuestions();
            RunTimeComplexityQuestions();
            RunCountingElementsQuestions();
            RunPrefixSumQuestions();
            RunSortingQuestions();
            RunStacksAndQueuesQuestions();
            RunLeaderQuestions();
            RunMaximumSliceQuestions();
            RunPrimeNumberQuestions();
            RunSieveOfEratosthenesQuestions();
            RunEuclideanAlgorithmQuestions();
            RunFibonacciNumbersQuestions();
            RunBinarySearchQuestions();
            RunCaterpillarMethodQuestions();
            RunGreedyAlgorithmQuestions();
            RunDynamicProgrammingQuestions();

            // stop timer
            timer.Stop();

            // write timer output
            Console.WriteLine("Program Execution: {0}ms", timer.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void RunIterationQuestions()
        {
            const string header = "Lesson 1:  Iterations";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.Iterations.BinaryGap()
            });
        }

        private static void RunArrayQuestions()
        {
            const string header = "Lesson 2:  Arrays";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.Arrays.OddOccurrencesInArray(),
                new Codility.Arrays.CyclicRotation()
            });
        }

        private static void RunTimeComplexityQuestions()
        {
            const string header = "Lesson 3:  Time Complexity";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.TimeComplexity.FrogJmp(),
                new Codility.TimeComplexity.PermMissingElem(),
                new Codility.TimeComplexity.TapeEquilibrium()
            });
        }

        private static void RunCountingElementsQuestions()
        {
            const string header = "Lesson 4:  Counting Elements";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.CountingElements.MissingInteger(),
                new Codility.CountingElements.PermCheck(),
                new Codility.CountingElements.FrogRiverOne(),
                new Codility.CountingElements.MaxCounters()
            });
        }

        static void RunPrefixSumQuestions()
        {
            const string header = "Lesson 5:  Prefix Sums";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.PrefixSums.CountDiv(),
                new Codility.PrefixSums.PassingCars(),
                new Codility.PrefixSums.GenomicRangeQuery(),
                new Codility.PrefixSums.MinAvgTwoSlice()
            });
        }

        static void RunSortingQuestions()
        {
            const string header = "Lesson 6:  Sorting";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.Sorting.Distinct(),
                new Codility.Sorting.MaxProductOfThree(),
                new Codility.Sorting.Triangle(),
                new Codility.Sorting.NumberOfDiscIntersections()
            });
        }

        static void RunStacksAndQueuesQuestions()
        {
            const string header = "Lesson 7:  Stacks and Queues";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.StacksAndQueues.Brackets(),
                new Codility.StacksAndQueues.StoneWall(),
                new Codility.StacksAndQueues.Fish(),
                new Codility.StacksAndQueues.Nesting()
            });
        }

        static void RunLeaderQuestions()
        {
            const string header = "Lesson 8:  Leader";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.Leader.Dominator(),
                new Codility.Leader.EquiLeader()
            });
        }

        static void RunMaximumSliceQuestions()
        {
            const string header = "Lesson 9:  Maximum Slice Problem";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.MaximumSlice.MaxDoubleSliceSum(),
                new Codility.MaximumSlice.MaxProfit(),
                new Codility.MaximumSlice.MaxSliceSum()
            });
        }

        static void RunPrimeNumberQuestions()
        {
            const string header = "Lesson 10:  Prime and Composite Numbers";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.PrimeAndCompositeNumbers.CountFactors(),
                new Codility.PrimeAndCompositeNumbers.MinPerimeterRectangle(),
                new Codility.PrimeAndCompositeNumbers.Peaks(),
                new Codility.PrimeAndCompositeNumbers.Flags()
            });
        }

        static void RunSieveOfEratosthenesQuestions()
        {
            const string header = "Lesson 11:  Sieve Of Eratosthenes";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.SieveOfEratosthenes.CountSemiprimes(),
                new Codility.SieveOfEratosthenes.CountNonDivisible()
            });
        }

        static void RunEuclideanAlgorithmQuestions()
        {
            const string header = "Lesson 12:  Euclidean Algorithm";
            RunQuestions(header, new List<IQuestion>()
            {                
                new Codility.EuclideanAlgorithm.ChocolatesByNumbers(),
                new Codility.EuclideanAlgorithm.CommonPrimeDivisors()
            });
        }

        static void RunFibonacciNumbersQuestions()
        {
            const string header = "Lesson 13:  Fibonacci Numbers";
            RunQuestions(header, new List<IQuestion>()
            {                
                new Codility.FibonacciNumbers.Ladder(),
                new Codility.FibonacciNumbers.FibFrog()
            });
        }

        static void RunBinarySearchQuestions()
        {
            const string header = "Lesson 14:  Binary Search Algoritm";
            RunQuestions(header, new List<IQuestion>()
            {                
                new Codility.BinarySearch.NailingPlanks(),
                new Codility.BinarySearch.MinMaxDivision()
            });
        }

        static void RunCaterpillarMethodQuestions()
        {
            const string header = "Lesson 15:  Caterpillar Method";
            RunQuestions(header, new List<IQuestion>()
            {                
                new Codility.CaterpillarMethod.AbsDistinct(),
                new Codility.CaterpillarMethod.CountDistinctSlices(),
                new Codility.CaterpillarMethod.CountTriangles(),
                new Codility.CaterpillarMethod.MinAbsSumOfTwo()
            });
        }

        static void RunGreedyAlgorithmQuestions()
        {
            const string header = "Lesson 16:  Greedy Algorithms";
            RunQuestions(header, new List<IQuestion>()
            {                
                new Codility.GreedyAlgorithm.TieRopes(),
                new Codility.GreedyAlgorithm.MaxNonoverlappingSegments()
            });
        }

        static void RunDynamicProgrammingQuestions()
        {
            const string header = "Lesson 17:  Dynamic Programming";
            RunQuestions(header, new List<IQuestion>()
            {
                new Codility.DynamicProgramming.NumberSolitaire(),
                new Codility.DynamicProgramming.MinAbsSum()
            });
        }

        private static void RunQuestions(string header, IEnumerable<IQuestion> questions)
        {
            Console.WriteLine(Utility.GetLessonHeader(header));
            foreach (var question in questions)
            {
                question.Run();
            }
        }
    }
}
