<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="_02.StudentsAndCourses.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Student registration form:</h1>
        <hr />
        <asp:Label ID="FirstNameLabel" runat="server" Text="First name:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LastNameLabel" runat="server" Text="Last name:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="FacultyNumberLabel" runat="server" Text="Faculty number:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="FacultyNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="UniversityLabel" runat="server" Text="University:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:DropDownList ID="UniversityDropDown" runat="server">
            <asp:ListItem Value="1">New Bulgarian University</asp:ListItem>
            <asp:ListItem Value="2">Sofia University "St. Kliment Ohridski"</asp:ListItem>
            <asp:ListItem Value="3">Technical University of Sofia</asp:ListItem>
            <asp:ListItem Value="4">LTU</asp:ListItem>
            <asp:ListItem Value="5">Varna Free University</asp:ListItem>
            <asp:ListItem Value="6">Veliko Turnovo University</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="SpecialityLabel" runat="server" Text="Speciality:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:DropDownList ID="SpecialityDropDown" runat="server">
            <asp:ListItem Value="1">Computer Science</asp:ListItem>
            <asp:ListItem Value="2">Landscape Architecture</asp:ListItem>
            <asp:ListItem Value="3">Medicine</asp:ListItem>
            <asp:ListItem Value="4">Finance</asp:ListItem>
            <asp:ListItem Value="5">Iconomy</asp:ListItem>
            <asp:ListItem Value="6">National Security</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="CoursesLabel" runat="server" Text="Courses:"></asp:Label> &nbsp;&nbsp;
        <br />
        <br />
        <asp:CheckBoxList ID="CoursesCheckBoxList" runat="server">
            <asp:ListItem Value="1">Programming with C#</asp:ListItem>
            <asp:ListItem Value="1">Biology</asp:ListItem>
            <asp:ListItem Value="1">Anatomy</asp:ListItem>
            <asp:ListItem Value="1">Management</asp:ListItem>
            <asp:ListItem Value="1">Law</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit student" OnClick="SubmitStudentButton_Click"/>
        <br />
        <hr />
        <h2>Summary</h2>
        <asp:Literal ID="LiteralResult" runat="server" />
    </div>
    </form>
</body>
</html>
