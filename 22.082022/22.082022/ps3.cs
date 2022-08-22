using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._082022
{
    internal class ps3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter element arr[{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
                
            }
            Console.WriteLine("the sum of all elements in the array :" + sum);
            Console.ReadLine();
        }
    }
}