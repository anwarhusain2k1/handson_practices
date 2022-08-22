using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _22._082022
{
    internal class ps6
    {
        static void Main(string[] args)
        { 
            Stack s = new Stack();
            s.Push(" apple");
            s.Push(" orange ");
            s.Push(" grape");
            Console.WriteLine("count of stack"+s.Count);
            Console.WriteLine("Element at the top is : " + s.Peek());
            object s1 = s.Pop();
            Console.WriteLine("1st pop:" + s1);
            Console.ReadLine();

        }
    }
}
