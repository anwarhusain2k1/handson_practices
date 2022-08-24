using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusable_code;

namespace myapp1
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            string s = "Welcome to the world of C# Programming";
            string[] subs = s.Split('#');
            foreach (string s2 in subs)
                Console.WriteLine(s2);
            
            Console.ReadLine();
        }
    }
}