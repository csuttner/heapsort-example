using System;

namespace heapsort_example
{
    // Version of code with console output guide
    // Code modified from Geeks for Geeks and HackerRank examples
    public class HeapSorterConsoleWalkthrough
    {
        public static void HeapSort(int[] items)
        {
            int n = items.Length;

            // Print initial array and tree representation
            Console.WriteLine("Initial array:");
            Printer.PrintArray(items);
            Console.WriteLine("Inital tree representation:");
            Printer.PrintTree(items, items.Length);
            Console.WriteLine("Press enter/return to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            // Build heap, can start halfway through array working to front
            // since back half of the array won't have children anyways 
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("building initial heap...");
                Heapify(items, n, i);
            }

            Console.WriteLine("Max heap built:");
            Printer.PrintTree(items, items.Length);
            Console.WriteLine("Press enter/return to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            // Swap root (max value) with last item in subarray, shrink this
            // array by 1, rebuild heap, repeat 
            for (int i = n - 1; i > 0; i--)
            {
                // Swap root with end
                int temp = items[0];
                items[0] = items[i];
                items[i] = temp;

                Console.WriteLine("Dequeued largest value, {0}, swapped with {1}", temp, items[0]);
                Console.WriteLine("Array as of now:");
                Printer.PrintArray(items);
                Console.WriteLine("Heap size reduced:");
                Printer.PrintTree(items, i);
                Console.WriteLine("Press enter/return to continue...");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                // Rebuild heap
                Heapify(items, i, 0);
            }

            Console.WriteLine("Sort complete:");
            Printer.PrintArray(items);

        }

        // Heapify a subtree rooted with node root - an index in items.
        private static void Heapify(int[] items, int size, int root)
        {
            Console.WriteLine("Called Heapify on root {0}, heap size {1}", root, size);

            // start at root
            int index = root;
            int leftIndex = (index * 2) + 1;
            int rightIndex = (index * 2) + 2;

            // while the given index has a left child
            while (leftIndex < size)
            {
                // set largest child index to left child by default
                int largestChildIndex = leftIndex;

                // if the right child exists and is larger, set largest to that
                if (rightIndex < size && items[rightIndex] > items[leftIndex])
                    largestChildIndex = rightIndex;

                // if the given item is greater than it's largest child,
                // we can stop looping
                if (items[index] > items[largestChildIndex])
                {
                    break;
                }
                else
                {
                    // swap the two
                    int temp = items[index];
                    items[index] = items[largestChildIndex];
                    items[largestChildIndex] = temp;

                    Console.WriteLine("Swapped {0} with {1}", temp, items[index]);

                    // increment the index down the heap
                    index = largestChildIndex;
                    leftIndex = (index * 2) + 1;
                    rightIndex = (index * 2) + 2;
                }
            }

            Console.WriteLine();
        }
    }
}
