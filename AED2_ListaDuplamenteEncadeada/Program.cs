using System;

namespace AED2_ListaDuplamenteEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Prepend(3);
            list.Prepend(5);
            list.Prepend(7);
            list.Prepend(9);
            list.Show();

            list.Push(12);
            list.Show();
        }
    }
}
