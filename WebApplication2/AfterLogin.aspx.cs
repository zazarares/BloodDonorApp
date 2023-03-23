using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class AfterLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string type = Request.QueryString["x"].ToString();
            int tip = int.Parse(type);
            switch(tip)
            {
                case 0:
                    Label1.Text = "Esti logat ca si admin";
                    break;
                case 1:
                    Label1.Text = "Esti logat ca si doctor";
                    break;
                case 2:
                    Label1.Text = "Esti logat ca si donator";
                    break;
            }
        }
    }
}