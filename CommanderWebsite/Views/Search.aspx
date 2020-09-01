<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="CommanderWebsite.Views.Search" %>
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
    <div>
        <div class="container">
            <div class="row">
    <asp:ListView ID="listViewProducts" runat="server">
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
                
                                <asp:Image ID="imgs" Width="100%" Height="300px" ImageAlign="Middle" runat="server"></asp:Image>
                            </div>
                            <div class= "caption">
                                <h1><%#Eval("Name") %></h1>
                                <h2 style=" font-weight: bold; font-size: xx-large;">Code <%#Eval("Type") %></h2>
                                <h2 style=" font-weight: normal; font-size:x-large;">R <%#Eval("Price")%></h2>
                                <asp:Label ID="Label1" runat="server" Visible="False" Text='<%# Eval("Product_ID") %>'></asp:Label>
                            </div>
                        </div></a>
                    </div></ItemTemplate>
                       
        </asp:ListView>
    </div>
    </div>

    </div>
</asp:Content>
