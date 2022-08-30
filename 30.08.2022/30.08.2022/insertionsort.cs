using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._08._2022
{
    internal class insertionsort
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 22, 13, 41, 95, 62 };
            int temp;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            insertionSort(arr);
            Console.WriteLine("Result from Insertion sort:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }

        static void insertionSort(int[] arr)
        {
            int i, key, j,n;
            n = arr.Length;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
