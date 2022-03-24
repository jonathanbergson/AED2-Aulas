using System;

namespace AED2_ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List list = new List();

                list.Add(20);
                list.Add(10);
                list.Add(53);
                list.Show();
                Console.WriteLine($"Removendo o elemento: {list.RemoveTail()}");
                list.Show();
                Console.WriteLine($"Removendo o elemento: {list.RemoveTail()}");
                list.Show();
                Console.WriteLine($"Removendo o elemento: {list.RemoveTail()}");
                list.Show();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }




            //Console.WriteLine("\n\n");
            //Console.WriteLine($"A lista possui 20? {list.Search(20)}");
            //Console.WriteLine($"A lista possui 33? {list.Search(33)}");
            //Console.WriteLine($"A lista possui 9? {list.Search(9)}");

            Console.ReadKey();
        }
    }
}
