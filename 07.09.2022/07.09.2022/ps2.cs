using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    internal class ps2
    {
        delegate string greet(string s);
        static string greetmsg(string s)
        {
            return "Hello"+s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter username ");
            string s = Console.ReadLine();
            greet g = new greet(greetmsg);
            string s1 =g(s);
            Console.WriteLine(s1);
            Console.Read();

        }
    }
}
