<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CommanderWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="body-def">   
       <div class="w3-display-container container-fluid">
           <div class="row" >
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/CommanderBlack.jpg'); background-repeat: no-repeat;">
      
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image:url('Content/Images/ShortHandsomeLamprey-size_restricted.gif'); background-repeat: no-repeat;">
                      <div class="w3-display-bottommiddle w3-container w3-padding-16 w3-black">
                    <b>Not For The Faint Hearted </b>
                  </div>
     
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/Screenshot (289).png'); background-repeat: no-repeat;">
      
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-repeat: no-repeat; background-color: #000000;">
                        <div class="w3-display-middle w3-container w3-padding-16 w3-black">
                    <b style="font-size:xx-large">Get it! <br />
                        Don't overthink, <br /> just buy </b>
                            <br />
                          <b style="text-align:center;">  Shop now</b>
                            <br />
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-default" style="background-color:transparent;border: 3px solid white;color:white" Text="Men" PostBackUrl="~/Views/Men" /> &nbsp;
                             <asp:Button ID="Button2" CssClass="btn btn-default" style="background-color:transparent;border: 3px solid white;color:white" runat="server" Text="Women" PostBackUrl="~/Views/Women" />
                  </div>
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/lauren-fleischmann-ZogRkvEnahU-unsplash.jpg'); background-repeat: no-repeat;">
      
                   </div>

           </div>

  <button class="w3-button w3-black w3-display-left" style="margin-left:-15px;" type="button" onclick="plusDivs(-1)">&#10094;</button>
  <button class="w3-button w3-black w3-display-right" type="button" style="margin-right:-15px;" onclick="plusDivs(1)">&#10095;</button>
</div>

<script type="text/javascript">
var slideIndex = 1;
showDivs(slideIndex);

function plusDivs(n) {
  showDivs(slideIndex += n);
}

function showDivs(n) {
  var i;
  var x = document.getElementsByClassName("mySlides");
  if (n > x.length) {slideIndex = 1}
  if (n < 1) {slideIndex = x.length}
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  x[slideIndex-1].style.display = "block";  
}
</script>
 
<script>
var myIndex = 0;
carousel();

function carousel() {
  var i;
  var x = document.getElementsByClassName("mySlides");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";  
  }
  myIndex++;
  if (myIndex > x.length) {myIndex = 1}    
  x[myIndex-1].style.display = "block";  
  setTimeout(carousel, 10000); // Change image every 10 seconds
}
</script>
          
<div style="background-color: white">
  
    <div style="background-color: white" >
      <h2 style="text-align:center; color: black; font-family:Courier New, Courier, monospace">-Our Categories-</h2>
      <h5 style="text-align:center; color: black; font-family:Courier New, Courier, monospace">From Jeans, Pants, Tops to Shoes </h5> 
      <div class="fakeimg" style="height: 550px; background-size:100% 100%; border-color: white; width:100%; background-image: url('Content/Images/20200906_014103.jpg');"> </div>
       </div>
        <div>
          <p style="text-align:center; color: black; font-family:Courier New, Courier, monospace"> Whether you are looking for quality combat clothing, the newest camouflague, or accessories to channel your inner hunter Commander is the perfect shop for you.</p>
    </div>
      </div>
   
    <div class="row">
        <div style="float:left;width:50%;padding: 25px;">
            <div class="card thumbnail" style="padding: 25px;">
                 <a href="Views/Men">
                <asp:Image ID="Image1" style="width:100%;height:300px;" runat="server" ImageAlign="Middle" ImageUrl="~/Content/Images/WhatsApp Image 2020-09-03 at 15.34.08.jpeg" />
                <p style="text-align:center;font-size:x-large">Men</p>

                 </a>
            </div>
        </div>
        <div style="float:left;width:50%;padding: 25px;">
            <div class="card thumbnail" style="padding: 25px;">
                <a href="Views/Women">
                <asp:Image ID="Image2" style="width:100%;height:300px;" runat="server" ImageAlign="Middle" ImageUrl="~/Content/Images/WhatsApp Image 2020-09-03 at 21.51.07 (2).jpeg" />
                <p style="text-align:center;font-size:x-large">Women</p>

                </a>
            </div>
        </div>
    </div>
    <div>
      <h2 style="text-align:center; color: black; font-family:Courier New, Courier, monospace">-It's Spring Time-</h2>
      
      
    </div>
    &nbsp 
    <div style="width:100%">
        
        <div><img src= "Content/Images/mohammed-hassan-HQmVMMpBjvM-unsplash.jpg" style="width: 33.3%; height: 300px" class="pull-left" /> </div>
           
        <div ><img src= "Content/Images/anomaly-WWesmHEgXDs-unsplash.jpg" style="width: 33.3%;margin-top:100px; height: 300px" class="text-center" /> </div>
            
        <div><img src= "Content/Images/aejaz-memon-7bt8lEnGKO8-unsplash.jpg" style="width: 33.4%;margin-top:-100px; height: 300px" class="pull-right" /> </div>
        
    <div style="text-align:center; color: black;display:block; font-family:Courier New, Courier, monospace; height:100px"> As the season shifts, invest in the finer things that feel as good as they look.</div>
   
            
     </div>
    <br />
    <div>
      <h3 style=" text-align:center; font-family:Courier New, Courier, monospace; background-color: red ">Follow Us</h3>
      <p style=" text-align:center"><a class="fa fa-facebook" href="#"></a>
          <a class="fa fa-whatsapp" href="#"></a>
          <a class="fa fa-twitter" href="#"></a>
          <a class="fa fa-instagram" href="#"></a>
          <a class="fa fa-google" href="#"></a>
          <a class="fa fa-youtube" href="#"></a>
      </p>
    </div>
</div>
</asp:Content>
