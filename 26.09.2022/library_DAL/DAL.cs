using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using library_BAL;

namespace library_DAL
{
    public class DAL
    {
        public bool insertbook(BAL_book book)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["library_cn"].ConnectionString);
            SqlCommand insertcmd = new SqlCommand("insert into book(book_no,book_name,author,Category)values(@book_no,@book_name,@author,@category)",cn);
            insertcmd.Parameters.AddWithValue("@book_no",book.Book_no);
            insertcmd.Parameters.AddWithValue("@book_name",book.Book_Name);
            insertcmd.Parameters.AddWithValue("@author",book.Author);
            insertcmd.Parameters.AddWithValue("@category", book.Category);
            cn.Open();
            int i=insertcmd.ExecuteNonQuery();
            bool status= false;
            if (i==1)
                status=true;
            cn.Close();
            cn.Dispose();
            return status;
        }
        public bool insertmember(BAL_member member)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["library_cn"].ConnectionString);
            SqlCommand insertmember = new SqlCommand("insert into member(memberid,name,Penality_Amount) values(@id,@name,@penality");
            insertmember.Parameters.AddWithValue("@id", member.Member_id);
            insertmember.Parameters.AddWithValue("@name", member.Member_name);
            insertmember.Parameters.AddWithValue("@penality", Convert.ToDouble( member.Penality));
            cn.Open();
            int i = insertmember.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
                status = true;
            cn.Close();
            cn.Dispose();
            return status;
        }
    }
    
}
