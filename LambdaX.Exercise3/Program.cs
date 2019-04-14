using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            var tasks = new List<Task>();
            
            // creating 10 tasks with random delay
            for (int i = 0; i < 10; i++)
            {
                var index = i;
                var delay = new Random().Next(index * 1000);
                tasks.Add(Task.Delay(delay).ContinueWith(task =>
                        ShowCompletion($"task #{index + 1} - delayed {delay / 1000}s", stopwatch.Elapsed))
                );
            }

            // waiting for the tasks in completion order. outputting number of left tasks
            while (tasks.Count > 0)
            {
                var task = await Task.WhenAny(tasks);
                tasks.Remove(task);
                Console.WriteLine($"{tasks.Count} tasks left!");
            }
 
            stopwatch.Stop();
        }

        static void ShowCompletion(string name, TimeSpan time)
        {
            Console.WriteLine($"{name} completed after {time}");
        }
    }
}