<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="_02.AspSumator.Sum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Summator</h1>
    <hr />
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="firstNumber">First number</asp:Label>
        &nbsp &nbsp
        <asp:TextBox runat="server" ID="firstNumTextBox"></asp:TextBox>
        <br />
        <asp:Label runat="server" ID="secondNumber">Second number</asp:Label>
        &nbsp
        <asp:TextBox runat="server" ID="secondNumTextBox"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="sumButton" Text="Check Sum" OnClick="buttonCalculateSum"/>
        <br />
        <br />
        Sum: <asp:TextBox runat="server" ID="sumResultTextBox"></asp:TextBox>
    </div>
    </form>
</body>
</html>
