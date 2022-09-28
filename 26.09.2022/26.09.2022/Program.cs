using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_BAL;
using library_HELP;

namespace _26._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.insertbook \n 2.insertmember \n ");
            int a = Convert.ToInt32(Console.ReadLine());
            BAL_book book = new BAL_book();
            switch(a)
            {
                case 1:
                    Console.WriteLine("enter book number");
                    book.Book_no=(Console.ReadLine());
                    Console.WriteLine("enter book_name");
                    book.Book_Name =(Console.ReadLine());
                    Console.WriteLine("enter author name");
                    book.Author =(Console.ReadLine());
                    Console.WriteLine("enter category of the book");
                    book.Category =(Console.ReadLine());
                    helper helper = new helper();
                    bool queryStatus = helper.addbook(book);
                    if (queryStatus)
                    {
                        Console.WriteLine("book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                 case 2:
                    BAL_member member = new BAL_member();
                    Console.WriteLine("enter member id");
                    member.Member_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter member name");
                    member.Member_name=Console.ReadLine();
                    Console.WriteLine("enter penality amount");
                    member.Penality=Convert.ToInt32(Console.ReadLine());
                    helper helper1 = new helper();
                    Console.WriteLine(helper1.insertmember(member));
                    break;

            }
            Console.ReadLine();
        }
    }
}
