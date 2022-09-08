using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._09._2022
{
    public class Department
    {
        public int deptno { get; set; }
        public string dname { get; set; }
        public string location { get; set; }
    }
    public class Employee:Department
    {
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public int salary { get; set; }
        public string manager { get; set; }

        
    }
}
