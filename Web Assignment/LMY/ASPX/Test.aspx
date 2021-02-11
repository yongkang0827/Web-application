<%@ Page Language="C#"  MasterPageFile="~/LMY/ASPX/Site1.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Web_Assignment.LMY.ASPX.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">

    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <p>pg 1 data is: <%=Session["pg1"] %></p>
</asp:Content>
