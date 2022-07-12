using System;

namespace AED2_08_AlgorimoDeOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            int size = 10;
            
            v = Order.Generate(size);
            Order.Print(v);
            Order.IsOrdened(v);

            v = Order.GenerateIncreasing(size);
            Order.Print(v);
            Order.IsOrdened(v);

            v = Order.GenerateDescending(size);
            Order.Print(v);
            Order.IsOrdened(v);
        }
    }
}
