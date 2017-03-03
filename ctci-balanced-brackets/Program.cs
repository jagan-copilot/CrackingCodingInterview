using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_balanced_brackets
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-balanced-brackets

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            bool[] results = new bool[t];

            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                results[a0] = IsBalancedBrackets(expression);
            }
        }

        private static bool IsBalancedBrackets(string expression)
        {
            if (expression.Length == 0) return true;

            Stack<char> stack = new Stack<char>();

            foreach (var c in expression)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[': stack.Push(c); break;
                    case ')':
                        {
                            if (stack.Count == 0 || !stack.Pop().Equals('(')) return false;
                        }
                        break;
                    case ']':
                        {
                            if (stack.Count == 0 || !stack.Pop().Equals('[')) return false;
                        }
                        break;
                    case '}':
                        {
                            if (stack.Count == 0 || !stack.Pop().Equals('{')) return false;
                        }
                        break;
                    default: return false;

                }

            }
        }
    }
}
