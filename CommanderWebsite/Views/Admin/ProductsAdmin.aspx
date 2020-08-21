<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductsAdmin.aspx.cs" Inherits="CommanderWebsite.Views.Admin.ProductsAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:lightgrey; left:0; top:0; height:50px; width:100%; border-bottom-left-radius:10px; border-bottom-right-radius: 10px;">
        <h1 style="text-align: center;">Products</h1>
    </div>
 <div style="width:100%;"><button class="btn btn-default pull-right">Create</button></div>   
 <div align="center" class="container">
    <div  class="row2" style=" " align="center">
                    
                    <asp:repeater ID="rptrPackages" runat="server" 
                        onitemdatabound="rptrPackages_ItemDataBound">
                    <ItemTemplate> 
        <div class=" col-md-3 col-md-4" align="center">
            
            <a style="text-decoration:none;" href="PackageView.aspx?PackageID=<%#Eval("Product_ID") %>">
            <div class="thumbnail">
                <div align="center" style="width: 100%; height: 30%">
                
                    <asp:Image ID="imgs" ImageUrl="Resources/noImage.png"  Width="100%" Height="300px" ImageAlign="Middle" runat="server"></asp:Image>
                </div>
                <div class= "caption">
                    <h1><%#Eval("Name") %></h1>
                    <h2 style=" font-weight: bold; font-size: xx-large;" align="center">Code <%#Eval("Type") %></h2>
                    <h2 style=" font-weight: normal; font-size:x-large;">R <%#Eval("Price")%></h2>
                    <asp:Label ID="Label1" runat="server" Visible="False" Text='<%# Eval("Product_ID") %>'></asp:Label>
                </div>
            </div></a>
        </div></ItemTemplate>
                       
        </asp:repeater>
    </div>
</div>

</asp:Content>
