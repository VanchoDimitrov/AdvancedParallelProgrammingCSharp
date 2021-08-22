using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _5_DataParallelism_StaticRangePartitioningForParallel.ForEach
{
    class Program
    {
        public static object Paralel { get; private set; }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 6, 7, 9, 0, 2, 3, 5, 8 };

            // Partitioning of the array
            var rangePartitioner = Partitioner.Create(0, numbers.Length);

            // Paritions looping in parallel
            Parallel.ForEach(rangePartitioner, (range, loopState) =>
            {
                // Loopt through each element. No delegate invocation.
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            });

        }
    }
}
