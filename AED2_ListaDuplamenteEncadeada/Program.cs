using System;

namespace AED2_ListaDuplamenteEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Push(3);
            list.Push(5);
            list.Push(7);
            list.Push(9);
            list.Show();

            list.Shift();
            list.Show();

            //list.Pop();
            //list.Push(5);
            //list.Show();
        }
    }
}
