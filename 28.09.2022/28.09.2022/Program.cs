using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_library;
namespace _28._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            memberoperation mp = new memberoperation();
            Console.WriteLine("enter member id");
            int memberid = Convert.ToInt32(Console.ReadLine());
            member_bal member = mp.findmember(memberid);
            
            Console.WriteLine(member.Member_id+"\t"+member.Member_name+"\t"+member.Acc_opendate);
            book_bal bal = new book_bal();
            Console.WriteLine("enter book_number");
            bal.Book_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter book name");
            bal.Book_name =Console.ReadLine();
            Console.WriteLine("enter author name");
            bal.Author = Console.ReadLine();
            bookoperations b = new bookoperations();
            b.insertbook(bal);
        }
    }
}
