using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_linked_list_cycle
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-linked-list-cycle
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3,2);
            Console.WriteLine(list.hasCycle());
            Console.ReadLine();
        }
    }
}
