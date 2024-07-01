<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentMS.Views.Guest.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Management System</title>
    <link rel="stylesheet" href="../../Libs/Bootstrap/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container-fluid">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Home</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarContent" aria-controls="navbarContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link" href="#">Students</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Teachers</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="../Login.aspx">Login</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="row mt-4">
            <div class="col-md-2">
            </div>
            <div class="col-md-8 text-center">
                <h2>Student Management System</h2>
                <p class="lead">Easily ADD, EDIT, and DELETE Data</p>
                <button class="btn btn-primary">Let's Get Started</button>
            </div>
            <div class="col-md-2">
            </div>
        </div>

        <div class="row bg-primary text-light py-5 mt-4">
            <div class="col-md-3 offset-md-2 bg-light text-dark p-4 rounded shadow">
                <h5 class="text-center">Students</h5>
                <p class="text-center">There are a lot of students from various regions.</p>
            </div>
            <div class="col-md-3 offset-md-2 bg-light text-dark p-4 rounded shadow">
                <h5 class="text-center">Teachers</h5>
                <p class="text-center">Teachers from top-class institutes will be teaching you here.</p>
            </div>
        </div>
    </div>
</body>
</html>
