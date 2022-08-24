using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusable_code;

namespace myapp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            reusablecode.Printstring();
            Console.ReadLine();
            Console.WriteLine("enter first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter first string");
            string s2 = Console.ReadLine();
            comp.compare(s1, s2);
            Console.WriteLine("making copy of s1 on s2");
            s2 = copy.copystring(s1);
            Console.WriteLine("s2=" + s2);
        }
    }
}
