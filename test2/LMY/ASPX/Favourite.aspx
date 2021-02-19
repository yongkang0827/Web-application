<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Favourite.aspx.cs" Inherits="test2.LMY.ASPX.Favourite" %>
<%@ MasterType VirtualPath="~/Main.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
<style>
        .div1{
            font-family:cursive;
            text-align:left;
            border-width:1px;    
            border-color:Black;    
            border-style:solid;    
            background-color: #E3E3E3; 
            padding:5px 10px 30px 30px;
        }
    </style>
    <div class="div1">
        <h1>
            Favourite
        </h1>
    </div>
     <div class="div1">         
           <asp:DataList ID="dlFavourite" runat="server" HorizontalAlign="Justify" RepeatColumns="3" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34ebd2">
               <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                ImageName:
                <asp:Label ID="ImageNameLabel" runat="server" Text='<%# Eval("ImageName") %>' />
                <br /><br />
                <asp:Image  Width="320" Height="150" ID="Image1" runat="server" />
                <br />
                <br />
                            

            </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ImageName], [Image] FROM [PurchaseHistory]"></asp:SqlDataSource>
            <br />
            <br />
         </div>
</asp:Content>
