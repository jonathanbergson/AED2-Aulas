using System;

namespace AED2_AnaliseDeComplexidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 10, 55, 2, 1, 4, 6, 7, 8, 23 };
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


            for (int i = 1; i < elements.Length; i += 2)
            {
                int red = elements[i - 1];
                int blue = elements[i];

                if (red < min)
                {
                    min = red;
                }
                if (blue > max)
                {
                    max = blue;
                }
            }
        }
    }
}
