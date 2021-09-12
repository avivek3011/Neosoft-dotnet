<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><asp:Label ID="lbl_txt" runat="server" Text=""></asp:Label></h1>
        <h2> Welcome to Pet store App</h2>
        <asp:Button ID ="btnLogout" runat="server" Text ="LogOut" OnClick="btnLogout_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Home Page</h2>
            <p>
               All about cats
            </p>           
        </div>
        <div>
            
        </div>
    </div>

</asp:Content>
