<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="artworkDetails.aspx.cs" Inherits="test2.CWK.ASPX.artworkDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    .item {
        font-family:cursive;
        height:400px;
        width:800px;
        margin-left:auto;
        margin-right:auto;
        
    }

    .name{
        font-family: cursive;
        font-size:x-large;
        text-align: left;
        float: left;
        height:100px;
        width: 500px;
    }

    .details {
            font-family: cursive;
            text-align: left;
            float: left;
            width: 500px;
            height: 300px;
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
        
      .img{
          height:400px;
          width:415px;
      }
       

    </style>

    <table class="item">
                <tr ><td rowspan="2" ><img src="../IMG/Death Masks.jpg" class="img" />
                    </td><td class="name">
                        &nbsp;</td></tr>
                <tr><td class="details">
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



