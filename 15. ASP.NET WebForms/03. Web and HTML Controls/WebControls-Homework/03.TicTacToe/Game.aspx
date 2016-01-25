<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="_03.TicTacToe.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .bgBtnX {
            background-image: url("/images/x.png");
            
        }

        .bgBtnY {
            background-image: url("/images/y.png");
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to TicTacToe</h1>
        <hr />
        <asp:Label ID="userNameLabel" runat="server" Text="Enter your name:"></asp:Label>
        <br />
        <asp:TextBox ID="userNameTextBox" runat="server"></asp:TextBox>
        <hr />
        <asp:Label ID="firstPlayerResult" runat="server"></asp:Label>
        <asp:Label ID="computerResult" runat="server"></asp:Label>
        <asp:Table ID="MainGameField" runat="server">
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
