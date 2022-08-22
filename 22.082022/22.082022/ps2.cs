using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._082022
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter element arr[{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
                Array.Reverse(arr);
                Console.WriteLine("after reverse");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
     }
}
