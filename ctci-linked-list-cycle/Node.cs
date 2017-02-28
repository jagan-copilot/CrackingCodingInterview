using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_linked_list_cycle
{
    class Node
    {
        public Node next;
        private int data;

        public Node(int data)
        {
            this.data = data;
        } 

        public int Data { get { return data; } }
    }
}
