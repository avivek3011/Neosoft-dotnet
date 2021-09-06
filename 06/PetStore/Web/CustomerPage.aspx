<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="CustomerPage.aspx.cs" Inherits="Web.CustomerPage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter the name of the cat"></asp:TextBox>
            </div>
          </div>
         <div class="form-group row">
              <asp:Label for="tb_Email" ID="lbl_Email" runat="server" Text="Email" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Email" runat="server" class="form-control" placeholder="Please enter email"></asp:TextBox>
            </div>
          </div>
         <div class="form-group row">
              <asp:Label for="tb_Zip" ID="lbl_Zip" runat="server" Text="Zip Code" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Zip" runat="server" class="form-control" placeholder="Please enter zip code"></asp:TextBox>
            </div>
          </div>
         <div class="form-group row">
              <asp:Label for="tb_UserName" ID="lbl_Username" runat="server" Text="UserName" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_UserName" runat="server" class="form-control" placeholder="Please enter username"></asp:TextBox>
            </div>
          </div>
         <div class="form-group row">
              <asp:Label for="tb_Password" ID="lbl_Password" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Password" runat="server" class="form-control" placeholder="Please enter the password"></asp:TextBox>
            </div>
          </div>
        <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Signup" class="btn btn-primary" runat="server" Text="Signup" OnClick="btn_Signup_Click"/>
            </div>
           </div>
    </form>
   
</asp:Content>

