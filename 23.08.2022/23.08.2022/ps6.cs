using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace _23._08._2022
{
    internal class ps6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deptnumber of Purchase :"+ (int)deptname.Purchase);
            Console.WriteLine("deptnumber of Sales :" + (int)deptname.Sales);
            Console.WriteLine("deptnumber of Training :" + (int)deptname.Training);
            Console.WriteLine("deptnumber of Account:" + (int)deptname.Account);
            Console.Read();
        }

        enum deptname
        {
            Purchase =1,
            Sales,
            Training,
            Account
        }
    }
}