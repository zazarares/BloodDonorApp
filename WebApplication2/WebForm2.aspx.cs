using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        UserDBContext ub = new UserDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                Label5.Text = "Error";
            Label5.ForeColor = System.Drawing.Color.DarkRed;
            }
            else
            {
                List<User_Working> LOGIN= ub.Users.ToList();
                bool ok = true;
                for (int i = 0; i < LOGIN.Count(); i++)
                    if (TextBox1.Text == LOGIN.ElementAt(i).username)
                    {
                        Label5.Text = "Error";
                        Label5.ForeColor = System.Drawing.Color.DarkRed;
                        ok = false;
                    }
                if (ok)
                {
                    User_Working u = new User_Working(TextBox1.Text, TextBox4.Text, 2);
                    ub.Users.Add(u);
                    ub.Admins.Add(new Admin());
                    ub.Doctors.Add(new Doctor());
                    ub.Donators.Add(new Donator(u.id, TextBox5.Text, TextBox3.Text, TextBox4.Text, TextBox6.Text, TextBox7.Text));
                    ub.SaveChanges();
                }

            }
        }
    }
}