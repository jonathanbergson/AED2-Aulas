using System;

namespace AED2_05_Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pile pile = new Pile();

                pile.Add(56);
                pile.Add(45);
                pile.Add(23);
                pile.Show();

                Console.WriteLine($"O elemento removido: {pile.Remove()}");
                pile.Show();
                pile.Add(86);
                pile.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
