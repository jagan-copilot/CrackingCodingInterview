using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctci_array_left_rotation
{
    class Program
    {
        //https://www.hackerrank.com/challenges/ctci-array-left-rotation
        static void Main(string[] args)
        {
            string[] t_firstLine = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(t_firstLine[0]);
            int d = Convert.ToInt32(t_firstLine[1]);

            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            RotateArray(numbers, 0, d - 1);
            RotateArray(numbers, d, n - 1);
            RotateArray(numbers, 0, n - 1);

            Console.WriteLine(string.Join(" ", numbers));

            Console.ReadLine();
        }

        private static void RotateArray(int[] numbers, int v1, int v2)
        {
            while(v1<=v2)
            {
                int tmp = numbers[v1];
                numbers[v1] = numbers[v2];
                numbers[v2] = tmp;
                v1++;
                v2--;
            }
        }
    }
}
