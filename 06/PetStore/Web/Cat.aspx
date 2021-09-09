<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Cat.aspx.cs" Inherits="Web.Cat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Cats Page</h1>
        </div>
    <div>
        <form>
          <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter the name of the cat"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Dob" ID="lbl_Dob" runat="server" Text="Date of Birth" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Dob" runat="server" class="form-control" placeholder="dd/mm/yyyy"></asp:TextBox>
            </div>
          </div>
            <div class="form-group row">
              <asp:Label for="Gender" ID="lbl_Gender" runat="server" Text="Gender" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:RadioButtonList ID="rbl_Gender" runat="server">
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
          </div>
            <div class="form-group row">
                <asp:Label for="Gender" ID="lbl_CatType" runat="server" Text="Cat type" class="col-sm-2 col-form-label"></asp:Label>
                <div class="col-sm-10">
                    <asp:DropDownList ID="dd_CatType" class="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="form-group row">
                <asp:Label for="Gender" ID="lbl_FurType" runat="server" Text="Fur Type" class="col-sm-2 col-form-label"></asp:Label>
                <div class="col-sm-10">
                    <asp:DropDownList ID="dd_FurType" class="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
          <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Add" OnClick="btn_Add_Click" />
                <asp:Button ID="btn_fromDb" class="btn btn-primary" runat="server" Text="Load Data From Database" OnClick="btn_fromDb_Click" />
            </div>
              <asp:GridView ID="gv_cats" runat="server" BackColor="WhiteSmoke" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" OnRowEditing="gv_cats_RowEditing" OnRowCancelingEdit="gv_cats_RowCancelingEdit" OnRowUpdating="gv_cats_RowUpdating" OnRowDeleting="gv_cats_RowDeleting">
                  <Columns>
                      <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                      <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                      <asp:BoundField DataField="Dob" HeaderText="Dob" SortExpression="Dob" />
                      <asp:BoundField DataField="GenderId" HeaderText="GenderId" SortExpression="GenderId" />
                      <asp:BoundField DataField="CatType" HeaderText="CatType" SortExpression="CatType" />
                      <asp:BoundField DataField="FurType" HeaderText="FurType" SortExpression="FurType" />
                      <asp:CommandField ShowDeleteButton="true" ShowEditButton="true"/>
                  </Columns>
              </asp:GridView>
              <br />
              <asp:Button ID="btn_updateDB" class="btn btn-primary" runat="server" Text="Update in DataBase" OnClick="btn_updateDB_Click" />
          </div>

            <asp:Label ID="lbl_Display" runat="server" Text=""></asp:Label>
    </form>
    </div>

</asp:Content>        
