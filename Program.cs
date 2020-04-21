using System;

namespace heapsort_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining an array to be sorted
            int[] values = new int[] { 23, 201, 59, 10, 5, 74, 36 };

            //Random random = new Random();
            //int[] randomArray;

            //randomArray = new int[31];

            //for (int j = 0; j < 31; j++)
            //    randomArray[j] = random.Next(0, 999);

            HeapSorterConsoleWalkthrough.HeapSort(values);

            //HeapSortTest.Run();

        }
    }
}
