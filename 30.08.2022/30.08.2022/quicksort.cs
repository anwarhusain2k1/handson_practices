using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._08._2022
{
    internal class quicksort
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 22, 13, 41, 95, 62 };
            Quicksort(arr,0,arr.Length-1);
            Console.WriteLine("Result from quick sort:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        public static int[] Quicksort(int[] array, int l, int r)
        {
            var i = l;
            var j = r;
            var pivot = array[l];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (l < j)
                Quicksort(array, l, j);
            if (i < r)
                Quicksort(array, i, r);
            return array;
        }
    }
}
