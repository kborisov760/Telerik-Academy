<%@ Page Language="C#" MasterPageFile="~/UserProfiles.Master"
    AutoEventWireup="true" CodeBehind="Friends.aspx.cs"
    Inherits="_01.UserProfiles.Friends" %>

<asp:Content ID="ContentHeader" runat="server" ContentPlaceHolderID="head">
    <meta name="author" content="Nakov" />
</asp:Content>

<asp:Content ID="ContentMain" runat="server" ContentPlaceHolderID="ContentPlaceHolderMain">
   <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <h3>Name: Dave</h3>
                <br />
                <h3>Eye color: Brown</h3>
                <br />
                <h3>Hair color: Black</h3>
                <br />
                <h3>Formerly known as: Rocket launcher master</h3>
                <br />
            </div>
            <div class="col-md-6">
                <img style="max-width:100%; max-height: 100%" src="images/friend1.png" />
            </div>
        </div>
    </div>

    <div class="jumbotron">
        <div class="row">
            <div class="col-md-6">
                <h3>Name: Stuart</h3>
                <br />
                <h3>Eye color: Brown</h3>
                <br />
                <h3>Hair color: Black</h3>
                <br />
                <h3>Formerly known as: Guitar hero</h3>
                <br />
            </div>
            <div class="col-md-6">
                <img style="max-width:100%; max-height: 100%" src="images/friend2.png" />
            </div>
        </div>
    </div>
</asp:Content>
