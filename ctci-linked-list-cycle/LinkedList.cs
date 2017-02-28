using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_linked_list_cycle
{
    class LinkedList
    {
        Node start;
        Node end;

        // insert a node to end of list.
        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if (start == null)
            {
                start = newNode;
                end = newNode;
                newNode.next = null;
            }
            else
            {
                end.next = newNode;
                end = newNode;
                newNode.next = null;
            }
        }

        // insert a node to end of list, which connects to existing node.
        public void Insert(int data, int existingData)
        {
            Node newNode = new Node(data);
            end.next = newNode;
            end = newNode;
            Node currentNode = start;

            // navigate to existing node.
            while (currentNode.Data != existingData)
            {
                currentNode = currentNode.next;
            }

            newNode.next = currentNode;

        }

        public bool hasCycle()
        {
            return hasCycle(start);
        }

        private bool hasCycle(Node start)
        {
            Node slowPointer = start;
            Node fastPointer = start;

            if (start == null) return false;
            do
            {
                // slowpointer move by one node
                slowPointer = slowPointer.next;

                // fast pointer move by two nodes
                fastPointer = fastPointer.next != null ? fastPointer.next.next : null;

                // if any pointers are null, it is not a cycling list.
                if (slowPointer == null || fastPointer == null) return false;

            } while (slowPointer != fastPointer);

            return true;

        }


    }
}
