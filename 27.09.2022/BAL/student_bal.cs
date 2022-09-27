using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class student_bal
    {
		private int student_id;

		public int Student_id
		{
			get { return student_id; }
			set { student_id = value; }
		}
		private string student_name;

		public string Student_name
		{
			get { return student_name; }
			set { student_name = value; }
		}

		private int course_id;

		public int  Course_id
		{
			get { return course_id; }
			set { course_id = value; }
		}



	}
}
