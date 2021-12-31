<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Apollo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login &mdash; Apollo</title>

<!-- General CSS Files -->
  <link rel="stylesheet" href="assets/modules/bootstrap/css/bootstrap.min.css"/>
  <link rel="stylesheet" href="assets/modules/fontawesome/css/all.min.css"/>

<!-- CSS Libraries -->
  <link rel="stylesheet" href="assets/modules/bootstrap-social/bootstrap-social.css"/>

<!-- Template CSS -->
  <link rel="stylesheet" href="assets/css/style.min.css"/>
 <link rel="stylesheet" href="assets/css/components.min.css"/>

</head>

<body class="layout-4">
    <form id="form1" runat="server">
<div id="app">
    <section class="section">
        <div class="container mt-5">
            <div class="row">
                <div class="col-12 col-sm-8 offset-sm-2 col-md-6 offset-md-3 col-lg-6 offset-lg-3 col-xl-4 offset-xl-4">
                    <div class="login-brand">
                <!--        <img src="http://puffintheme.com/craft/codiepie/dist/assets/img/CodiePie-fill.svg" alt="APOLLO" width="100" class="shadow-light rounded-circle">-->
                        <h4 style="width:100px; text-align:center" class="shadow-light rounded-circle">APOLLO</h4>
                    </div>
                    <div class="card card-primary">
                        <div class="card-header">
                            <h4>Login</h4>
                        </div>
                        <div class="card-body">
                            <div id="form2" class=="needs-validation">
                                 <div class="form-group">
                                     <asp:Label ID="label1" for="name" Text="User Name" runat="server"/>
                                    <asp:TextBox ID="email" CssClass="form-control" tabindex="1" required runat="server"></asp:TextBox>
                                    <div class="invalid-feedback">
                                        Please fill in your username
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="d-block">
                                        <asp:Label ID="label2" CssClass="control-label" Text="Password" runat="server"></asp:Label>
                                    </div>
                                    <asp:TextBox ID="password" type="password" class="form-control" name="password" tabindex="2" required runat="server"/>
                                    <div class="invalid-feedback">
                                        please fill in your password
                                    </div>
                                </div>

                                <div class="form-group">
                                     <asp:Label ID="label3" for="name" Text="Select Role" runat="server"/>
                                    <asp:DropDownList ID="mylist" CssClass="form-control" runat="server" OnSelectedIndexChanged="mylist_SelectedIndexChanged">
                                        <asp:ListItem>ADMIN</asp:ListItem>
                                        <asp:ListItem>STUDENT</asp:ListItem>
                                        <asp:ListItem>TEACHER</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <div class="form-group">
                                    <div class="custom-control custom-checkbox">
                                        <input type="checkbox" name="remember" class="custom-control-input" tabindex="3" id="remember-me">
                                        <label class="custom-control-label" for="remember-me">Remember Me</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Button TabIndex="4" CssClass="btn btn-primary btn-lg btn-block" Text="Login" runat="server" OnClick="Unnamed1_Click" />
                                </div>
                            </div>

                            </div>
                        </div>

                    <div class="simple-footer">
                        Copyright &copy; APOLLO 2021
                    </div>
                    </div>
                </div>
            </div>
        </section>
        </div>
    </form>
    <!-- General JS Scripts -->
<script src="assets/bundles/lib.vendor.bundle.js"></script>
<script src="js/CodiePie.js"></script>

<!-- JS Libraies -->

<!-- Page Specific JS File -->

<!-- Template JS File -->
<script src="js/scripts.js"></script>
<script src="js/custom.js"></script>
</body>
</html>
