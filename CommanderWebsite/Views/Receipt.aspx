<%@ Page Title="Receipt" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="CommanderWebsite.Views.Receipt" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function BtnPrint_onclick() {
            var prtContent = document.getElementById("printArea");
            var WinPrint = window.open('', '', 'letf=0,top=0,toolbar=0,sta­tus=0');
            WinPrint.document.write(prtContent.innerHTML);
            WinPrint.document.close();
            WinPrint.focus();
            WinPrint.print();
        }
        

    </script>

    <style type="text/css">
        #imageUni
        {
            height: 192px;
        }
        #PrintArea
        {
            height: 665px;
        }
    </style>
    <div  class="content" align="center">
    <br />

        <br />
        <div id="printArea" style="height: 513px" align="center">
        <div id="imageUni" align="center">
        
                
                <div align="center" id="v" class="img-img-rounded">
                <asp:Image ID="Image8" 
                    runat="server" BackColor="White"   
                Height="181px" ImageAlign="Middle" 
                ImageUrl="~/Content/Images/CommanderPic.jpg" Width="316px" />
                &nbsp;&nbsp;&nbsp;
                </div>
                
        </div>
           <b> <asp:label runat="server" text="Label" ID="datelbl" Font-Size="XX-Large"></asp:label>
           
            <br />
            <asp:Label ID="Label2" runat="server" Text="Customer Name:" 
                Font-Size="XX-Large"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="XX-Large"></asp:Label>
            <br /></b>
        <br />
            <asp:gridview runat="server"  
                CellPadding="4" ForeColor="Black" 
                GridLines="Horizontal" Height="184px" Width="800px" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Font-Bold="True" 
                Font-Size="Large" ID="gv3">
               
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="#3366CC" 
                HorizontalAlign="Center" VerticalAlign="Middle" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <sortedascendingcellstyle backcolor="#E9E7E2" />
            <sortedascendingheaderstyle backcolor="#506C8C" />
            <sorteddescendingcellstyle backcolor="#FFFDF8" />
            <sorteddescendingheaderstyle backcolor="#6F8DAE" />

<SortedAscendingCellStyle BackColor="#F7F7F7"></SortedAscendingCellStyle>

<SortedAscendingHeaderStyle BackColor="#4B4B4B"></SortedAscendingHeaderStyle>

<SortedDescendingCellStyle BackColor="#E5E5E5"></SortedDescendingCellStyle>

<SortedDescendingHeaderStyle BackColor="#242121"></SortedDescendingHeaderStyle>
            </asp:gridview> 
            <hr />
            <br />
           <div style="text-align:center; font-size:large">Payments are made on delivery.
               <br />
                Delivery take two days we will contact you.
               <br />
                Thanks for choosing us</div>
        </div>
    <br />
        <br />
    <br />
        <hr />
        <asp:button runat="server" 
            text="Back To Home" CssClass="btn" ID="backho" onclick="Unnamed3_Click" 
            Height="48px" Width="144px" />
        &nbsp;&nbsp; <input id="Button1" type="button" value="Print" 
            onclick="return BtnPrint_onclick()" class="btn btn-default" /> &nbsp;
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
    </div>
    <br />
    <br />
    <div class="content3" align="center">
        <br />
        
        <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
</asp:Content>
