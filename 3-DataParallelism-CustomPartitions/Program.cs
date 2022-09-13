using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _2_DataParallelism_CustomPartitions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 4, 6, 7, 9, 0, 2, 3, 5, 8 };

            // Load balancing partitioner
            // false or true for the static partitioning
            Partitioner<int> partitioner = Partitioner.Create(numbers, true);

            // Linq query
            var query = from i in partitioner.AsParallel() select i;

            // Loop throught the partitioner and get the data.
            // Data will not be in order
            query.ForAll((i)=>Console.Write(i));

        }
    }
}
