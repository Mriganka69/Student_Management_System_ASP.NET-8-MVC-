<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="StudentMS.Views.Admin.Students" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
       <div class="row">
           <div class="col-md-3">
               <h2>Students Details</h2>
               <form>
  <div class="mb-3">
    <label for="StudentNameTb" class="form-label">Student Name</label>
    <input type="text" class="form-control" id="StudentNameTb" runat="server" required="required" />
  </div>

    <div class="mb-3">
  <label for="StudentPhoneTb" class="form-label">Student Phone</label>
  <input type="text" class="form-control" id="StudentPhoneTb" runat="server" required="required"/>
</div>

        <div class="mb-3">
  <label for="StudentPhoneTb" class="form-label">Student Address</label>
  <input type="text" class="form-control" id="StudentAddressTb" runat="server" required="required"/>
</div>


<div class="mb-3">
  <label for="StudentEmailTb" class="form-label">Student Email</label>
  <input type="email" class="form-control" id="StudentEmailTb" runat="server" required="required"/>
</div>

<div class="mb-3">
  <label for="StudentGenderTb" class="form-label">Student Gender</label>
    <asp:DropDownList ID="StudentGenderTb" class="form-control" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>
</div>


  <div class="mb-3">
    <label for="PasswordTb" class="form-label">Password</label>
    <input type="text" class="form-control" id="PasswordTb" runat="server" required="required" />
  </div>
 
<label runat="server" id="ErrMsg" class="text-danger"></label><br />

  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
  <asp:Button ID="Button1" runat="server" Text="Save" class="btn btn-primary" OnClick="Button1_Click" />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click" />


</form>
           </div>
           <div class="col-md-9">
               <div class="row">
                   <div class="col">
                       
                   </div>
               </div>
               <div class="row">
                   <div class="col">
                        <h1>ALL Students Database</h1>
                       <asp:GridView ID="StudentsGV" class="table table-hover" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateSelectButton="True" OnSelectedIndexChanged="StudentsGV_SelectedIndexChanged">
                           <FooterStyle BackColor="White" ForeColor="#000066" />
                           <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                           <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                           <RowStyle ForeColor="#000066" />
                           <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                           <SortedAscendingCellStyle BackColor="#F1F1F1" />
                           <SortedAscendingHeaderStyle BackColor="#007DBB" />
                           <SortedDescendingCellStyle BackColor="#CAC9C9" />
                           <SortedDescendingHeaderStyle BackColor="#00547E" />
                        </asp:GridView>
                    </div>
               </div>
            </div>

       </div>
   </div>
</asp:Content>
