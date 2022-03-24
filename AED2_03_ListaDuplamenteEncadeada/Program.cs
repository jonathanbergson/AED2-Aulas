namespace AED2_03_ListaDuplamenteEncadeada
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

            list.Add(85, 2);
            list.Show();
            list.Add(33, 22);
            list.Show();

            //list.Pop();
            //list.Push(5);
            //list.Show();
        }
    }
}
