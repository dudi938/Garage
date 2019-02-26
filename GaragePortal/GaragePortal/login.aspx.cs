using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GaragePortal
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            string user = tb_userName.Text;
            string pass = tb_password.Text;
            Console.WriteLine("Login with <User name>:{0}, <Password>:  {1}", user, pass);

            bool success = client.LogIn(user, pass);

            
            if (success)
            {
                Response.Redirect("ControlPanel.aspx");
            }

        }

    }
}