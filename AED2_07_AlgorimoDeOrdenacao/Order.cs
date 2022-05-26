using System;

namespace AED2_07_AlgorimoDeOrdenacao
{
    class Order
    {
        public static void Print(int[] v)
        {
            Console.Write("\n\t[ ");

            for (int i = 0; i < v.Length - 1; i++)
            {
                Console.Write($"{v[i]}, ");
            }

            Console.Write(v[v.Length -1]);
            Console.Write(" ]\n ");
        }

        public static int[] Generate(int size, int min = 0, int max = 100)
        {
            int[] v = new int[size];
            Random randomizer = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = randomizer.Next(min, max);
            }

            return v;
        }

        public static int[] GenerateIncreasing(int size)
        {
            int[] v = new int[size];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i + 1;
            }

            return v;
        }

        public static int[] GenerateDescending(int size)
        {
            int[] v = new int[size];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = (v.Length - 1) - i;
            }

            return v;
        }

        public static bool IsOrdened(int[] v)
        {
            bool ordened = true;

            for (int i = 1; i < v.Length; i++)
            {
                if (v[i - 1] >= v[i]) ordened = false;
            }

            Console.WriteLine($"\t >> Está ordenado? {ordened}");

            return ordened;
        }
    }
}
