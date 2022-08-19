using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._08_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the first integer");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("menu \n 1.addition \n 2.subraction\n 3.multiplication\n 4.divison");
            int c = Convert.ToInt32(Console.ReadLine());
            int result;
            switch (c)
            {

                case 1:
                    result = a + b;
                    Console.WriteLine("the addition of two numbers is"+result);
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine("the subtractiontion of two numbers is" + result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine("the multiplication of two numbers is" + result);
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine("the division of two numbers is" + result);
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
