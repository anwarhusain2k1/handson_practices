using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _26._08._2022
{
    class ps1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the total number of students");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < n; i++)
            {
                student[i] = new Student();
                Console.WriteLine("enter studentid");
                student[i].studentid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                student[i].name = Console.ReadLine();
                Console.WriteLine("enter class in number");
                student[i].grade = Convert.ToInt32(Console.ReadLine());
                
            }
            foreach (var item in student)
            {
                Console.WriteLine("Studentid:"+item.studentid);
                Console.WriteLine("Name:"+item.name);
                Console.WriteLine("Class:"+item.grade);

            }
            Console.ReadLine();
        }
        

        struct Student
        {
            public int studentid;
            public string name;
            public int grade;
        }
    }
}