using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    internal class ps1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            add(a, b);  
            Console.ReadLine();
        }
        static void add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("the sum is "+sum);
        }

    }
}
