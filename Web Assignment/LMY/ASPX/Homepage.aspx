<%@ Page Language="C#" MasterPageFile="~/LMY/ASPX/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Web_Assignment.LMY.ASPX.Homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">


      <nav class="fix">
		<div class="top">
			<a href="../../TYK/HTML/Homepage.html" style="float: left"><img src="../IMG/Puadike2.png" alt="logo" height="68" width="289"/></a>
			<div class="box">
				<ul class="topRight">
					<li style="right: 9%"><a href="../../TYK/HTML/Login.html"><span>LOGIN</span></a></li>
					<li style="right: -1%"><a href="../../CXC/HTML/Cart.html"><span>CART</span></a></li>
				</ul> 
			</div>
		</div>
		<div class="btm">
			<ul>
				<li><a href="../../LMY/HTML/Product Categories.html">men</a></li>
				<li><a href="../../LMY/HTML/Product Categories.html">women</a></li>
				<li><a href="../../LMY/HTML/Product Categories.html">kids</a></li>
			</ul>
			
				<input type="text" placeholder="Search"/>
			
		</div>
		<br/><br/><br/><br/><br/>
	</nav>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></br>
    <asp:Button ID="btnBookTkt" runat="server" Text="Book Ticket" OnClientClick="javascript:alert('You are now will be directed to the booking confirmation page')" PostBackUrl="~/LMY/ASPX/Test.aspx" OnClick="btnBookTkt_Click" />
</asp:Content>

<asp:content id="content2" runat="server" contentplaceholderid="head">
    <link href="../css/stylesheet1.css" rel="stylesheet" type="text/css" />
	<link rel="stylesheet" href="../css/stylesheet2.css"/>
	<link href="../css/stylesheet3.css" rel="stylesheet" type="text/css" />

</asp:content>
