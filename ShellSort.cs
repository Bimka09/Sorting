using System;

namespace Sorting
{
    public class ShellSort
    {
        public static void ShellSorting(int[] array)
        {
            int length = array.Length;
            for (int gap = length / 2; gap > 0; gap /= 2)
            {
                for(int offcet = gap; offcet < length; offcet++)
                {
                    for(int j = offcet; j >= gap && array[j - gap] > array[j]; j-= gap)
                    {
                        int element = array[j - gap];
                        array[j - gap] = array[j];
                        array[j] = element;
                    }
                }
            }
            printArray(array);
        }
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

       
    }
}
