<%@ Page Title="Register an external login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterExternalLoginOld.aspx.cs" Inherits="CommanderWebsite.Account.RegisterExternalLoginOld" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<h3>Register with your <%: ProviderName %> account</h3>

    <asp:PlaceHolder runat="server">
        <div class="form-horizontal">
            <h4>Association Form</h4>
            <hr />
            <asp:ValidationSummary runat="server" ShowModelStateErrors="true" CssClass="text-danger" />
            <p class="text-info">
                You've authenticated with <strong><%: ProviderName %></strong>. Please enter an email below for the current site
                and click the Log in button.
            </p>

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
                <div class="">
                    <asp:Button runat="server" Text="Log in" CssClass="btn btn-default" OnClick="LogIn_Click" />
                </div>
            </div>
        </div>
    </asp:PlaceHolder>
</asp:Content>
