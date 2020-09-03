<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="CommanderWebsite.Views.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:10px; width:100%"> 
    <table style="text-align:center;">
            <tr>
                <td class="style3" style="color: #800000; font-size: large;">
                Search</td>
                <td class="style2">
                 <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                 </td>
                <td>

                    <asp:Button ID="Button1" runat="server" Text="Go" CssClass="btn btn-default" onclick="Button1_Click" />
                </td>
            </tr>
           
        </table>
    <p> 
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Maroon"></asp:Label></p>
    </div>
  <div style="text-align:center;min-height:1024px;" class="container-fluid">
    <div  class="row2" style="text-align:center">
                               
                    <asp:ListView ID="listViewProducts" runat="server">
                         <EmptyDataTemplate>
                              <div id="NoRecords" runat="server" style="text-align:center;margin:400px;color:black" visible="false">
                                No records are available.
                              </div>
                         </EmptyDataTemplate>
                    <ItemTemplate> 
                    <div class="col-md-3 col-md-4" style="display:flex;padding:15px; text-align:center;">
            
                        <a style="text-decoration:none;" href="ProductView.aspx?ProductID=<%#Eval("Product_ID") %>">
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
