using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09._09._2022
{
    internal class Monitorprblm
    {
        static object M1 = new object();

        static void Printnumbers()
        {
            Monitor.Enter(M1);
            Console.WriteLine(Thread.CurrentThread.Name+"started working");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine(i);
            }
            Monitor.Exit(M1);
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Printnumbers);
            t1.Start();
            t1.Name = "thread1";
            Thread t2 = new Thread(Printnumbers);
            t2.Priority = ThreadPriority.Highest;
            t2.Name = "Thread2";
            t2.Start();
            Console.Read();
        }
        
    }
}
