using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusable_code;

namespace myapp1
{
    internal class ps3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string with character A");
            string s1 = Console.ReadLine();
            int a = s1.IndexOf('A');
            Console.WriteLine("index of A in the string :"+a);
            Console.ReadLine();
        }
    }
}