using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    delegate string upper(string s);
    class ps7
    {
        static string uppercase(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string ");
            string s = Console.ReadLine();
            upper del = new upper(uppercase);
            string a = del(s);
            Console.WriteLine("capitalizied string : " + a);
            Console.Read();

        }
    }
}