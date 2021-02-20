<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="test2.CWK.ASPX.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
      .pdbtn{
            height:50px;
            width:220px;
            color: white;
            background-color:darkblue;
            text-align: center;
            cursor: pointer;
            font-family:cursive;
       }
        
     

        .div1{
            font-family:cursive;
            text-align:left;            
            margin-left:auto;
            margin-right:auto;
        }

        .formview{
            margin-left:auto;
            margin-right:auto;

        }

    </style>

     <div class="div1">
        <h1>
           Artwork Details
        </h1>
    </div>
    <div class="div1">
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="PostId" DataSourceID="SqlDataSource1" CssClass="formview" OnPageIndexChanging="FormView1_PageIndexChanging">
                    
            <ItemTemplate>
                <table>
                    <tr><td><asp:Image  Width="400" Height="200" ID="Image1" runat="server"/></td></tr>
                    <tr><td>Post ID :   <%# Eval("PostId") %></td></tr>
                    <tr>
                       <td>Name :   <%# Eval("Title") %></td>
                    </tr>                   
                    <tr> 
                        <td>
                            Price : <%# Eval("Price") %></br>
                            Quantity Remaining : <%# Eval("Quantity") %>

                    </td><td>
                   
                    <asp:Button ID="btnBuyNow" runat="server" Text="Buy Now" OnClick="btnBuyNow_Click" CssClass="pdbtn"/>
                    <asp:BulletedList ID="BulletedList1" runat="server">
                        <asp:ListItem>Express Shipping</asp:ListItem>
                        <asp:ListItem>Artwork sign by artist</asp:ListItem>
                        <asp:ListItem>Returns Accepted 14 days</asp:ListItem>
                    </asp:BulletedList>
                    </td>
                    </tr>
                     <tr> <td>Description   :    <%# Eval("Description") %> </td></tr>
                     <tr> <td>Upload Date   : <%# Eval("DateUpload") %></td></tr>                                                           
               </table>

            </ItemTemplate>
        </asp:FormView>
                    
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Img]"></asp:SqlDataSource>
                                
            </div>
</asp:Content>
