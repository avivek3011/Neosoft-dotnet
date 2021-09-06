<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Web.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <br><br><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox for="Label1" ID="TextBox1" runat="server"></asp:TextBox><br><br>

    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
    <asp:TextBox for="Label2" ID="TextBox2" runat="server"></asp:TextBox><br><br>

    <asp:Label ID="Label3" runat="server" Text="Zipcode"></asp:Label>
    <asp:TextBox for="Label3" ID="TextBox3" runat="server"></asp:TextBox><br><br>

    <asp:Label ID="Label4" runat="server" Text="UserName"></asp:Label>
    <asp:TextBox for="Label4" ID="TextBox4" runat="server"></asp:TextBox><br><br>

    <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
    <asp:TextBox for="Label5" ID="TextBox5" runat="server"></asp:TextBox><br><br>

    <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
</asp:Content>
