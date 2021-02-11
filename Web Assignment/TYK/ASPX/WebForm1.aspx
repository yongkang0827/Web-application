<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/LMY/ASPX/Site1.Master" CodeBehind="WebForm1.aspx.cs" Inherits="Web_Assignment.TYK.ASPX.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <p>pg 1 data is: <%=Session["pg1"] %></p>
</asp:Content>