using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.StudentsAndCourses
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitStudentButton_Click(object sender, EventArgs e)
        {
            this.LiteralResult.Text
                += "First name: " + FirstNameTextBox.Text + "<br />"
                + "Last name: " + LastNameTextBox.Text + "<br />"
                + "Faculty number: " + FacultyNumberTextBox.Text + "<br />"
                + "University: " + UniversityDropDown.SelectedItem.Text + "<br />"
                + "Speciality: " + SpecialityDropDown.SelectedItem.Text + "<br />"
                + "Courses: ";
            
            foreach (ListItem item in this.CoursesCheckBoxList.Items)
            {
                if(item.Selected)
                {
                    this.LiteralResult.Text += item.Text + ", ";
                }
            }

            this.LiteralResult.Text = this.LiteralResult.Text.Remove(this.LiteralResult.Text.Length - 2, 2);

            this.LiteralResult.Text += "<br /> <br /> <hr /> <br />";
        }
    }
}