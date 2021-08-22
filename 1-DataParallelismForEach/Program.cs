using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _1_DataParallelismForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){1,4,6,7,9,0,2,3,5,8};

            // Sequential printing or looping of the collection items
            foreach(var i in numbers){
                Console.Write(i);
            }

            Parallel.ForEach(numbers,i=>Console.WriteLine(i));
        }
    }
}
