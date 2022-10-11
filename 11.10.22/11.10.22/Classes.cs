using System.Diagnostics.Metrics;

namespace _11._10._22
{
    public class Member
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
    public class Book
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
    public partial class issue
    {
        public decimal Lib_Issue_Id { get; set; }
        public int Book_No { get; set; }
        public int Member_Id { get; set; }
        public DateTime Issue_Date { get; set; }
        public DateTime Return_date { get; set; }
    }
}
