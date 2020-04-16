using System;

namespace heapsort_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining an array to be sorted
            int[] values = new int[] { 12, 34, 2, 87, 90, 16, 45, 0 };

            HeapSorter.HeapSort(values);

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
