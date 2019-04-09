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

            Parallel.For(0, 40, options, i =>
            {
                Thread.Sleep(1 * 1000);
                var rand = new Random().Next();

                Console.WriteLine(HeavyComputation(rand));
            });
        }

        private static int HeavyComputation(int InputNumber)
        {
            Thread.Sleep(3 * 1000);
            return 42;
        }
    }
}