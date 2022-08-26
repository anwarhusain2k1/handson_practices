using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using student;

namespace _26._08._2022
{
    class ps2
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
                student[i].Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter name");
                student[i].Name = Console.ReadLine();
                Console.WriteLine("enter class in number");
                student[i].Grade = Convert.ToInt32(Console.ReadLine());
            }
            
            foreach (var item in student)
            {
                Console.WriteLine("Id:" + item.Id);
                Console.WriteLine("Name:" + item.Name);
                Console.WriteLine("Class:" + item.Grade);

            }
            Console.ReadLine();
        }
    }
}