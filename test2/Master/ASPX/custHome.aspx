<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="custHome.aspx.cs" Inherits="test2.Home" %>
<%@ Register TagPrefix="c1" TagName="c2"  Src="~/Master/ASPX/Home.ascx" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <c1:c2 ID="UC1" runat="server" />

</asp:Content>
