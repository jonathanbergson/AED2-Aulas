using System;

namespace AED2_07_AnaliseDeComplexidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 10, 55, 2, 4, 6, 7, 8, 23, 56 };
            int min = 0, max = 0;
            MinAndMax(elements, ref min, ref max);

            Console.Write("\n\n\tLista de elementos: [ ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"{elements[i]}, ");
            }
            Console.Write("] \n");

            Console.WriteLine($"\tMenor: {min}");
            Console.WriteLine($"\tMax: {max}");
        }

        static void MinAndMax(int[] elements, ref int min, ref int max)
        {
            min = elements[0];
            max = elements[0];

            int i = 0;
            if (elements.Length % 2 == 1)
            {
                min = elements[0];
                max = elements[0];
                i = 1;
            }

            for (; i < elements.Length; i += 2)
            {
                int red = elements[i - 1];
                int blue = elements[i];

                if (elements[i] > elements[i + 1])
                {
                    red = elements[i];
                    blue = elements[i + 1];
                } else
                {
                    red = elements[i + 1];
                    blue = elements[i];
                }

                if (red > max) max = red;
                if (blue < min) min = blue;
            }
        }
    }
}
