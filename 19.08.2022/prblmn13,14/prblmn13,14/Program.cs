using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblmn13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b=0;
            if (a < 100)
            {
                if (a == 0)
                    b = 1;
                else if ((a % 10) == 0)
                    b = 2;
                else if ((a % 2) == 0)
                    b = 3;
                else if ((a % 2) == 1)
                    b = 4;
            }
            else
                b = 6;
         
            switch (b)
            {
                case 1:
                    Console.WriteLine("the input is zero");
                    break;
                case 2:
                    Console.WriteLine("the input is a multiple of 10");
                    break;
                case 3:
                    Console.WriteLine("the input is a even number");
                    break;
                case 4:
                    Console.WriteLine("the input is a odd number");
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}
