<%@ Page Language="C#" MasterPageFile="~/UserProfiles.Master" 
    AutoEventWireup="true" CodeBehind="Profile.aspx.cs" 
    Inherits="_01.UserProfiles.Profile" %>

<asp:Content ID="ContentHeader" runat="server" ContentPlaceHolderID="head">
    <meta name="author" content="Nakov" />
</asp:Content>

<asp:Content ID="ContentMain" runat="server" ContentPlaceHolderID="ContentPlaceHolderMain">
    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <h3>Name: Bob</h3>
                <br />
                <h3>Eye color: Green and Brown</h3>
                <br />
                <h3>Hair color: Bald</h3>
                <br />
                <h3>Formerly known as: King Bob</h3>
                <br />
            </div>
            <div class="col-md-6">
                <img style="max-width:100%; max-height: 100%" src="images/profile.png" />
            </div>
        </div>
    </div>
</asp:Content>
