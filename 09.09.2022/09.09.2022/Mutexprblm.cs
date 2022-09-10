using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09._09._2022
{
    class ps4
    {
        
        static void Main(string[] args)
        {
            
            using (Mutex mutex = new Mutex(false, "mutexdemo"))
            {
                if(!mutex.WaitOne(5000,false))
                {
                    Console.WriteLine("an instance of the application is running");
                    Console.Read();
                    return;

                }
                Console.WriteLine("Application is running");
                Console.Read();
            }
        }
    }
}
