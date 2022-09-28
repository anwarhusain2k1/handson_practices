using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_BAL;
using library_DAL;

namespace library_HELP
{
    public class helper
    {
        DAL book_dal = null;
        DAL member_dal = null;
        public helper()
        {
            book_dal = new DAL();
            member_dal = new DAL();
        }
        public bool addbook(BAL_book book)
        {
            return book_dal.insertbook(book);
        }

        public bool insertmember(BAL_member member)
        {

            return member_dal.insertmember(member);
        }
    }
}
