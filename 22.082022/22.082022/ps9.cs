using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _22._082022
{
    internal class ps9
    {
        static void Main(string[] args)
        {
            List<float> mylist = new List<float>();
            mylist.Add(103.2f);
            mylist.Add(93.2f);
            mylist.Add(535.3f);
            Console.WriteLine("the list elemnts are:");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Sort();
            Console.WriteLine("ascending sort :");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            mylist.Reverse();
            Console.WriteLine("descending sort :");
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}