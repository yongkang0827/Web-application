<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="test2.CWK.ASPX.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="div1">
        <h1>
            Shopping Cart
        </h1>
    </div>
     <div class="div1">         
           <asp:DataList ID="dlOrder" runat="server" HorizontalAlign="Justify" RepeatColumns="3" RepeatDirection="Horizontal" OnItemDataBound="DataList1_ItemDataBound" CellPadding="4" ForeColor="#34EBD2" DataKeyField="OrderID" DataSourceID="SqlDataSource1">
                   <AlternatingItemStyle BackColor="White" ForeColor="#34ebd2" />
               <FooterStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <HeaderStyle BackColor="#5534eb" Font-Bold="True" ForeColor="#f8f7fa" />
               <ItemStyle BackColor="#5534eb" ForeColor="#f8f7fa" />
            <ItemTemplate>
                OrderID:
                <asp:Label ID="OrderIDLabel" runat="server" Text='<%# Eval("OrderID") %>' />
                <br />CustID:
                <asp:Label ID="CustIDLabel" runat="server" Text='<%# Eval("CustID") %>' />
                <br />
                ImageName:
                <asp:Label ID="ImageNameLabel" runat="server" Text='<%# Eval("ImageName") %>' />
                <br />
                Image:
                <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("Image") %>' />
                <br />
                            

                Price:
                <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                <br />
                CustName:
                <asp:Label ID="CustNameLabel" runat="server" Text='<%# Eval("CustName") %>' />
                <br />
                <br />
                            

            </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Order]"></asp:SqlDataSource>
            <br />
            <br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </div>
</asp:Content>

