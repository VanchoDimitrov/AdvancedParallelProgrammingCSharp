using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _9_DataParallelismParallelForThreadLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i = 0; i <= 10000; i++)
            {
                nums.Add(i);
            }

            int refSum = 0;

            Parallel.For<int>(0, nums.Count, () => 0, (i, loop, sum) =>
            {
                sum += nums[i];
                return sum;
            },
                (x) => Interlocked.Add(ref refSum, x)
                );

            Console.WriteLine("The SUM is {0:N0}", refSum);
        }
    }
}
