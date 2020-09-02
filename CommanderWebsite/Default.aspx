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
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/sale-text_7ef8864a-6623-4866-81a8-a9ba5a295573_2048x.gif'); background-repeat: no-repeat;">
      
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

    <div class="row">
  <div class="leftcolumn">
    <div class="card thumbnail">
      <h2 style="text-align:center">Our Categories</h2>
      <h5>Title description, Dec 7, 2017</h5>
      <div class="fakeimg" style="height:200px;">Image</div>
      <p>Some text..</p>
      <p>Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
    </div>
    <div class="card thumbnail">
      <h2 style="text-align:center">TITLE HEADING</h2>
      <h5>Title description, Sep 2, 2017</h5>
      <div class="fakeimg" style="height:200px;">Image</div>
      <p>Some text..</p>
      <p>Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
    </div>
  </div>
  <div class="rightcolumn">
    <div class="card thumbnail">
      <h2>About Us</h2>
      <div class="fakeimg" style="height:100px;">Image</div>
      <p>Some text about me in culpa qui officia deserunt mollit anim..</p>
    </div>
    <div class="card thumbnail">
      <div class="w3-display-container container-fluid">
           <div class="row" >
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/CommanderBlack.jpg'); background-repeat: no-repeat;">
      
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image:url('Content/Images/ShortHandsomeLamprey-size_restricted.gif'); background-repeat: no-repeat;">
                      <div class="w3-display-bottommiddle w3-container w3-padding-16 w3-black">
                    <b>Not For The Faint Hearted </b>
                  </div>
     
                  </div>
                  <div class="mySlides w3-animate-left element-animated" style=" background-size:100% 100%; width:100%; background-image: url('Content/Images/sale-text_7ef8864a-6623-4866-81a8-a9ba5a295573_2048x.gif'); background-repeat: no-repeat;">
      
                  </div>

           </div>

  <button class="w3-button w3-black w3-display-left" style="margin-left:-15px;" type="button" onclick="plusDivs(-1)">&#10094;</button>
  <button class="w3-button w3-black w3-display-right" type="button" style="margin-right:-15px;" onclick="plusDivs(1)">&#10095;</button>
</div>
    </div>
    <div class="card thumbnail">
      <h3>Follow Us</h3>
      <p style=" text-align:center"><a class="fa fa-facebook" href="#"></a>
          <a class="fa fa-whatsapp" href="#"></a>
          <a class="fa fa-twitter" href="#"></a>
          <a class="fa fa-instagram" href="#"></a>
          <a class="fa fa-google" href="#"></a>
          <a class="fa fa-youtube" href="#"></a>
      </p>
    </div>
  </div>
</div>
</div> 
</asp:Content>
