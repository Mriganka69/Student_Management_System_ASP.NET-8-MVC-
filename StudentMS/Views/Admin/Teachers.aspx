<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Teachers.aspx.cs" Inherits="StudentMS.Views.Admin.Teachers" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
       <div class="container-fluid">
       <div class="row">
           <div class="col-md-3">
               <h2>Teachers Details</h2>
               <form>
  <div class="mb-3">
    <label for="TeacherNameTb" class="form-label">Teacher Name</label>
    <input type="text" class="form-control" id="TeacherNameTb" runat="server" required="required"/>
  </div>

    <div class="mb-3">
  <label for="TeacherPhoneTb" class="form-label">Teacher Phone</label>
  <input type="text" class="form-control" id="TeacherPhoneTb" runat="server" required="required" />
</div>

        <div class="mb-3">
  <label for="TeacherAddressTb" class="form-label">Teacher Address</label>
  <input type="text" class="form-control" id="TeacherAddressTb" runat="server" required="required"/>
</div>


<div class="mb-3">
  <label for="TeacherEmailTb" class="form-label">Teacher Email</label>
  <input type="email" class="form-control" id="TeacherEmailTb" runat="server" required="required"/>
</div>

<div class="mb-3">
  <label for="TeacherGenderTb" class="form-label">Teacher Gender</label>
  <input type="text" class="form-control" id="TeacherGenderTb" runat="server" required="required"/>
</div>


  <div class="mb-3">
    <label for="PasswordTb" class="form-label">Password</label>
    <input type="text" class="form-control" id="PasswordTb" runat="server" required="required"/>
  </div>

<label runat="server" id="ErrMsg" class="text-danger"></label><br />

  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click"/>
  <asp:Button ID="Button1" runat="server" Text="Save" class="btn btn-primary" OnClick="Button1_Click"/>
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" OnClick="DeleteBtn_Click"/>

  


</form>
           </div>
           <div class="col-md-9">
               <div class="row">
                   <div class="col">
                       
                   </div>
               </div>
               <div class="row">
                   <div class="col">
                        <h1>All Teachers Database</h1>
                       <asp:GridView ID="TeachersGV" class="table table-hover" runat="server" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="TeachersGV_SelectedIndexChanged">
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