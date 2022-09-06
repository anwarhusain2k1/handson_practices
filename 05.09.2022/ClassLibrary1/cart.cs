using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cart:Book
    {
        public int customerid { get; set; }
        public int booking_id { get; set; }
        static int a = 0;

        List<Book> books = new List<Book>();
        public Cart() { }
        

        
        Cart(int customerid, int bookid, int price)
        {
            this.customerid = customerid;
            this.bookid = bookid;
            this.price = price;
        }
        public void addtocart(int id, string name,string author,int  price)
        {
            addbook(id,name,price,author);
            a++;
        }
        public void addbook(int bookid, string bookname, int price, string author)
        {
            Book book = new Book();
            book.bookid = bookid;
            book.bookname = bookname;
            book.price = price;
            book.author = author;
            books.Add(book);
            
        }
        public void displaycart()
        {
            Console.WriteLine("list of books in the cart:");
            //Console.WriteLine("static variable count on books in the cart:"+a);
            int b = books.Count;
            Console.WriteLine(b);
            foreach(var item in books)
            {
                Console.WriteLine("bookid   :"+item.bookid);
                Console.WriteLine("bookname :"+item.bookname);
                Console.WriteLine("price    :"+item.price);
                Console.WriteLine();
            }
        }
    }
    
}
