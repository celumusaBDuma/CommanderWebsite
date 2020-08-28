<%@ Page Title="Register an external login" Language="C#" AutoEventWireup="true" CodeBehind="RegisterExternalLogin.aspx.cs" Inherits="CommanderWebsite.Account.RegisterExternalLogin" Async="true" %>

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
   
                    <p class="text-danger">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>
                    <div id="error-div" class="text-danger"> </div>
                    
                  
    <asp:PlaceHolder ID="RegExtLog" runat="server">
            
            <hr />
            <asp:ValidationSummary runat="server" ShowModelStateErrors="true" CssClass="text-danger" />
            <p class="text-info">
                You've authenticated with <strong><%: ProviderName %></strong>. Please enter an email below for the current site
                and click the Sign Up button.
            </p>
        <div class="form-horizontal" style="text-align:left">
            

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="email" CssClass=" control-label">Email</asp:Label>
                <div class="">
                    <asp:TextBox runat="server" ID="email" CssClass="form-control" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="email"
                        Display="Dynamic" CssClass="text-danger" ErrorMessage="Email is required" />
                    <asp:ModelErrorMessage runat="server" ModelStateKey="email" CssClass="text-error" />
                </div>
            </div>
            <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="Password" CssClass=" control-label">Password</asp:Label>
                            <div class="">
                                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                                    CssClass="text-danger" ErrorMessage="The password field is required." />
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass=" control-label">Confirm password</asp:Label>
                            <div class="">
                                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            </div>
                        </div>
            <div class="form-group">
                <div class="" style="text-align:center">
                    <asp:Button runat="server" Text="Sign Up" style="border: 2px solid black;color:black; font-weight:bold;background-color:white" CssClass="btn btn-default" OnClick="LogIn_Click" />
                </div>
            </div>
        </div>
    </asp:PlaceHolder>
                    <asp:PlaceHolder runat="server" ID="ConfirmEmail" Visible="false">
                        <div style="text-align:center">
                            <p class="text-success">Email sent, please check your inbox to confirm your account</p>
                        </div>
                    </asp:PlaceHolder>
                    
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
