<%@ Page Title="Products" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ProductsAdmin.aspx.cs" Inherits="CommanderWebsite.Admin.ProductsAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:lightgrey; height:50px;margin-top:0px; width:100%; border-bottom-left-radius:10px; border-bottom-right-radius: 10px;">
        <h1 style="text-align: center;">Products</h1>
    </div>
 <div style="width:100%; height:40px; position:sticky;">
     <asp:Button ID="Button1" runat="server" class="btn btn-default pull-right" Text="ADD" OnClick="Button1_Click" /></div>   
 <div style="text-align:center;min-height:1024px;" class="container-fluid">
    <div  class="row2" style="text-align:center;">
                               
                    <asp:ListView ID="listViewProducts" runat="server"
                         OnItemDataBound="listViewProducts_ItemDataBound">
                         <EmptyDataTemplate>
                              <div id="NoRecords" runat="server" style="text-align:center">
                                No records are available.
                              </div>
                         </EmptyDataTemplate>
                    <ItemTemplate> 
                    <div class="col-md-3 col-md-4" style="padding:15px; text-align:center;">
            
                        <a style="text-decoration:none;" href="ProductsView.aspx?Product_ID=<%#Eval("Product_ID") %>">
                        <div class="card thumbnail" style="height:400px;width:300px; margin-bottom:10px">
                            <div style="text-align:center; width: 100%;padding-bottom:-15px;">
                              <asp:Image ID="imgs" ImageUrl=' <%# "~/FullImage.ashx?ImID="+ Eval("Product_ID") %>' Width="100%" Height="300px"  ImageAlign="Middle" runat="server"></asp:Image>
                                <div class= "caption" style="margin-top:-10px;width:100%">
                                <h3><%#Eval("Name") %></h3>
                                <h2 style=" font-weight: normal; font-size:x-large;">R <%#Eval("Price")%></h2>
                                <asp:Label ID="Label1" runat="server" style="display:none" Text='<%# Eval("Product_ID") %>'></asp:Label>
                            </div></div>
                            
                        </div></a>
                    </div></ItemTemplate>
                       
        </asp:ListView>
    </div>
</div>

</asp:Content>
