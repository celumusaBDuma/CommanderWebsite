<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="CommanderWebsite.Views.ViewCart" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class= "container">
    <div align="center">
        
        <div style="margin-left: 40px" >
            <br />
            
                <div class="container" style="padding-top:50px; ">
        <div align="center" style="width: 100%">
            <div  style="float: left; width: 35%; height: 357px;">
            <br />
            <br />
                <div style="max-width:100%" class="thumbnail">

                <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                        
                   
                    <div class="carousel-inner" role="listbox">
                        
                            <div class="item active">
                            
                                 <asp:Image ID="imsdf" ImageUrl="~/Content/Images/noImage.png"  Width="100%" Height="500px"
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
                 <asp:repeater ID="rprtCart" runat="server">
                            <ItemTemplate>
             <div  style="float: left; width: 100%" align="center">
           
                <div>
                    <h1 ><%#Eval("Name") %></h1>
                    <p style="font-size: xx-large"><%#Eval("Type") %></p>
                    <p style="font-size: x-large">R <%#Eval("Price") %></p>
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
                PostBackUrl="~/CheckOut.aspx" />
                </div>
                </div>
                
                
                
                <br />
            </div>   
            <br />
                 
        </div>
           
            <asp:label runat="server" text="Label" ID="idf" Visible="False"></asp:label>
            
        </div>
    
    </div>
        


</div>
<div class="content3"></div>
    
</asp:Content>
