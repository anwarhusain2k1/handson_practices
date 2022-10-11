using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using book_dal;
namespace error_handling
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Class1 booklist = new Class1();
            ListBox1 = booklist.GetBooks();
            ListBox1.DataBind();

        }
    }
}