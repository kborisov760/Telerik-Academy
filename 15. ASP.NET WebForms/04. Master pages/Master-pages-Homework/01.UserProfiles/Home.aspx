<%@ Page Title="Home" Language="C#" MasterPageFile="~/UserProfiles.Master" 
    AutoEventWireup="true" CodeBehind="Home.aspx.cs" 
    Inherits="_01.UserProfiles.Home" %>

<asp:Content ID="ContentHeader" runat="server" ContentPlaceHolderID="head">
    
</asp:Content>

<asp:Content ID="ContentMain" runat="server" ContentPlaceHolderID="ContentPlaceHolderMain">
    <div class="jumbotron">
        <h1>Home</h1>
        <p>Welcome to our great web site!</p>
        <hr />
        <p>Here, you can meet great minions from all over the world!</p>
    </div>
</asp:Content>
