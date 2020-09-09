<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductsView.aspx.cs" Inherits="CommanderWebsite.Admin.ProductsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center"  style=" width: 100%; min-height:1024px;">
    <div class="container" style="padding-top:50px; ">
        <div align="center" style="width: 100%">
            <div  style="float: left; width: 35%; height: 357px;">
            <br />
            <br />
                <div style="max-width:100%" class="thumbnail">

                <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                        
                   
                    <div class="carousel-inner" role="listbox">
                        
                            <div class="item active">
                            
                                 <asp:Image ID="im" ImageUrl="~/Content/Images/noImage.png"  Width="100%" Height="500px"
                                     runat="server" ImageAlign="Middle" CssClass="img-responsive"></asp:Image>
                                <div class="carousel-caption"></div>
                            </div>
                        
                    </div>
                    </div>
                    </div>
                </div>
                <br />
                <br />
            
                <div style="float: left; width: 50%; margin-left: 70px;">
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
        <h2 style="text-align:center">Update Product</h2>
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
                    <asp:Button ID="Button1" CssClass="btn btn-default" runat="server" OnClick="Button1_Click" Text="Update Product" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
                </div>
                
                
                
                
                
                
                
                <br />
            </div>   
            <br />
                 
        </div>
        <br />
        
    </div>
    
<br />
<div class="content3"></div>
</asp:Content>
