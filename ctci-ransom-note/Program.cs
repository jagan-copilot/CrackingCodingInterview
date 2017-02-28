using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_ransom_note
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-ransom-note
        static void Main(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Dictionary <string,int> hash = InitializeHash(magazine);
            Console.WriteLine(CanReplicate(hash, magazine, ransom) ? "Yes" : "No");

            Console.ReadLine();
        }

        private static Dictionary<string,int> InitializeHash(string[] magazine)
        {
            Dictionary<string, int> magazineHash = new Dictionary<string, int>();
            foreach (var item in magazine)
            {
                if (magazineHash.ContainsKey(item))
                    magazineHash[item]++;
                else
                    magazineHash.Add(item, 1);
            }
            return magazineHash;
        }

        private static bool CanReplicate(Dictionary<string,int> hash,string[] magazine, string[] ransom)
        {
            bool canReplicate = false;

            if (magazine.Length < ransom.Length) return false;

            foreach (var item in ransom)
            {
                canReplicate = hash.ContainsKey(item) && hash[item]!=0;
                hash[item]--;

                if (!canReplicate) return false;
            }

            return canReplicate;
        }
    }
}
