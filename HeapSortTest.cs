using System;
namespace heapsort_example
{
    public class HeapSortTest
    {
        public static void Run()
        {
            Random random = new Random();
            int[] randomArray;

            for (int i = 0; i < 100; i++)
            {
                randomArray = new int[i];

                for (int j = 0; j < i; j++)
                    randomArray[j] = random.Next(0, 100);

                HeapSorter.HeapSort(randomArray);

                for (int j = 1; j < i; j++)
                {
                    if (randomArray[j - 1] > randomArray[j])
                    {
                        Console.WriteLine("test failed:");
                        foreach (int value in randomArray)
                        {
                            Console.WriteLine(value);
                        }
                        break;
                    }
                }

                Console.WriteLine("test passed");
            }
        }
    }
}
