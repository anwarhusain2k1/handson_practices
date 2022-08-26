
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLibrary;

namespace _26._08._2022
{
    class ps4
    {
        static void Main(string[] args)
        {
            LinkedList<Employee> emp = new LinkedList<Employee>();
            emp.AddFirst(new Employee { EmpID = 5, EmpName = "Jim", DeptNo = 20, City = "Bangalore" });
            emp.AddFirst(new Employee { EmpID = 1, EmpName = "Jack", DeptNo = 10, City = "Hyderabad" });
            emp.AddAfter(emp.First.Next, new Employee { EmpID=2,EmpName ="john",DeptNo=30,City ="Chennai" });
            Employee empF = emp.ElementAt(2);
            emp.AddAfter(emp.Find(empF), new Employee { EmpID = 3, EmpName = "Smith", DeptNo = 40, City = "Chennai" });
            emp.AddBefore(emp.Last.Previous, new Employee { EmpID = 4, EmpName = "Palani", DeptNo = 40, City = "Bangalore" });
            foreach (var item in emp)
            {
                Console.WriteLine("EmpID:"+item.EmpID);
                Console.WriteLine("EmpName:"+item.EmpName);
                Console.WriteLine("DeptNo:"+item.DeptNo);
                Console.WriteLine("City:"+item.City);
            }
            Console.ReadLine();
        }
    }
}