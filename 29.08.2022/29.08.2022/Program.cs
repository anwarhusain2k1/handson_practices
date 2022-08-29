using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("userdefined stack :\n");
            UserDataStore<string> stringdata = new UserDataStore<string>();
            stringdata.AddOrEdit(0, "Hello");
            string printdata = stringdata.ReturnData(0);
            Console.WriteLine(printdata);
            Console.WriteLine("-------------------");
            stringdata.AddOrEdit(0, "Welcome");
            stringdata.ShowData(0);
            Console.WriteLine("======================");
            Console.WriteLine("userdefined singly linkedlist:\n");
            LinkedList sllist = new LinkedList();
            sllist.PrintAllNodes();
            sllist.AddAtLast(5);
            sllist.AddAtLast(6);
            sllist.AddAtLast("seven");
            sllist.AddAtLast(8);
            sllist.PrintAllNodes();
            Console.WriteLine();
            sllist.AddAtStart(4);
            sllist.PrintAllNodes();
            Console.WriteLine();

            sllist.RemoveFromStart();
            sllist.PrintAllNodes();
            Console.WriteLine("======================");
            Console.WriteLine("custom queue:\n");
            LinearQueue Q = new LinearQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("Items are : ");
            Q.printQueue();
            Q.delete();
            Q.delete();
            Console.WriteLine("Items are : ");
            Q.printQueue();

            Console.ReadLine();
        }

        
    }
}
