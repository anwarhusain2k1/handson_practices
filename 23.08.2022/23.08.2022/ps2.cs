using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    internal class ps2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = add(a, b);
            Console.WriteLine("the sum is " + sum);
            Console.ReadLine();
        }
        static int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

    }
}
