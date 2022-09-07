using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    public delegate int operation( int a, int b);
    internal class ps3
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return (a - b);
        }

        static int product(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            operation del = new operation(add);
            Console.WriteLine("summ of 2 numbers = "+del(a,b));
            operation del2 = new operation(sub);
            Console.WriteLine("difference of 2 numbers = " + del2(a, b));
            operation del3 = new operation(product);
            Console.WriteLine("product of 2 numbers = " + del3(a, b));
            Console.Read();
        }
    }
}
