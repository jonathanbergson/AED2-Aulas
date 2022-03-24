using System;

namespace AED2_ListaEstatica
{
    public class Lista
    {
        int[] elementos;
        private int quantidade;

        public Lista(int quantidadeMaxima)
        {
            elementos = new int[quantidadeMaxima];
            this.quantidade = 0;
        }

        public void InserePosicao(int elemento, int posicao)
        {
            if (posicao >= elementos.Length || posicao < 0)
            {
                throw new Exception("Posição inválida!");
            }
            else if (quantidade == elementos.Length)
            {
                throw new Exception("Lista lotada!");
            }
            else
            {
                for (int i = quantidade - 1; i >= posicao; i--)
                {
                    elementos[i + 1] = elementos[i];
                }
                elementos[posicao] = elemento;
                quantidade++;
            }
        }

        public void InsereInicio(int elemento)
        {
            if (this.quantidade == this.elementos.Length)
            {
                // Console.WriteLine("Lista está cheia. Não é possível inserir.");
                throw new Exception($"Deu ruim mano, não inseri o elemento {elemento}");
            }
            else
            {
                for (int i = this.quantidade - 1; i >= 0; i--)
                {
                    elementos[i + 1] = elementos[i];
                }
                elementos[0] = elemento;
                quantidade++;
            }
        }

        public void InsereFim(int elemento)
        {
            if (this.quantidade == this.elementos.Length)
            {
                // Console.WriteLine("Lista está cheia. Não é possível inserir.");
                throw new Exception($"Deu ruim mano, não inseri o elemento {elemento}");
            }
            else
            {
                elementos[quantidade] = elemento;
                quantidade++;
            }

        }

        public int RemoveInicio()
        {
            int elemento;
            if (quantidade == 0)
            {
                throw new Exception("Não existe elemento para deletar");
            }
            else
            {
                elemento = elementos[0];
                for (int i = 1; i < quantidade; i++)
                {
                    elementos[i - 1] = elementos[i];
                }
                quantidade--;
            }

            return elemento;
        }

        public int RemoveFim()
        {
            int elemento = elementos[quantidade - 1];
            elementos[quantidade - 1] = 0;
            quantidade--;
            return elemento;
        }

        public int Pesquisar(int elemento)
        {
            int i;
            bool achou = false;
            int posicao = -1;

            for (i = 0; i < this.quantidade; i++)
            {
                if (this.elementos[i] == elemento)
                {
                    achou = true;
                    posicao = i;
                    break;
                }
            }

            return posicao;
        }

        public void Mostrar()
        {
            int i;

            Console.Write("\t[ ");
            for (i = 0; i < this.quantidade; i++)
            {
                Console.Write($"{elementos[i]}, ");
            }
            Console.Write("]\n\n");
        }

    }
}
