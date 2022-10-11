using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_dal
{
    public class Class1
    {
        public List<book> GetBooks()
        {
            library_systemsEntities context = new library_systemsEntities();
            List<book> books = context.books.ToList();
            return books;
        }
    }
}
