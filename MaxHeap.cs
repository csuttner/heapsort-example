using System;
namespace heapsort_example
{
    public class MaxHeap
    {
        private int[] values;

        MaxHeap(int[] values)
        {
            this.values = values;
        }

        // Swap helper method
        private void Swap(int index1, int index2)
        {
            int temp = values[index1];
            values[index1] = values[index2];
            values[index2] = temp;
        }

        // Index getters
        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private int GetLeftChildIndex(int index)
        {
            return (index * 2) + 1;
        }

        private int GetRightChildIndex(int index)
        {
            return (index * 2) + 2;
        }

        // Value getters
        private int GetParentValue(int index)
        {
            return values[GetParentIndex(index)];
        }

        private int GetLeftChildValue(int index)
        {
            return values[GetLeftChildIndex(index)];
        }

        private int GetRightChildValue(int index)
        {
            return values[GetRightChildIndex(index)];
        }

        // Relationship checks
        private bool HasParent(int index)
        {
            return index != 0;
        }

        private bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) < values.Length;
        }

        private bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) < values.Length;
        }

        // Print methods
        public void PrintValuesAndRelationships()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("value: {0} at index {1}", values[i], i);

                if (HasParent(i))
                    Console.WriteLine("parent: {0} at index {1}", GetParentValue(i), GetParentIndex(i));
                else
                    Console.WriteLine("parent: none");

                if (HasLeftChild(i))
                    Console.WriteLine("left: {0} at index {1}", GetLeftChildValue(i), GetLeftChildIndex(i));
                else
                    Console.WriteLine("left: none");

                if (HasRightChild(i))
                    Console.WriteLine("right: {0} at index {1}", GetRightChildValue(i), GetRightChildIndex(i));
                else
                    Console.WriteLine("right: none");

                Console.WriteLine();
            }
        }

        public void PrintValues()
        {
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
