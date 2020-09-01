<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="CommanderWebsite.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left; width: 50%; margin-left: 70px;">
                 <asp:repeater ID="rprtCart" runat="server">
                            <ItemTemplate>
             <div  style="float: left; width: 100%" align="center">
           
                <div>
                    <h1 ><%#Eval("PackageName") %></h1>
                    <p style="font-size: xx-large"><%#Eval("PackageType") %></p>
                    <p style="font-size: x-large">R <%#Eval("PackageCost") %></p>
                    <hr />
                    <p></p>
                    <p></p>
                  

                </div>
                <asp:Label runat="server" id="llb" Text=""></asp:Label>
                
                <div>
                   <p><b>We accept Cash Payments Only</b></p>
                   <p><b>No Refunds</b></p>
                </div>
                <hr />
                
                
                
             </div> 
              <br />
               <br />   
             </ItemTemplate>
                        </asp:repeater>
                        <div align="center">
                   <asp:button runat="server" text="Remove Item" ID="rem" CssClass="btn" onclick="rem_Click"
                  />  &nbsp;  &nbsp;  &nbsp;  &nbsp;<asp:button runat="server" ID="btnCheckout" 
                        CssClass="btn" Text="Checkout" onclick="btnCheckout_Click" 
                PostBackUrl="~/Restricted Access/Customer/CheckOut.aspx" />
                </div>
                </div>
                
                
                
                <br />
            <br />
                 
       
            <asp:label runat="server" text="Label" ID="idf" Visible="False"></asp:label>
            
     
        
</asp:Content>
