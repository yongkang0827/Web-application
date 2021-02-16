<%@ Page Language="C#" MasterPageFile="~/Main.Master"  AutoEventWireup="true" CodeBehind="Purchase History.aspx.cs" Inherits="test2.LMY.ASPX.Purchase_History" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
<style type="text/css">

    .img img{
        padding-top:100px;
	    width:500px;
        height: 400px;      
    }   
    .img1{
	    padding-left:200px;
    }
    .img2{
	    padding-left:100px;
    }
    .label{
        text-align:center;
    }

</style>

    <table class="img">
        <tr><td class="img1">
            <asp:Image ID="img1" runat="server"/>        
            <%--<asp:ImageButton ID="imgLove1" runat="server" OnClick="ImageButton1_Click" />--%>

            </td><td class="img2">
                <asp:Image ID="img2" runat="server" /></td></tr>

        <tr class="label"><td >
            <asp:Label ID="lblimg1" runat="server" Text=""></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server"  AutoPostBack="True" />
            
            </td><td><asp:Label ID="lblimg2" runat="server" Text=""></asp:Label>
                <asp:CheckBox ID="CheckBox2" runat="server"  AutoPostBack="True" />
                 </td></tr>



        <tr><td class="img1">
            <asp:Image ID="img3" runat="server" />
            </td><td class="img2">
                <asp:Image ID="img4" runat="server" /></td></tr>

        <tr class="label"><td>
            <asp:Label ID="lblimg3" runat="server" Text="Label"></asp:Label>
            <asp:CheckBox ID="CheckBox3" runat="server" /></td><td>
                <asp:Label ID="lblimg4" runat="server" Text="Label"></asp:Label>
                <asp:CheckBox ID="CheckBox4" runat="server" /></td></tr>



        <tr><td class="img1">
            <asp:Image ID="img5" runat="server" />
            </td><td class="img2">
                <asp:Image ID="img6" runat="server" /></td></tr>

        <tr class="label"><td>
            <asp:Label ID="lblimg5" runat="server" Text="Label"></asp:Label>
            <asp:CheckBox ID="CheckBox5" runat="server" /></td><td>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:CheckBox ID="lblimg6" runat="server" /></td></tr>
    </table>
      
</asp:Content>

