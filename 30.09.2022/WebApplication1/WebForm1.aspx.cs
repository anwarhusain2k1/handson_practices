using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.SetActiveView(View2);
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtpass.Text == txtusername.Text + "@123")
            {
                HttpCookie cookie = new HttpCookie("username");
                cookie.Expires = DateTime.Now.AddMinutes(2);
                cookie.Values.Add("usrname", txtusername.Text);
                Response.Cookies.Add(cookie);
                Response.Redirect("welcomepage.aspx");
            }
            else
            {
                Response.Write("userid or password is worng");
                MultiView1.SetActiveView(View2);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("username");
            cookie.Values.Add("usrname", TextBox6.Text+TextBox7.Text);
            Response.Cookies.Add(cookie);
            Response.Redirect("welcomepage.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View3);
        }
    }
}