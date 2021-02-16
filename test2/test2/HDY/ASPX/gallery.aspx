<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="test2.HDY.ASPX.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
     /* Create four equal columns that floats next to each other */
* {
  box-sizing: border-box;
}

body {
  font-family: Arial, Helvetica, sans-serif;
}

/* Float four columns side by side */
.column {
  float: left;
  width: 25%;
  padding: 0 10px;
  text-align: center;
  font-family:cursive;
}

/* Remove extra left and right margins, due to padding in columns */
.row {margin: 0 -5px;}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}

.button {
  border: none;
  outline: 0;
  padding: 12px;
  color: white;
  background-color:darkblue;
  text-align: center;
  cursor: pointer;
  width: 100%;
  font-size: 18px;
  font-family:cursive;
}

/* Style the counter cards */
.card {
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); /* this adds the "card" effect */
  padding: 16px;
  text-align: center;
  background-color: #f1f1f1;
}

/* Responsive columns - one column layout (vertical) on small screens */
@media screen and (max-width: 600px) {
  .column {
    width: 100%;
    display: block;
    margin-bottom: 20px;
  }
.price {
  color: black;
  font-size: 22px;
  font-family:cursive;
}


}
          .imgSize {
              width: 345px;
              height: 413px;
          }
          .title{
              text-align:center;
              font-family:cursive;
          }
 </style>
    <br />
    <h1 class="title">Galleries</h1>
   <div class="row">
  <div class="column">
    <div class="card"><img src="../IMG/Torso of a Woman.jpg" class="imgSize"/>
        <h1>Torso of a Women</h1>
        <p class="price">RM1000</p>
        <p>Gallery 1</p>
        <p>
         <asp:Button ID="btnBuy" runat="server" Text="Buy Now" class="button" OnClick="btnBuy_Click" PostBackUrl="~/cart.aspx"/>
        </p></div>
  </div>
  <div class="column">
    <div class="card"><img src="../IMG/Machines for Suffering.jpeg"  class="imgSize"/>
        <h1>Machines for Suffering</h1>
        <p class="price">RM1000</p>
        <p>Gallery 2</p>
        <p>
        <asp:Button ID="btnBuy2" runat="server" Text="Buy Now" class="button" OnClick="btnBuy_Click" PostBackUrl="~/cart.aspx"/>
        </p></div>
  </div>
  <div class="column">
    <div class="card"><img src="../IMG/Death Masks.jpg"  class="imgSize"/>
        <h1>Death Masks</h1>
        <p class="price">RM1000</p>
        <p>Gallery 3</p>
      <br />
        <p>
            <asp:Button ID="btnBuy3" runat="server" Text="Buy Now" class="button" OnClick="btnBuy_Click" PostBackUrl="~/cart.aspx"/>
        </p></div>
  </div>
  <div class="column">
    <div class="card"><img src="../IMG/Artifact.jpg"  class="imgSize"/>
        <h1>Artifact</h1>
        <p class="price">RM1000</p>
        <p>Gallery 4</p>
      <br />
        <p>
            <asp:Button ID="btnBuy4" runat="server" Text="Buy Now" class="button" OnClick="btnBuy_Click" PostBackUrl="~/cart.aspx"/>
        </p></div>
  </div>
<div class="column">
    <div class="card"><img src="../IMG/Prodromes.jpg" class="imgSize"/>
        <h1>Prodromes</h1>
        <p class="price">RM1000</p>
        <p>Gallery 5</p>
      <br />
        <p>
            <asp:Button ID="btnBuy5" runat="server" Text="Buy Now" class="button" OnClick="btnBuy_Click" PostBackUrl="~/cart.aspx"/>
        </p></div>
  </div>
    
</div>
</asp:Content>
