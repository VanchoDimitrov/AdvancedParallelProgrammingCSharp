using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _7_DataParallelism_ParallelFor.For
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 6, 7, 9, 0, 2, 3, 5, 8 };

            Parallel.For(0, numbers.Length, i => Console.Write(i));


            string[] cities = { "New York", "Dublin", "London", "Munich", "Madrid" };

            Parallel.For(0, cities.Length, i => Console.WriteLine(cities[i]));

            var citiesCollection = new List<string> { "New York", "Dublin", "London", "Munich", "Madrid" };

            Parallel.For(0, citiesCollection.Count, i =>
            {
                Console.WriteLine(citiesCollection[i]);

            });

        }
    }
}
