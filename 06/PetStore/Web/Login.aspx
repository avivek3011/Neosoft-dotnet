<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <webopt:BundleReference runat="server" Path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-12 form-group row">
            <div>
                <asp:TextBox ID="txt_UserName" runat="server" placeholder="User Name" class="form-control"></asp:TextBox>
            </div>
            <br />
            <div >
                <asp:TextBox ID="txt_Password" runat="server" placeholder="Password" class="form-control"></asp:TextBox>
            </div>

            <br />

            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Login" Class="btn btn-primary" />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="SignUp" Class="btn btn-primary"/>
        </div>
        <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
