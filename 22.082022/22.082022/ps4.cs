using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _22._082022
{
    internal class ps4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("john");
            al.Add("smith");
            al.Add("25");
            Console.WriteLine("Number of elements: " + al.Count);
            al.Remove(al[2]);
            Console.WriteLine(al);
            Console.ReadLine();
        }
        
    }
}