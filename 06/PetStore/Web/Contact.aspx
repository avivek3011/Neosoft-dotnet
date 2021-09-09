<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <form>
        <div class="form-group row">
            <asp:Label ID="lbl_Name" class="col-sm-2 col-form-label" runat="server" Text="Label" AssociatedControlID="tb_email"></asp:Label>
            <div class="col-sm-10">
                <span class="mandatory">*</span>
                <asp:TextBox ID="tb_email"  class="form-control" placeholder="Email" onblur="checkNullOrEmpty(this);" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="tb_query" class="col-sm-2 col-form-label">Query</label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_query" TextMode="MultiLine" class="form-control" onblur="checkNullOrEmpty(this);" placeholder="please enter your query here" runat="server" Columns="10" MaxLength="500" Rows="10"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Submit" runat="server" class="btn btn-primary" Text="Submit" />
            </div>
        </div>
    </form>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
