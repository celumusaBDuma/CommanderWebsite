<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Men.aspx.cs" Inherits="CommanderWebsite.Views.Men" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%; height:40px; position:sticky;"><button class="btn btn-default pull-right">Create</button></div>   
 <div style="text-align:center" class="container">
    <div  class="row2" style="text-align:center">
                               
                    <asp:ListView ID="listViewProducts" runat="server"
                         OnItemDataBound="listViewProducts_ItemDataBound">
                         <EmptyDataTemplate>
                              <div id="NoRecords" runat="server" visible="false">
                                No records are available.
                              </div>
                         </EmptyDataTemplate>
                    <ItemTemplate> 
                    <div class=" col-md-3 col-md-4" style="text-align:center;">
            
                        <a style="text-decoration:none;" href="ProductView.aspx?ProductID=<%#Eval("Product_ID") %>">
                        <div class="thumbnail">
                            <div style="text-align:center; width: 100%; height: 30%">
                              <asp:Image ID="imgs" ImageUrl='<%# "~/FullImage.ashx?ImID="+ Eval("Product_ID") %>'  ImageAlign="Middle" runat="server"></asp:Image>
                                </div>
                            <div class= "caption">
                                <h1><%#Eval("Name") %></h1>
                                <h2 style=" font-weight: bold; font-size: xx-large;"> <%#Eval("Type") %></h2>
                                <h2 style=" font-weight: normal; font-size:x-large;">R <%#Eval("Price")%></h2>
                                <asp:Label ID="Label1" runat="server" style="display:none" Text='<%# Eval("Product_ID") %>'></asp:Label>
                            </div>
                        </div></a>
                    </div></ItemTemplate>
                       
        </asp:ListView>
    </div>
</div>
</asp:Content>
