<%@ Page Title="Forgot password" Language="C#" AutoEventWireup="true" CodeBehind="Forgot.aspx.cs" Inherits="CommanderWebsite.Account.ForgotPassword" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta content="text/html; charset=iso-8859-2" http-equiv="Content-Type" />
    <title>Register</title>
     <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <link href="Content/Images/Comm.jpg" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="../../Scripts/bootswatch/bootstrap.min.css" />
    <link rel="stylesheet" href="../../Content/animate.css" />
    <link rel="stylesheet" href="../../Content/owl.carousel.min.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server" style= "background-image: url('http://localhost:52652/Content/Images/HeftyGorgeousItalianbrownbear-size_restricted.gif'); background-size:cover; background-repeat: no-repeat; background-attachment: fixed; width: 100%; min-height:1024px; ">
        <asp:ScriptManager runat="server">
                <Scripts>
                    <%--To learn more about bundling scripts in ScriptManager see http://go.microsoft.com/fwlink/?LinkID=301884 --%>
                    <%--Framework Scripts--%>
                    <asp:ScriptReference Name="MsAjaxBundle" />
                    <asp:ScriptReference Name="jquery" />
                    <asp:ScriptReference Name="bootstrap" />
                    <asp:ScriptReference Name="respond" />
                    <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                    <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                    <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                    <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                    <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                    <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                    <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                    <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                    <asp:ScriptReference Name="WebFormsBundle" />
                    <%--Site Scripts--%>
                </Scripts>
            </asp:ScriptManager>
            
        <div class="container-fluid" style="margin: 0px; background-position: center center; padding-top: 50px; padding-bottom: 25px; padding-left: 15px; padding-right: 15px;">

            <div class="container thumbnail" style="text-align:center;width:400px;  padding-bottom: 20px ">
                <div class="row2" style="padding-left:15px;padding-right:15px;">
                     <img src="../Content/Images/CommanderPic.jpg" alt="" style="width:200px; height:200px"/>
   
                    <h2><%: Title %></h2>
                    <p class="text-danger">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>
                    <div id="error-div" class="text-danger"> </div>
                    
                      <div class="row">
                            <div class="col-md-8">
                                <asp:PlaceHolder id="loginForm" runat="server">
                                    <div class="form-horizontal">
                                        <h4>Forgot your password?</h4>
                                        <hr />
                                        <asp:PlaceHolder runat="server" ID="PlaceHolder1" Visible="false">
                                            <p class="text-danger">
                                                <asp:Literal runat="server" ID="FailureText" />
                                            </p>
                                        </asp:PlaceHolder>
                                        <div class="form-group">
                                            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                                            <div class="col-md-10">
                                                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                                    CssClass="text-danger" ErrorMessage="The email field is required." />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-md-offset-2 col-md-10">
                                                <asp:Button runat="server" OnClick="Forgot" Text="Email Link" style="border: 2px solid black;color:black; font-weight:bold;background-color:white" CssClass="btn btn-default" />
                                            </div>
                                        </div>
                                    </div>
                                </asp:PlaceHolder>
                                <asp:PlaceHolder runat="server" ID="DisplayEmail" Visible="false">
                                    <p class="text-info" style="text-align:center">
                                        Please check your email to reset your password.
                                    </p>
                                </asp:PlaceHolder>
                            </div>
                        </div>
                    
                </div>
            </div>
        </div>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="../Scripts/owl.carousel.min.js"></script>
        <script src="../Scripts/Bootstrap 3.4.1/js/bootstrap.min.js"></script>
        <script src="../Scripts/popper.min.js"></script>
    </form>
</body>
</html>