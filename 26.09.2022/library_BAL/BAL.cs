using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_BAL
{
    public class BAL_book
    {
		private string book_no;

		public string Book_no
		{
			get { return book_no; }
			set { book_no = value; }
		}

		private string book_name;

		public string Book_Name
		{
			get { return book_name; }
			set {
				if (string.IsNullOrEmpty(value))
					throw new Exception("book name can't be null");
				else
					book_name = value;
			}
		}
		private int cost;

		private string author;

		public string Author
		{
			get { return author; }
			set {
                if (string.IsNullOrEmpty(value) || (value.Length>30))
                    throw new Exception("Author name invalid...");
                else
                    author = value;
            }
		}
		
		public int Cost
		{
			get { return cost; }
			set { cost = value; }
		}
		private string category;

		public string Category
        {
			get { return category; }
			set {
				
					category = value;

			}
		}

	}
	public class BAL_member
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
		private int penality;

		public int Penality
		{
			get { return penality; }
			set { penality = value; }
		}





	}

}
