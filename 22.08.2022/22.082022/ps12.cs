using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace _22._082022
{
    internal class ps12
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, n;
            Console.Write("Input the number of elements in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Minimum number is " + arr.Min());
            Console.WriteLine("Maximum number is " + arr.Max());
            Console.ReadLine();
        }
    }
}