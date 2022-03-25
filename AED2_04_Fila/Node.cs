namespace AED2_04_Fila
{
    class Node
    {
        private string _name;
        private Node _next;

        public Node(string name)
        {
            _name = name;
            _next = null;
        }
        
        public string Name
        {
            get => _name;
        }
        
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
