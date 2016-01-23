using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.SimpleGreetingPage
{
    public partial class Greeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sayHiButton_Click(object sender, EventArgs e)
        {
            var currentUsername = userName.Text;
            if(currentUsername.Length <= 1)
            {
                sayHiLabel.ForeColor = System.Drawing.Color.Red;
                sayHiLabel.Text = "Invalid user name!";
            }
            else
            {
                sayHiLabel.ForeColor = System.Drawing.Color.Green;
                sayHiLabel.Text = "Hi, " + currentUsername + "!";
            }
        }
    }
}