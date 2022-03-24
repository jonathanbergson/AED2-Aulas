using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2_04_Fila
{
    class Node
    {
        string person;
        Node next;

        public Node(string name)
        {
            person = name;
            next = null;
        }
    }
}
