<%@ Page Title="Profile Settings" Language="C#" MasterPageFile="Customer.Master" AutoEventWireup="true" CodeBehind="ProfileSettingsCustomer.aspx.cs" Inherits="CommanderWebsite.Customer.ProfileSettingsCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  class="container-fluid" style="text-align:center;padding-right:15px; display:flex; width:100%; justify-content:center;">
        <div id="AccountSetting" class="row" style="border: medium solid #000000; margin-bottom: 26px;" >
            <div id="Account" style="text-align:center">
            <div  style="  font-size: x-large; text-align:center">
                Account Settings</div>
                    <div style="" class="img-rounded">
                  
                    <table><tr>
                    <td colspan ="2" class="style4" align="center">
                        <asp:image runat="server" Height="203px" Width="242px" 
                            ImageAlign="Middle" ImageUrl="~/Content/Images/UserAvatar0.png" ID="image1" 
                            CssClass="img-thumbnail img-circle">
                        </asp:image>
                    
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Change" onclick="Button1_Click" 
                            CssClass="btn" />
                        <br />
                         </td>   </tr>
            <tr><td class="style5"></td><td class="style2" align="center">
                <asp:fileupload runat="server" ID="fileup" Visible="False" 
                    CssClass="form-control">
                </asp:fileupload>
            </td>
            </tr>
            <tr><td colspan="2">
                
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        <br />
                
                        <asp:button runat="server" text="Upload" ID="btnUpload" Width="109px" 
                            onclick="btnUpload_Click" Visible="False" CssClass="btn" />
            </td>
            </tr>
             <tr>              
            
               
            <td class="style5"><b>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name "></asp:Label></b></td>
            <td class="style2"><b>
                <asp:TextBox ID="tbFirstName"
                runat="server" Width="231px" CssClass="form-control"></asp:TextBox>
            </b></td>
            </tr>
             <tr>
             <td class="style5">
            
            <b>
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label></b></td>
            <td class="style2"><b>
                <asp:TextBox ID="tbLastName"
                runat="server" Width="231px" CssClass="form-control"></asp:TextBox>
            </b></td>
            </tr>  
             <tr>
              <td class="style5">  
            <b>
            <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth "></asp:Label></b></td>
            <td class="style2">
            <div class="input-group" style="width:231px;">
            <asp:TextBox ID="tbDOB" placeholder ="yyyy/mm/dd" runat="server"  CssClass="form-control"></asp:TextBox>
                <div class="input-group-addon">
    <button runat="server" type="button" onclick="showIt()" style="background-color:transparent; background:none;border:none" class=" glyphicon glyphicon-calendar" ></button>
                </div></div>
                <script type="text/javascript">
                    function showIt() {
                        if(document.getElementById("Calender2").style.display == "none")
                            document.getElementById("Calender2").style = "display:block;";
                        else {
                            document.getElementById("Calender2").style = "display:none;";
                        }
            };
                    showIt();

        </script>
              
            </td>
                    <tr><td class="style6"></td><td class="style3"><div id="Calender2" style="display:none"><b>
            <asp:calendar runat="server" ID="Calender1" 
                    onselectionchanged="Calender_SelectionChanged" BackColor="White" 
                    BorderColor="Black" Font-Names="Times New Roman" Font-Size="10pt" 
                    ForeColor="Black" Height="220px" Visible="True" 
                    Width="300px" DayNameFormat="Shortest" NextPrevFormat="FullMonth" TitleFormat="Month">
                    <DayHeaderStyle BackColor="#CCCCCC" ForeColor="#333333" Height="10pt" Font-Bold="True" Font-Size="7pt" />
                    <DayStyle Width="14%" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" ForeColor="#333333" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" Width="1%" />
                    <TitleStyle BackColor="Black" 
                        Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                    <TodayDayStyle BackColor="#CCCC99" />
                </asp:calendar></b></div>
                        
                </td></tr>
            </tr> 
             <tr><td class="style5">
                
            <b>
            <asp:Label ID="lblGender" runat="server" Text="Gender "></asp:Label></b></td>
            <td class="style2"><b>
                <asp:dropdownlist ID="dpGender" runat="server" Width="90px" 
                    CssClass="form-control">
                    <asp:ListItem Value="M"></asp:ListItem>
                    <asp:ListItem>F</asp:ListItem>
                </asp:dropdownlist>
            </b></td>
            </tr> 
             <tr><td class="style5">  
            <b>
            <asp:Label ID="lblCellphone" runat="server" Text="Cellphone"></asp:Label></b></td>
            <td class="style2"><b>
            <asp:TextBox ID="tbCellphone"
                runat="server" Width="231px" CssClass="form-control"></asp:TextBox>
            </b>
            </td></tr>
            <tr><td class="style5">  
            <b>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label></b></td>
            <td class="style2">  
            <b><asp:TextBox ID="tbEmail"
                runat="server" Width="231px" CssClass="form-control"></asp:TextBox>
            </b></td>
            </tr>
             <tr><td class ="style5">
            <b>
            <asp:Label ID="lblHouseNumber" runat="server" Text="Address Line"></asp:Label></b></td>
            <td class ="style2"><b>
            <asp:TextBox ID="tbHouseNumber"
                runat="server" Width="231px" CssClass="form-control" Height="205px" TextMode="MultiLine"></asp:TextBox>
            </b>
                
        
            </td></tr>
            
             </table>
           <asp:Label ID="Label2" runat="server" Text="Label" Visible="False" 
                            ForeColor="Red"></asp:Label>
            <hr />
            
             
                        <p id = "bot" align="center" style="border: medium solid #000000; " >
                           
                
           <asp:Button ID="Update" runat="server" Text="Update" Width="93px" Height="41px" 
                                onclick="Update_Click" CssClass="btn btn-default"  />
         
          
           
        
  
            </p> 
             <p>Click <a href="/Account/Manage.aspx">Here</a> to manage your account</p>
                        <p>
                            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                          
                        </p>
          </div>
               
               
              
               
               
               </div>
               </div>
        </div>
</asp:Content>
