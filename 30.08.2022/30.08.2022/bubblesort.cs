using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._08._2022
{
    internal class bubblesort
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 22, 13, 41, 95, 62 };
            int temp;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        
                    }
                }
            }
            Console.WriteLine("Result from bubble sort:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
