using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblm10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0;
            Console.WriteLine("Display the number in reverse order:\n");
            Console.WriteLine("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int a = num; a != 0; a = a / 10)
            {
                r = a % 10;
                sum = sum * 10 + r;
            }
            Console.WriteLine("The number in reverse order is : {0} \n", sum);
            Console.ReadLine();
        }

    }
}
