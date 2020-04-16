using System;

namespace heapsort_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining an array to be sorted
            int[] values = new int[] { 10, 20, 15, 17, 9, 21 };//{ 12, 34, 2, 87, 90, 16, 45, 0 };

            Console.WriteLine("Before Heapsort");
            foreach (int value in values)
            {
                Console.Write(value + " ");
            }

            HeapSorter.HeapSort(values);

            Console.WriteLine("\nAfter Heapsort");
            foreach (int value in values)
            {
                Console.Write(value + " ");
            }
        }
    }
}
