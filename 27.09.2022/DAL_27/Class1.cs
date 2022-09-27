using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BAL;

namespace DAL_27
{
    public class student_dal
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection cn = null;
        public student_dal()
        {
            ds = new DataSet();
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["imsCnStr"].ConnectionString);
        }

        private DataTable Connectstudent()
        {
            da = new SqlDataAdapter("select * from student", cn);
            da.Fill(ds, "student");
            DataTable dt = ds.Tables["student"];
            return dt;
        }
        public int studentcount()
        { 
            DataTable dt = Connectstudent();
            return dt.Rows.Count;
        }
        public bool add_student(student_bal student)
        {
            DataTable dt = Connectstudent();
            DataRow drow = dt.NewRow();
            drow[0] = student.Student_id;
            drow[1] = student.Student_name;
            drow[2] = student.Course_id;
            dt.Rows.Add(drow);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(dt);
            return true;
        }

        public bool delete_student(int student_id)
        {
            DataTable dt = Connectstudent();
            DataRow drow = ds.Tables["student"].Rows.Find(student_id);
            drow.Delete();
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(dt);
            return true;
        }

        public bool update_student(int student_id, student_bal student)
        {
            DataTable dt = Connectstudent();
            
            DataRow drow = dt.Rows.Find(student_id);
            drow["stuid"]=student.Student_id;
            drow["name"] = student.Student_name;
            drow["crsid"] = student.Course_id;
            SqlCommandBuilder bldr = new SqlCommandBuilder (da);
            da.Update (dt);
            return true;
        }

        public List<student_bal> showallstudent()
        {
            DataTable dt = Connectstudent();
            List<student_bal> list = new List<student_bal>();
            for(int i= 0; i < dt.Rows.Count; i++)
            {
                student_bal bal = new student_bal();
                DataRow drow = dt.Rows[i];
                bal.Student_id = Convert.ToInt32(drow["stuid"]);
                bal.Student_name = Convert.ToString(drow["name"]);
                bal.Course_id = Convert.ToInt32(drow["crsid"]);
                list.Add(bal);
            }
            return list;
        }



    }
}
