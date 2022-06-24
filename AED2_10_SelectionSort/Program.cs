using System;

namespace AED2_10_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = { 30, 8, 88, 78, 83, 67, 54, 96, 49, 64 };
            SelectionSort(items);

            Console.Write("\n\t[ ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]}, ");
            }
            Console.Write($"{items[items.Length - 1]} ]\n\n");
        }

        static void SelectionSort(int[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                int minPosition = i;
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[minPosition])
                    {
                        minPosition = j;
                    }
                }

                int aux = items[minPosition];
                items[minPosition] = items[i];
                items[i] = aux;
            }
        }
    }
}
