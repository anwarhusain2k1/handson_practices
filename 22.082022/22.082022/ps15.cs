using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._082022
{
    internal class ps15
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 5, 3, 4, 3, 5, 6 };
            int min = -1;
            HashSet<int> set = new HashSet<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else
                {
                    set.Add(arr[i]);
                }
            }
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();
        }
    }
}