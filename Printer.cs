using System;
using System.Text;

namespace heapsort_example
{
    public class Printer
    {
        // Helper method to print arrays
        public static void PrintArray(int[] items)
        {
            Console.Write("[");

            for (int i = 0; i < items.Length; i++)
            {
                if (i != items.Length - 1)
                {
                    Console.Write(" {0},", items[i]);
                }
                else
                {
                    Console.Write(" {0} ]\n\n", items[i]);
                }
            }
        }

        // visualize trees - works well if all values in tree are < 999
        public static void PrintTree(int[] items, int size)
        {
            //int count = items.Length;

            if (size == 0)
            {
                return;
            }

            int levels = (int)Math.Log2(size) + 1;
            int index = 0;
            int level = 0;
            int itemsInLevel;
            int lastIndexOfLevel;
            int numSpaces;
            int zeros = 3;

            StringBuilder output = new StringBuilder();

            while (level < levels)
            {
                itemsInLevel = (int)Math.Pow(2, level);
                lastIndexOfLevel = index + itemsInLevel;

                numSpaces = (int)Math.Pow(2, levels - level - 1) - 1;

                while (index < size && index < lastIndexOfLevel)
                {
                    output.Append(new String(' ', numSpaces * zeros));

                    if (items[index] < 10)
                    {
                        output.Append(" ");
                        output.Append(items[index]);
                        output.Append(" ");
                    }
                    else if (10 <= items[index] && items[index] < 100)
                    {
                        output.Append(" ");
                        output.Append(items[index]);
                    }
                    else
                    {
                        output.Append(items[index]);
                    }

                    output.Append(new String(' ', numSpaces * zeros));

                    if (level != 0)
                        output.Append(new String(' ', zeros));

                    index++;
                }

                output.Append("\n");
                level++;
            }

            Console.WriteLine(output);
        }
    }
}
