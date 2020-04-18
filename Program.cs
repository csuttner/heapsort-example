using System;

namespace heapsort_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining an array to be sorted
            int[] values = new int[] { 23, 201, 59, 10, 5, 74, 36 };

            HeapSorterConsoleWalkthrough.HeapSort(values);

            //HeapSortTest.Run();

        }
    }
}
