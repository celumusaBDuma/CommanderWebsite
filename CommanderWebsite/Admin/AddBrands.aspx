<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddBrands.aspx.cs" Inherits="CommanderWebsite.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="min-height:1024px;text-align:center">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Brands" Font-Bold="True"></asp:Label>
        <br />
        <table class="row2">
            <tr>
                <td>Brand Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="display:none;">
                <td>Admin ID</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Brand Description</td>
                <td>
                    <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Height="185px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Brand Picture</td>
                <td class="auto-style2">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" CssClass="btn btn-default" OnClick="Button1_Click" style="text-align:left" runat="server" Text="Add Brand" />
               <asp:Label ID="Label2" runat="server" Text=""></asp:Label> </td>
            </tr>
        </table>
        <br />
    </div>
    
</asp:Content>
