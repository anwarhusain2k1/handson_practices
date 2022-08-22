using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._082022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("enter element arr[{0}] :",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in arr)
            {
                Console.WriteLine("element arr[{0}] :" + item);
            }
            Console.ReadLine();
        }
    }
}
