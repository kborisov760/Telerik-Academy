<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greeting.aspx.cs" Inherits="_01.SimpleGreetingPage.Greeting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello user</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="nameLabel" runat="server" Text="Enter your name: "></asp:Label> &nbsp;&nbsp;
        <asp:TextBox ID="userName" runat="server"></asp:TextBox>
        <hr />
        <asp:Button ID="sayHiButton" runat="server" Text="Press to greet" OnClick="sayHiButton_Click" />
        <br />
        <br />
        <h1><asp:Label ID="sayHiLabel" runat="server"></asp:Label></h1>
    </div>
    </form>
</body>
</html>
