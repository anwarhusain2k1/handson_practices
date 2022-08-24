using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusable_code;

namespace myapp1
{
    internal class ps5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string that you want in uppercase ");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1.ToUpper());
            Console.ReadLine();
        }
    }
}