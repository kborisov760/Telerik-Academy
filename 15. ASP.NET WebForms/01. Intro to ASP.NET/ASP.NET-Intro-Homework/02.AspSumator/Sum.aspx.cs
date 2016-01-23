using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.AspSumator
{
    public partial class Sum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonCalculateSum(object sender, EventArgs e)
        {
            try
            {
                var firstNumber = decimal.Parse(this.firstNumTextBox.Text);
                var secondNumber = decimal.Parse(this.secondNumTextBox.Text);
                var sum = firstNumber + secondNumber;
                this.sumResultTextBox.Text = sum.ToString();
            }
           catch(Exception ex)
            {
                this.sumResultTextBox.Text = ex.Message;
            }
        }
    }
}