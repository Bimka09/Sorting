using System;

namespace Sorting
{
    public static class InsertionSort
    {
        public static void InsertionSorting(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                int element = array[i];
                int iterIndex = i - 1;
                while (iterIndex >= 0 && element < array[iterIndex])
                {
                    array[iterIndex + 1] = array[iterIndex];
                    iterIndex--;
                }
                array[iterIndex + 1] = element;
            }
            //printArray(array);
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
