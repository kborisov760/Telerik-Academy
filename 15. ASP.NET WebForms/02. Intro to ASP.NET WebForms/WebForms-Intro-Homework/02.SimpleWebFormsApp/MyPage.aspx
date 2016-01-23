<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="_02.SimpleWebFormsApp.MyPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Here is "Hello" from .aspx file:</h1> &nbsp;&nbsp; 
    <h2>Hello, ASP.NET!</h2>
    <br />
    <hr />
    <h1>Here is "Hello" from C# file:</h1> &nbsp;&nbsp; 
    <h2><asp:Label ID="helloLabel" runat="server"></asp:Label></h2>
    <br />
    <hr />
    <h1>Current assembly location:</h1> &nbsp;&nbsp; 
    <h2><asp:Label ID="assemblyLocationLabel" runat="server"></asp:Label></h2>
</asp:Content>
