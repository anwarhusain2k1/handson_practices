using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using helper_27;

namespace _27._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            student_helper stud_helper = new student_helper();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New student \n2. Update student \n3. Show All \n4. Delete student \n5. student count \n7. Exit ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            student_bal student = new student_bal();

            switch (userchoice)
            { 
                case 1:
                    Console.WriteLine("enter student id");
                    student.Student_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter student name");
                    student.Student_name = Console.ReadLine();
                    Console.WriteLine("enter course id");
                    student.Course_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stud_helper.insertstudent(student));
                    break;
                 case 2:
                    Console.WriteLine("enter id of the student you want to delete");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter student id");
                    student.Student_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter student name");
                    student.Student_name = Console.ReadLine();
                    Console.WriteLine("enter course id");
                    student.Course_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(stud_helper.edit_student(id,student));
                    break;
                 case 3:
                    List<student_bal> list = new List<student_bal>();
                    list = stud_helper.displayallstudent();
                    Console.WriteLine("studentID" + "      " + "student Name" + "         " + "courseid");
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Student_id + "       " + item.Student_name + "       " + item.Course_id);
                    }
                    break;
                case 4:
                    Console.WriteLine("enter student id");
                    int Student_id = Convert.ToInt32(Console.ReadLine());
                    bool status = stud_helper.remove_student(Student_id);
                    if (status)
                    {
                        Console.WriteLine(" Deleted successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 5:
                    int c = stud_helper.studentcount();
                    Console.WriteLine(c);
                    break;
                default:
                    break;





            }
            Console.ReadLine();
        }
    }
}
