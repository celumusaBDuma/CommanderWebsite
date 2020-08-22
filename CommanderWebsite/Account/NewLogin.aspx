<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="NewLogin.aspx.cs" Inherits="CommanderWebsite.Account.newLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta content="text/html; charset=iso-8859-2" http-equiv="Content-Type" />
    <title>Login</title>
     <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
        <link href="Content/Images/Comm.jpg" rel="shortcut icon" type="image/x-icon" />
      <link rel="stylesheet" href="../../Scripts/bootswatch/bootstrap.min.css" />
    <link rel="stylesheet" href="../../Content/animate.css" />
    <link rel="stylesheet" href="../../Content/owl.carousel.min.css" />
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>
</head>
<body>
    <form id="form1" runat="server"  style= "background-image: url('http://localhost:52652/Content/Images/HeftyGorgeousItalianbrownbear-size_restricted.gif'); background-size:cover; background-repeat: no-repeat; background-attachment: fixed; width: 100%; ">
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
            
    <div class="container-fluid" style="margin: 0px; background-position: center center; padding-top: 70px; padding-bottom: 25px; padding-left: 15px; padding-right: 15px;">

    <div class="container thumbnail" style="text-align:center;width:400px; display:flex;  ">
        <div class="row2">
            <section id="loginForm" >
                  
                <div class="form-horizontal">
                    <img src="../Content/Images/CommanderPic.jpg" alt="" style="width:200px; height:200px"/>
   
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                   
                    <div class="">
                        <hr />
                         <div class="col-md-12">
                            <asp:TextBox runat="server" style="border-radius:0;border-bottom: 3px solid black; height:50px;font-size:17px;" ID="Email" placeholder="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    
                        <div class="col-md-12">
                            <asp:TextBox runat="server" style="border-radius:0;border-bottom: 3px solid black; height:50px;font-size:17px;" ID="Password" placeholder="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <div class="">
                        <div style="text-align:left; margin-left: 5px;" >
                            <div class="checkbox">
                                <asp:CheckBox runat="server" ID="RememberMe" />
                                <asp:Label runat="server" AssociatedControlID="RememberMe">Remember me?</asp:Label>
                                
                            </div>
                        </div>
                        
                    </div>
                    <div >
                        <div class="">
                            
                          <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-default" />
                        
                          </div>
                    </div>
                </div>
                <p style="text-align: left">
                    <%-- Enable this once you have account confirmation enabled for password reset functionality
                   Forgot your password? <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Click here</asp:HyperLink>
                    --%>
                </p>
                <p style="text-align: left">
                    Don't have an account? <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Click here</asp:HyperLink>
                </p>
                
            </section>
        <hr />
            <section id="socialLoginForm">
                <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
            </section>
        </div>
    </div>

    </div>
           <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
         <script src="../../Scripts/owl.carousel.min.js"></script>
        <script src="../../Scripts/Bootstrap 3.4.1/js/bootstrap.min.js"></script>
        <script src="../../Scripts/popper.min.js"></script>
    </form>
</body>
</html>
