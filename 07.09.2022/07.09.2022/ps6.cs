using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    internal class ps6
    {
        delegate string concat(string s1,string s2);
        static string add(string s1,string s2)
        {
            return s1+s2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter first string");

            string s = Console.ReadLine();
            Console.WriteLine("enter second string");
            string s1 = Console.ReadLine();
            concat d = new concat(add);
            string S = d(s,s1);
            Console.WriteLine(S);
            Console.Read();
        }
    }
}