using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09._09._2022
{
    class ps_1
    {
        public static void method1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(method1);
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(method1));
            Console.WriteLine("parameterized thread");
            t2.Start();
            Console.Read();
        }
    }
}
