using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    delegate int length(string s);
    class ps1
    {
        static int stringlength(string s)
        {
            return s.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter the string ");
            string s = Console.ReadLine();
            length del = new length(stringlength);
            int a= del(s);
            Console.WriteLine("the length of the string is "+a);
            Console.Read();

        }
    }
}
