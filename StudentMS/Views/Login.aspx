<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentMS.Views.Login" EnableEventValidation="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Login page for Student Management System">
    <title>Login - Student Management System</title>
    <script type="text/javascript">
        function showAlertAndRedirect(url) {
            alert("Logged in Successfully");
            window.location.href = url;
        }
    </script>
    <link rel="stylesheet" href="../Libs/Bootstrap/css/bootstrap.min.css" />
</head>
<body>
    <header class="container-fluid">
        <div class="row" style="height:120px"></div>
    </header>
    <main class="container-fluid">
        <div class="row">
            <div class="col-md-4"></div>
            <section class="col-md-5">
                <h1 class="text-center">Student Management System</h1>
                <form id="form1" runat="server" class="needs-validation" novalidate>
                    <div class="mb-3">
                        <label for="EmailTb" class="form-label">Email address</label>
                        <input type="email" class="form-control" id="EmailTb" runat="server" required placeholder="Your Email Address" aria-label="Email address">
                        <div class="invalid-feedback">Please enter a valid email address.</div>
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label">Password</label>
                        <input type="password" class="form-control" id="PasswordTb" placeholder="Password" runat="server" required aria-label="Password">
                        <div class="invalid-feedback">Please enter your password.</div>
                    </div>
                    <div class="mb-3">
                        <label for="RoleCb" class="form-label">Role</label>
                        <asp:DropDownList ID="RoleCb" runat="server" class="form-control" aria-label="Select Role">
                            <asp:ListItem>--Select Role--</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>Student</asp:ListItem>
                            <asp:ListItem>Teacher</asp:ListItem>
                        </asp:DropDownList>
                        <div class="invalid-feedback">Please select a role.</div>
                    </div>
                    <div class="d-grid">
                        <label runat="server" id="ErrMsg" class="text-danger"></label>
                        <asp:Button ID="submit" runat="server" Text="Login" class="btn btn-primary btn-block" OnClick="submit_Click" />
                    </div>
                </form>
            </section>
            <div class="col-md-3"></div>
        </div>
    </main>
</body>
</html>
