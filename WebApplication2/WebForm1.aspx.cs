using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity.Migrations;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserDBContext ub = new UserDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ub.Users.Add(new User_Working("marian", "marian", 0));
            //ub.SaveChanges();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<User_Working> LOGIN = ub.Users.ToList();
            for (int i = 0; i < LOGIN.Count(); i++)
                if (TextBox1.Text == LOGIN.ElementAt(i).username)
                    if(TextBox2.Text== LOGIN.ElementAt(i).password)
                {
                    Response.Redirect("AfterLogin.aspx?x=" + LOGIN.ElementAt(i).userType.ToString());
                }

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}