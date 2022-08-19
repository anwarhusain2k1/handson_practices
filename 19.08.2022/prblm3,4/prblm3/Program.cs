using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter a character");
            char b = Convert.ToChar(Console.ReadLine());
            if(a == b)
            {
                Console.WriteLine("the two characters {0} and {1} are same",a,b);
            }
            else
            {
                Console.WriteLine("they are not same");
            }
            
            Console.WriteLine("enter a string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter another string");
            string s2 = Console.ReadLine();
            Console.WriteLine("comparing strings using == operator");
            if (s1 == s2)
            {
                Console.WriteLine("the two strings {0} and {1} are same", s1, s2);
            }
            else
            {
                Console.WriteLine("the given string {0} and {1} are not same",s1,s2);
            }
            Console.ReadLine();
        }
    }
}
