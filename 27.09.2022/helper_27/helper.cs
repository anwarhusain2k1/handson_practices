using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using DAL_27;

namespace helper_27
{
    public class student_helper
    {
        student_dal dal1 = null;
        public student_helper()
        {
            dal1 = new student_dal();
        }
        public int studentcount()
        {
            return  dal1.studentcount();
        }
        public bool insertstudent(student_bal student)
        {
            return dal1.add_student(student);
        }
        public List<student_bal> displayallstudent()
        {
            return dal1.showallstudent();
        }

        public bool edit_student(int student_id, student_bal student)
        {
            return dal1.update_student(student_id, student);
        }

        public bool remove_student(int student_id)
        {
            return dal1.delete_student(student_id);
        }
    }
}
