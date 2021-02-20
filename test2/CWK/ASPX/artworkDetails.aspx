<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="artworkDetails.aspx.cs" Inherits="test2.CWK.ASPX.artworkDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .item {
        font-family:cursive;
        height:400px;
        width:80%;
        margin-left:auto;
        margin-right:auto;
        
    }

      
     .status{
            font-family:cursive;
            font-size:small;
            text-align:left;

      }

      .pdbtn{
            height:50px;
            width:220px;
            color: white;
            background-color:darkblue;
            text-align: center;
            cursor: pointer;
            font-family:cursive;
       }
        
      
      .detailsview{
          height:200px;
          width: 80%;
      } 

    </style>

    <table class="item">
                <tr ><td >
                    <asp:Image ID="Image1" runat="server"/>
                    </td><td>
                        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="PostId" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" CssClass="detailsview" >
                            <AlternatingRowStyle BackColor="White" />
                            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                            <Fields>
                                <asp:BoundField DataField="PostId" HeaderText="PostId" ReadOnly="True" SortExpression="PostId" />
                                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                                <asp:BoundField DataField="DateUpload" HeaderText="DateUpload" SortExpression="DateUpload" />
                                <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName" />
                                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                            </Fields>
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                        </asp:DetailsView>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Img]"></asp:SqlDataSource>
                    </td></tr>
                <tr><td></td><td class="details">
                    <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart"  OnClick="btnAddToCart_Click"  CssClass="pdbtn"/>
                    <br />
                    <br />
                    <asp:Button ID="btnBuyNow" runat="server" Text="Buy Now" OnClick="btnBuyNow_Click" CssClass="pdbtn"/>
                    <asp:BulletedList ID="BulletedList1" runat="server" CssClass="status">
                        <asp:ListItem>Express Shipping</asp:ListItem>
                        <asp:ListItem>Artwork sign by artist</asp:ListItem>
                        <asp:ListItem>Returns Accepted 14 days</asp:ListItem>
                    </asp:BulletedList>
                    </td></tr>                                      
                
            </table>
</asp:Content>



