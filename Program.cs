using System;
using System.Diagnostics;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CountTime(BubbleSort.BubbleSorting);
            //CountTime(InsertionSort.InsertionSorting);
            CountTime(ShellSort.ShellSorting);
        }
        static int[] CreateTestData(int amount)
        {
            var array = new int[amount];
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(0, array.Length);
            }
            return array;
        }
        static void CountTime(Action<int[]> sortMethod)
        {
            Stopwatch clock = new Stopwatch();
            for (int N = 10; N <= 10_000; N *= 10)
            {
                var testArray = CreateTestData(N);
                clock.Start();
                sortMethod(testArray);
                clock.Stop();
                Console.WriteLine($"{N} -{sortMethod.Method.Name} {clock.ElapsedMilliseconds} ms");
            }
        }
    }
}
