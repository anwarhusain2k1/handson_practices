using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class novel:Book
    {
        public int numberofpages { get; set; }
        public void insertbook(int bookid,string bookname,int price,int numberofpages)
        {
            this.bookid = bookid;
            this.bookname = bookname;
            this.price = price;
            this.numberofpages = numberofpages;
        }
    }
}
