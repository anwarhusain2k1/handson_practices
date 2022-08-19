using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._8._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter firstnumber");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter secondnumber");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter secondnumber");
            int c = Convert.ToInt32(Console.ReadLine());
            callbyvalue(a, b);
            Console.WriteLine("the value  after callbyvalue a is {0} and b is {1}", a, b);
            callbyreference(ref a,ref b);
            Console.WriteLine("the value  after callbyvalue a is {0} and b is {1}", a, b);
            multiply(a, b, c);
            Console.ReadLine();
        }
            static void callbyvalue(int a, int b)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
                Console.WriteLine("the value of a is {0} and b is {1}",a,b);
                
            }
            static void callbyreference(ref int a,ref int b)
            {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the value of a is {0} and b is {1}", a, b);

            }
            static void multiply(int a,int b,int c)
        {
            int d = a * b * c;
            Console.WriteLine("the result of multiplication ="+d);
        }

    }
    }

