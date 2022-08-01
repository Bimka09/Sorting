using System;

namespace Sorting
{
    public static class BubbleSort
    {
        public static void BubbleSorting(int [] array)
        {
            int length = array.Length;
            for(int i = 0; i < length - 1; i++)
            {
                for(int j = 0; j < length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
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
