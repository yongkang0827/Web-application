<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ImgFav.aspx.cs" Inherits="test2.HDY.ASPX.ImgFav" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="205px" Width="351px">
        <Columns>
            <asp:BoundField DataField="ImgId" HeaderText="ImgID" />
            <asp:BoundField DataField="Img" HeaderText="Img" />
        </Columns>
    </asp:GridView>
</asp:Content>
