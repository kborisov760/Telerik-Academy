using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.SimpleWebFormsApp
{
    public partial class MyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello, ASP.NET!";
            assemblyLocationLabel.ForeColor = System.Drawing.Color.BlueViolet;
            assemblyLocationLabel.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}