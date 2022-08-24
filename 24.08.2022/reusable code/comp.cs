using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reusable_code
{
    public class comp
    {
        public static void compare(string s1,string s2)
        {
            if (s1 == s2)
                Console.WriteLine("they are equal");
            else
                Console.WriteLine("they are not equal");
        }
    }
}
