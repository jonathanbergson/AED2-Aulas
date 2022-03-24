using System;

namespace AED2_ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Lista lista = new Lista(5);
                int elemento;

                lista.InsereFim(23);
                lista.InsereFim(52);
                lista.InsereFim(2);
                lista.InsereFim(1);
                lista.Mostrar();

                //lista.InsereFim(-19);
                //lista.InsereInicio(85);
                //lista.Mostrar();

                //lista.RemoveFim();
                //lista.RemoveFim();
                //lista.Mostrar();

                //lista.RemoveInicio();
                //lista.Mostrar();

                lista.InserePosicao(17, 1);
                lista.Mostrar();

                lista.InserePosicao(8, 1);
                lista.Mostrar();


                elemento = 52;
                Console.WriteLine($"\nO elemento {elemento} existe? {lista.Pesquisar(elemento)}");

                elemento = 10;
                Console.WriteLine($"O elemento {elemento} existe? {lista.Pesquisar(elemento)}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
