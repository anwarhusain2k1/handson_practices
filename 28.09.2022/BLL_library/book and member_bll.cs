using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_library
{
    public class book_bal
    {
		private int book_no;

		public int Book_no
		{
			get { return book_no; }
			set { book_no = value; }
		}
		private string bookname;

		public string Book_name
		{
			get { return bookname; }
			set { bookname = value; }
		}
		private string author;

		public string Author
		{
			get { return author; }
			set { author = value; }
		}



	}
	public class member_bal
	{
        private int member_id;
        public int Member_id
        {
            get { return member_id; }
            set { member_id = value; }
        }
        private string member_name;
        public string Member_name
        {
            get { return member_name; }
            set { member_name = value; }
        }
        private DateTime acc_opendate;

        public DateTime Acc_opendate
        {
            get { return acc_opendate; }
            set { acc_opendate = value; }
        }
    }
}
