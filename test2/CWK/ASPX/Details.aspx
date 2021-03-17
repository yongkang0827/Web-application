﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="test2.CWK.ASPX.Details" %>
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
           
        }       

         .auto-style3 {
             height: 174px;
         }
         .auto-style4 {
             height: 59px;
         }

        .div2{
            margin-left:auto;
            margin-right:auto;
            padding-left:400px;
        }
        .dateLay{
            padding-left:1200px;
        }
        .qtyInp{
            
            font-size:large;
        }
        .imgSize2{
            width:180px;
          
        }
    </style>
    <div class="dateLay">
    <asp:TextBox ID="txtDate" runat="server" Enabled="False"></asp:TextBox>
        </div>
     <div class="div1">
        <h1>
           Artwork Details
        </h1>
    </div>
     <div class="div2">
         <div>
           <asp:DataList ID="dlDetails" runat="server" HorizontalAlign="Justify" RepeatColumns="1" RepeatDirection="Horizontal" OnItemDataBound="dlDetails_ItemDataBound" CellPadding="4" ForeColor="#333333" RepeatLayout="Flow" OnSelectedIndexChanged="dlDetails_SelectedIndexChanged" OnItemCommand="dlDetails_ItemCommand">
               <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <ItemTemplate>
                </div>
                <table>
                    <tr>
                       <td style="font-size:large"> <%# Eval("DetailsId") %></td>
                    </tr>
                    <tr><td><asp:Image  Width="320" Height="300px" ID="Image1" runat="server" /></td></tr>
                    <tr> 
                        <td class="auto-style3">
                            <h2>Price : <%# Eval("Price") %> </h2>
                            <h2 class="auto-style4">Name : <%# Eval("ImageName") %> </h2> 
                            <h2>Quantity : <%# Eval("Quantity") %> </h2> 
                        </td>
                    </tr> 
                </table>

                </ItemTemplate>
               <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>

             <table>
                 <tr><td><h2>Quantity:<asp:TextBox ID="txtQty" runat="server"></asp:TextBox></h2> </td></tr> 
                    <tr><td>
                        <img src="../IMG/card.png" class="imgSize2"/></td></tr>
                    <tr><td>
                        <asp:Label ID="lblCardNumber" runat="server" Text="Card Number"></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtCardNumber" runat="server" class="textfield"></asp:TextBox></td></tr>
                    <tr><td>
                        <asp:Label ID="lblCVV" runat="server" Text="CVV" ></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtCVV" runat="server" TextMode="Password" class="pass"></asp:TextBox></td></tr>
                    <tr><td>
                        <asp:Label ID="lblPin" runat="server" Text="Pin Number" ></asp:Label></td></tr>
                    <tr><td>
                        <asp:TextBox ID="txtPin" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:Button ID="btnPin" runat="server" Text="Pin Number" onClick="PinNumber"/>
                    </tr>
               </table>
           
            

             <div >            
                                   
            
             <asp:Button ID="btnBuyNow" runat="server" Text="Buy Now" CssClass="pdbtn"  CommandArgument='<%# Eval("name") %>' CommandName="Quantity" OnClick="btnBuyNow_Click"/>
            <asp:Button ID="btnBack" runat="server" Text="Back To Gallery" CssClass="pdbtn" OnClick="btnBack_Click"/>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Details]"></asp:SqlDataSource>
                                
                    <asp:BulletedList ID="BulletedList1" runat="server"> 
                        <asp:ListItem>Express Shipping</asp:ListItem>
                        <asp:ListItem>Artwork sign by artist</asp:ListItem>
                        <asp:ListItem>Returns Accepted 14 days</asp:ListItem>
                    </asp:BulletedList>
      
            </div>
       
                                
            </div> 
              </div>
</asp:Content>
