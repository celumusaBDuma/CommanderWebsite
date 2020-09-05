<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="CommanderWebsite.Admin.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 45px;
        }
    </style>    
    <div style="text-align:center">
        <h2 style="text-align:center">Add Products</h2>
        <br />
        <table class="auto-style1" style="text-align:left">
            <tr>
                <td>Product</td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Type</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Description</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Quantity</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Product Size</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Product Price</td>
                <td>
                    <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Upload Image</td>
                <td class="auto-style3">
                    <div style="width:300px;">
                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                   </div>
                    <br />
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style3">Category ID</td>
                <td class="auto-style3">
                    <div style="width:150px;">
                    <asp:DropDownList ID="DropDownList1" class="form-control" runat="server">
                        
                    </asp:DropDownList></div>
                </td>
            </tr>
            <tr style="visibility:hidden;">
                <td class="auto-style3">Admin ID</td>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" CssClass="btn btn-default" runat="server" OnClick="Button1_Click" Text="Add Product" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
</asp:Content>
