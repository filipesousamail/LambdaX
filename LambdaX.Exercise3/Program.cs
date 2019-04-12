using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 10;

            Parallel.For(1, 10, options, i =>
            {
                Console.WriteLine(HeavyComputation(i));
            });

        }

        private static int HeavyComputation(int InputNumber)
        {
            var rand = new Random().Next(10);
            Thread.Sleep(rand * 1000);
            return InputNumber;
        }
    }
}