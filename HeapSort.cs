using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class HeapSort
    {
        public static void HeapSorting(int[] array)
        {
            var length = array.Length;
            for (var i = length / 2 - 1; i >= 0; i--)
                Heapify(array, length, i);

            for (var i = length - 1; i > 0; i--)
            {
                var temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
            //printArray(array);
        }

        public static void Heapify(int[] arr, int length, int i)
        {
            var largest = i;
            var leftBranch = 2 * i + 1;
            var rightBranch = 2 * i + 2; 

            if (leftBranch < length && arr[leftBranch] > arr[largest])
                largest = leftBranch;

            if (rightBranch < length && arr[rightBranch] > arr[largest])
                largest = rightBranch;

            if (largest != i)
            {
                var swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, length, largest);
            }
        }
        static void printArray(int[] arr)
        {
            var n = arr.Length;
            for (var i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
