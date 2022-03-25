namespace AED2_04_Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Toqueue("Jonathan Bergson");
            queue.Toqueue("Luana Stephanie");
            queue.Toqueue("Jordan Matheus");
            queue.Show();

            queue.Dequeue();
            queue.Show();
            queue.Dequeue();
            queue.Show();
            queue.Dequeue();
            queue.Show();

            queue.Toqueue("Lara Cristina");
            queue.Toqueue("Mairon Gadran");
            queue.Lock(4);
        }
    }
}
