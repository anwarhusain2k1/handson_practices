using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09._09._2022
{
    class _2_3
    {
        public static void method1()
        {
            Console.WriteLine("thread name : " + Thread.CurrentThread.Name);
            Console.WriteLine("Threadstate : " + Thread.CurrentThread.ThreadState);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                

            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(method1);
            t1.Name = "thread1";
            Console.WriteLine("Threadstate : "+t1.ThreadState); 
            t1.Start();
            Thread t2 = new Thread(method1);
            t2.Priority = ThreadPriority.Highest;
            t2.Name = "Thread2";
            t2.Start();
            
            Console.Read();
        }
    }
}
