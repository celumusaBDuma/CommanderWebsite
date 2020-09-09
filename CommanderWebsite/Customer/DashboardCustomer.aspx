<%@ Page Title="" Language="C#" MasterPageFile="Customer.Master" AutoEventWireup="true" CodeBehind="DashboardCustomer.aspx.cs" Inherits="CommanderWebsite.Customer.DashboardCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height: 1024px">
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Dashboard"></asp:Label>
        <br />
        <br />
        
        <div style="float:left;width:20%;">
        <asp:Image ID="Image1" ImageUrl="~/Content/Images/noImage.png" CssClass="thumbnail" Width="400px" Height="300px" runat="server" />
 </div><div style="float:left;width:80%; text-align:left; font-size:xx-large"> <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Hello, Welcome"></asp:Label>
&nbsp;<asp:Label ID="Label3" Font-Size="Larger" runat="server"></asp:Label></div>

        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
    <p>
        <br />
    </p>
</asp:Content>
