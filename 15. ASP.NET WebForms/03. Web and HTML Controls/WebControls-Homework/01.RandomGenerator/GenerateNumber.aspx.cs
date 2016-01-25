using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RandomGenerator
{
    public partial class GenerateNumber : System.Web.UI.Page
    {
        private static List<int> allNumbers = new List<int>();
        private Random randomNumber = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RandomGeneratorButton_Click(object sender, EventArgs e)
        {
            try
            {
                var firstNumber = int.Parse(FirstNumberTextBox.Text);
                var secondNumber = int.Parse(SecondNumberTextBox.Text);
                var currentRandom = randomNumber.Next(firstNumber, secondNumber);

                if (!allNumbers.Contains(currentRandom))
                {
                    allNumbers.Add(currentRandom);
                    RandomNumberLabel.ForeColor = System.Drawing.Color.Green;
                    RandomNumberLabel.Text += currentRandom + " | ";
                }
                else
                {
                    OutputInfo.ForeColor = System.Drawing.Color.Red;
                    OutputInfo.Text += "Current generated number already exist, please push the button again! <br/>";
                }
            }
            catch(Exception ex)
            {
                OutputInfo.ForeColor = System.Drawing.Color.Purple;
                OutputInfo.Text += "Range was not in the correct format! <br/>";
            }
        }
    }
}