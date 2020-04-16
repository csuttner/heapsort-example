using System;
namespace heapsort_example
{

    // Code elements borrowed from:
    // https://www.geeksforgeeks.org/iterative-heap-sort/

    public class HeapSorter
    {
        public static void HeapSort(int[] array)
        {
            Heapify(array);

            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                int j = 0, index;

                do
                {
                    index = (j * 2) + 1;

                    if (index < (i - 1) && array[index] < array[index + 1])
                        index++;

                    if (index < i && array[j] < array[index])
                        Swap(array, j, index);

                    j = index;

                } while (index < i);
            }

        }

        private static void Heapify(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                // If child is bigger than parent
                if (array[i] > array[(i - 1) / 2])
                {
                    int j = i;

                    // Swap child and parent until parent is smaller
                    while (array[i] < array[(j - 1) / 2])
                    {
                        Swap(array, j, (j - 1) / 2);
                        j = (j - 1) / 2;
                    }
                }
            }
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

    }
}
