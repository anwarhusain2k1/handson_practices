using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_library28;

namespace BLL_library
{
    public class bookoperations
    {
        public void insertbook(book_bal bal)
        {
            libraryCn context = new libraryCn();
            book book1 = new book();
            book1.Author = bal.Author;
            book1.Book_Name=bal.Book_name;
            book1.Book_No=bal.Book_no;
            context.books.Add(book1);
            context.SaveChanges();
            
        }
    }
    public class memberoperation
    {
        public member_bal findmember(int memberid)
        {
            libraryCn context = new libraryCn();
            List<member> members = context.members.ToList();
            member member = members.Find(memb => memb.memberid == memberid);
            member_bal bal = new member_bal();
            bal.Member_id = Convert.ToInt32(member.memberid);
            bal.Member_name = member.name;
            bal.Acc_opendate = Convert.ToDateTime(member.Acc_Open_Date);
            return bal;

        }
    }
}
