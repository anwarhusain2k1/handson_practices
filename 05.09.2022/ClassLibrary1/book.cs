using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        public  int bookid { get; set; }
        public string bookname { get; set; }
        public int price { get; set; }//13) //can u create objects of interface and abstract class
        public string author { get; set; }
        

        public Book()
        {

        }
        public Book(string s) { }
        public void insertbook(int bookid, string bookname, int price)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.price = price;
        }
        public void insertbook(int bookid, string bookname, int price, string author)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.price = price;
            this.author = author;
            
        }
        public void insertbook(int bookid, string bookname)
        {
            this.bookid = bookid;
            this.bookname = bookname;
        }

        public void display()
        {
            Console.WriteLine("Bookid:"+ bookid);
            Console.WriteLine("Bookname:" + bookname);
            Console.WriteLine("Price:" + price);
            Console.WriteLine("Author:" + author);
        }
    }
    
}
