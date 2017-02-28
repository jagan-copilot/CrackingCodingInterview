using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_is_binary_search_tree
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-is-binary-search-tree
        static void Main(string[] args)
        {
            Node root = new Node(1);

            Node Two = new Node(2);
            Two.left = new Node(5);
            Two.right = new Node(4);

            Node four = new Node(3);
            four.left = new Node(6);
            four.right = new Node(7);

            root.left = Two;
            root.right = four;

            ST st = new ST();
            Console.WriteLine( st.checkBST(root));
            Console.ReadLine();
            
        }

        public class ST
        {
            public bool checkBST(Node root)
            {
                if (root == null) return true;

                return !checkChildBST(root.left, root, true)
                    ? false : checkChildBST(root.right, root, false);
            }

            private bool checkChildBST(Node current, Node parent, bool isLeftChild)
            {
                if (current == null) return true;

                else
                {
                    if (isLeftChild)
                    {
                        if (current.data > parent.data) return false;
                    }
                    else
                    {
                        if (current.data < parent.data) return false;
                    }
                }

                return !checkChildBST(current.left, current, true)
                    ? false : checkChildBST(current.right, current, false);

            }
        }

        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data) { 
                this.data = data;
            }

        }
    }
}
