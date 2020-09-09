<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CommanderWebsite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" type="text/css" href="Styles/Contact.css" />
    <style>        
        .mapouter{position:relative;text-align:right;height:501px; width:600px;top: 0px;left: 0px;}
        .gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}
      </style>

<br />

    <div class="container" style="height: 700px">

    <h2 align="center">Contact Us</h2>
    <h3 align="center">If you have any inquiries about our services please send us an email below</h3>
    <hr />

  
    
    <div class="col" style="float:left; width:40%">
      <div>
        <label for="fname">Your Name</label>
        <input type="text" id="fname" name="firstname" placeholder="Your name.." 
            runat = "server" style="width: 100%; height: 39px;" class="form-control" />
        <label for="lname">Your Email</label>
        <input type="text" runat = "server" id="EmailAddress" name="lastname" 
            placeholder="Your email address.." style="width: 100%" 
            class="form-control" />
        <br />
        <label for="fname">Subject</label><input type="text" id="Text1" 
            name="firstname" placeholder="Subject" runat = "server" 
            style="width: 100%" class="form-control"/><br />
        <label for="subject">Message</label>
        <textarea  class="form-control" rows="0" id="body" name="subject" runat = "server" 
            placeholder="Write something.." style="height:170px; width: 100%;" cols="0"></textarea><br />
        &nbsp;
      </div>
        <asp:Button ID="Button1" CssClass="btn btn-default" runat="server" OnClick="Button1_Click" 
            Text="Submit" />
        <br />
        
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    <div class="col" style="float:left; width:53%; margin-left: 20px;">
      <div class="mapouter img-thumbnail img-rounded" 
            style="width: 100%; height: 510px">
      <div class="gmap_canvas " style="width: 100%" >
      <iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=140%20langalibalele%20street%20engen&t=&z=19&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0">
      </iframe><a href="https://www.embedgooglemap.org">wordpress embed a google map on contact page</a>
    </div>
  </div>
</div>
</div>
<br />
<br />
<br />
<br />
</asp:Content>
