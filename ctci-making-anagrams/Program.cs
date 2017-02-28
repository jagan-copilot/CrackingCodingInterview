using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_making_anagrams
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-making-anagrams
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int[] characterCounter = InitializeCharacterCounter();

            AddCharacterCountsOfString(a, characterCounter);

            RemoveCharacterCountsOfString(b, characterCounter);

            Console.WriteLine(GetCountOfRemoveOperations(characterCounter));

            Console.ReadLine();

        }

        private static int GetCountOfRemoveOperations(int[] characterCounter)
        {
            int removeOperationsCount = 0;

            for (int i = 0; i < characterCounter.Length; i++)
            {
                removeOperationsCount += Math.Abs( characterCounter[i]);
            }
            return removeOperationsCount;
        }

        private static void RemoveCharacterCountsOfString(string b, int[] characterCounter)
        {
            for (int i = 0; i < b.Length; i++)
            {
                characterCounter[(int)b[i] - (int)'a']--;
            }
        }

        private static void AddCharacterCountsOfString(string a, int[] characterCounter)
        {
            for (int i = 0; i < a.Length; i++)
            {
                characterCounter[(int)a[i] - (int)'a']++;
            }
        }

        private static int[] InitializeCharacterCounter()
        {
            int[] counter = new int[256];

            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }
            return counter;
        }
    }
}
