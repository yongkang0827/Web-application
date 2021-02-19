<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Favourite.aspx.cs" Inherits="test2.LMY.ASPX.Favourite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
<style>
        .div1{
            font-family:cursive;
            text-align:left;
        }
        .div2{
            font-family:cursive;
            text-align:left;
        }
    </style>
    <div class="div1">
        <h1>
            Purchase History
        </h1>
    </div>
     <div class="div1">         
           <asp:DataList ID="dlFavourite" runat="server" HorizontalAlign="Justify" RepeatColumns="3" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34ebd2">
                   <AlternatingItemStyle BackColor="White" ForeColor="#34ebd2" />
               <FooterStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <HeaderStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <ItemStyle BackColor="#5534eb" ForeColor="#f8f7fa" />
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
