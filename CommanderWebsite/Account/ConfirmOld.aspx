<%@ Page Title="Account Confirmation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmOld.aspx.cs" Inherits="CommanderWebsite.Account.ConfirmOld" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successPanel" ViewStateMode="Disabled" Visible="true">
            <div style="max-height:1024px;">
            <p style="text-align:center;margin-top: 50px;">
                Thank you for confirming your account. Click <asp:HyperLink ID="login" runat="server" NavigateUrl="~/Account/Login">here</asp:HyperLink>  to login             
            </p></div>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="errorPanel" ViewStateMode="Disabled" Visible="false">
            <p class="text-danger">
                An error has occurred.
            </p>
        </asp:PlaceHolder>
    </div>
</asp:Content>
