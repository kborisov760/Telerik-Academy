<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateNumber.aspx.cs" Inherits="_01.RandomGenerator.GenerateNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter first number:"></asp:Label> &nbsp; <asp:TextBox ID="FirstNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Enter second number:"></asp:Label> &nbsp; <asp:TextBox ID="SecondNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="RandomGeneratorButton" OnClick="RandomGeneratorButton_Click" runat="server" Text="Click to generate number" />
        <hr />
        <h3><asp:Label ID="Label3" runat="server" Text="Random number(s):"></asp:Label> &nbsp; <asp:Label ID="RandomNumberLabel" runat="server"></asp:Label></h3>
        <br />
        <h3>Log history:</h3>
        <hr />
        <h2><asp:Label ID="OutputInfo" runat="server"></asp:Label></h2>
    </div>
    </form>
</body>
</html>
